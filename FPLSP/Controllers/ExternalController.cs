using Blazored.LocalStorage;
using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels;
using IdentityModel;
using IdentityServer4;
using IdentityServer4.Events;
using IdentityServer4.Services;
using IdentityServer4.Stores;
using IdentityServerHost.Quickstart.UI;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text.RegularExpressions;

namespace FPLSP.Controllers
{

    [SecurityHeaders]
    [AllowAnonymous]
    public class ExternalController : Controller
    {

        private readonly IUserIdentityRepo _userIdentityRepo;
        private readonly ILecturersCPRepo _lecturersCPRepo;
        private readonly ITrainingFacilitiesCPRepo _trainingFacilitiesCPRepo;
        private readonly IStudentClassUPRepo _studentClassUPRepo;
        private readonly ITaskRepositories<ClassUPViewModel> _classRepositories;
        private readonly IRepository<StudentUP> _studentRepo;
        private readonly IStudentUPRepo _studentUPRepo;
        private readonly SignInManager<UserSignIn> _signInManager;
        private readonly UserManager<UserSignIn> _userManager;
        private readonly IIdentityServerInteractionService _interaction;
        private readonly IClientStore _clientStore;
        private readonly ILogger<ExternalController> _logger;
        private readonly IEventService _events;
        private readonly ILocalStorageService _localStorageService;
        string trainingFacilityId;
        private string Partern = "^[a-z]{3,13}[0-9]{5}@fpt.edu.vn";
        public ExternalController(
            IIdentityServerInteractionService interaction,
            IStudentUPRepo studentUPRepo,
            IClientStore clientStore,
            IEventService events,
            ILogger<ExternalController> logger,
            SignInManager<UserSignIn> signInManager,
            UserManager<UserSignIn> userManager, IUserIdentityRepo userIdentityRepo, ILocalStorageService localStorageService, ILecturersCPRepo lecturersCPRepo, ITrainingFacilitiesCPRepo trainingFacilitiesCPRepo, IStudentClassUPRepo studentClassUPRepo, IRepository<StudentUP> studentRepo)
        {

            _studentUPRepo = studentUPRepo;
            _interaction = interaction;
            _clientStore = clientStore;
            _logger = logger;
            _localStorageService = localStorageService;
            _userManager = userManager;
            _signInManager = signInManager;
            _events = events;
            _lecturersCPRepo = lecturersCPRepo;
            _trainingFacilitiesCPRepo = trainingFacilitiesCPRepo;
            _studentClassUPRepo = studentClassUPRepo;
            _studentRepo = studentRepo;
            _userIdentityRepo = userIdentityRepo;
        }


        [HttpGet]

        public IActionResult Challenge(string scheme, string returnUrl)
        {


            if (string.IsNullOrEmpty(returnUrl)) returnUrl = "~/";


            if (Url.IsLocalUrl(returnUrl) == false && _interaction.IsValidReturnUrl(returnUrl) == false)
            {

                throw new Exception("invalid return URL");
            }


            var props = new AuthenticationProperties
            {
                RedirectUri = Url.Action(nameof(Callback)),
                Items =
                    {
                        { "returnUrl", returnUrl },
                        { "scheme", scheme },
                    }
            };

            return Challenge(props, scheme);

        }


        [HttpGet]

        public async Task<IActionResult> Callback()
        {


            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var queryString = HttpContext.Request.Query["X-idp"].ToString();
            if (result?.Succeeded != true)
            {
                throw new Exception("External authentication error");
            }
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                var externalClaims = result.Principal.Claims.Select(c => $"{c.Type}: {c.Value}");
                _logger.LogDebug("External claims: {@claims}", externalClaims);
            }
            var (user, provider, providerUserId, claims) = await FindUserFromExternalProvider(result);
            if (user == null)
            {
                user = await AutoProvisionUserAsync(provider, providerUserId, claims);
            }


            var additionalLocalClaims = new List<Claim>();
            var localSignInProps = new AuthenticationProperties();
            ProcessLoginCallback(result, additionalLocalClaims, localSignInProps);



            // issue authentication cookie for user
            var isuser = new IdentityServerUser(user.Id)
            {
                DisplayName = user.UserName,

                AuthenticationTime = DateTime.Now,
                IdentityProvider = provider,
                AdditionalClaims = additionalLocalClaims
            };

            await HttpContext.SignInAsync(isuser, localSignInProps);


            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            var callbackUrl = Url.Action("ExternalLoginCallback");
            var returnUrl = result.Properties.Items["returnUrl"] ?? "~/";
            var context = await _interaction.GetAuthorizationContextAsync("/https://localhost:6001/viewclass");
            await _events.RaiseAsync(new UserLoginSuccessEvent(provider, providerUserId, user.Id, "a", true, context?.Client.ClientId));
            if (!_interaction.IsValidReturnUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }

            // var context = await _interaction.GetAuthorizationContextAsync("https://localhost:6001/viewclass");
            await _events.RaiseAsync(new UserLoginSuccessEvent(provider, providerUserId, user.Id, "a", true, context?.Client.ClientId));
            if (!_interaction.IsValidReturnUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }



            if (context == null)
            {
                return Redirect(returnUrl);
            }
            if (context != null)
            {
                if (context.IsNativeClient())
                {
                    // The client is native, so this change in how to
                    // return the response is for better UX for the end user.
                    return this.LoadingPage("Redirect", returnUrl);
                }
            }


            if (result.Principal.Claims.ToList()[2].Value.Contains("@fpt.edu.vn"))
            {
                var newliststudent = await _studentUPRepo.GetAllStudentUPAsync();
                if (_userManager.Users.Any(c => c.Email.ToLower().Trim() == result.Principal.Claims.ToList()[2].Value.ToLower().Trim() == false))
                {
                    UserSignIn newuser = new UserSignIn
                    {

                        UserName = result.Principal.Claims.ToList()[2].Value,
                        Email = result.Principal.Claims.ToList()[2].Value,
                        EmailConfirmed = true
                    };
                    var results = await _userManager.CreateAsync(newuser, "Pass123$");
                    if (newliststudent.Any(c => c.Email == result.Principal.Claims.ToList()[2].Value) == false)
                    {


                        StudentUP student = new StudentUP()
                        {
                            Id = Guid.Parse(_userManager.Users.Where(c => c.Email.ToLower().Trim() == result.Principal.Claims.ToList()[2].Value).Select(c => c.Id).FirstOrDefault()),
                            Email = result.Principal.Claims.ToList()[2].Value.ToString(),
                            Address = "",
                            Ethnic = "",
                            DateOfBirth = DateTime.Now,
                            Description = "",
                            FathersName = "",
                            Gender = true,
                            HomeTown = "",
                            IdentityCardNumber = "",
                            ImageUrl = "",
                            IssuedOn = DateTime.Now,
                            MotherName = "",
                            Password = "",
                            PhoneNumber = "",
                            Status = 1,
                            StudentName = "",
                            StudentCode = result.Principal.Claims.ToList()[2].Value.Substring(result.Principal.Claims.ToList()[2].Value.ToList().FindIndex(c => c == '@') - 7, 7).ToUpper(),
                        };
                        if (student.Email.Contains("ph"))
                        {
                            await _studentRepo.AddAsync(student);
                            await _studentRepo.SaveChangesAsync();
                        }
                    }
                }
                else
                {

                }

                var getlistrole = await _userIdentityRepo.GetRoleUser(Convert.ToString(result.Principal.Claims.ToList()[2].Value));

                if (Regex.IsMatch(result.Principal.Claims.ToList()[2].Value, Partern) == false || getlistrole.ListRoles.Count() != 0)
                {
                    return Redirect($"/adminlogin/{result.Principal.Claims.ToList()[2].Value.Replace(".", "-")}");
                }
                else
                {
                    return Redirect($"/viewclass/{result.Principal.Claims.ToList()[2].Value.Replace(".", "-")}");
                }


            }


            return Redirect(returnUrl);

        }

        private async Task<(UserSignIn user, string provider, string providerUserId, IEnumerable<Claim> claims)> FindUserFromExternalProvider(AuthenticateResult result)
        {
            var externalUser = result.Principal;

            // try to determine the unique id of the external user (issued by the provider)
            // the most common claim type for that are the sub claim and the NameIdentifier
            // depending on the external provider, some other claim type might be used
            var userIdClaim = externalUser.FindFirst(JwtClaimTypes.Subject) ??
                              externalUser.FindFirst(ClaimTypes.NameIdentifier) ??
                              throw new Exception("Unknown userid");

            // remove the user id claim so we don't include it as an extra claim if/when we provision the user
            var claims = externalUser.Claims.ToList();
            claims.Remove(userIdClaim);

            var provider = result.Properties.Items["scheme"];
            var providerUserId = userIdClaim.Value;

            // find external user
            var user = await _userManager.FindByLoginAsync(provider, providerUserId);
            return (user, provider, providerUserId, claims);
        }

        private async Task<UserSignIn> AutoProvisionUserAsync(string provider, string providerUserId, IEnumerable<Claim> claims)
        {
            // create a list of claims that we want to transfer into our store
            var filtered = new List<Claim>();

            // user's display name
            var name = claims.FirstOrDefault(x => x.Type == JwtClaimTypes.Name)?.Value ??
                claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;
            if (name != null)
            {
                filtered.Add(new Claim(JwtClaimTypes.Name, name));
            }
            else
            {
                var first = claims.FirstOrDefault(x => x.Type == JwtClaimTypes.GivenName)?.Value ??
claims.FirstOrDefault(x => x.Type == ClaimTypes.GivenName)?.Value;
                var last = claims.FirstOrDefault(x => x.Type == JwtClaimTypes.FamilyName)?.Value ??
                    claims.FirstOrDefault(x => x.Type == ClaimTypes.Surname)?.Value;
                if (first != null && last != null)
                {
                    filtered.Add(new Claim(JwtClaimTypes.Name, first + " " + last));
                }
                else if (first != null)
                {
                    filtered.Add(new Claim(JwtClaimTypes.Name, first));
                }
                else if (last != null)
                {
                    filtered.Add(new Claim(JwtClaimTypes.Name, last));
                }
            }

            // email
            var email = claims.FirstOrDefault(x => x.Type == JwtClaimTypes.Email)?.Value ??
               claims.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;
            if (email != null)
            {
                filtered.Add(new Claim(JwtClaimTypes.Email, email));
            }

            var user = new UserSignIn
            {
                UserName = Guid.NewGuid().ToString(),
            };
            var identityResult = await _userManager.CreateAsync(user);
            if (!identityResult.Succeeded) throw new Exception(identityResult.Errors.First().Description);

            if (filtered.Any())
            {
                identityResult = await _userManager.AddClaimsAsync(user, filtered);
                if (!identityResult.Succeeded) throw new Exception(identityResult.Errors.First().Description);
            }

            identityResult = await _userManager.AddLoginAsync(user, new UserLoginInfo(provider, providerUserId, provider));
            if (!identityResult.Succeeded) throw new Exception(identityResult.Errors.First().Description);

            return user;
        }



        private void ProcessLoginCallback(AuthenticateResult externalResult, List<Claim> localClaims, AuthenticationProperties localSignInProps)
        {
            if (AccountOptions.AllowRememberLogin)
            {
                localSignInProps = new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTimeOffset.UtcNow.Add(AccountOptions.RememberMeLoginDuration)
                };
            };

            localClaims.AddRange(externalResult.Principal.Claims.ToList());

            // if the external provider issued an id_token, we'll keep it for signout
            var idToken = externalResult.Properties.GetTokenValue("id_token");
            if (idToken != null)
            {
                localSignInProps.StoreTokens(new[] { new AuthenticationToken { Name = "id_token", Value = idToken } });
            }






            //var idToken = externalResult.Properties.GetTokenValue("access_token");
            //if (idToken != null)
            //{
            //    localSignInProps.StoreTokens(new[] { new AuthenticationToken { Name = "access_token", Value = idToken } });
            //}


        }
    }
}
//
