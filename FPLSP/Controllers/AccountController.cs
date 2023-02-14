// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using FPLSP.Controllers;
using FPLSP.Data;
using FPLSP.Data.FPLExam;
using FPLSP.Data.Securities;
using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels;
using IdentityModel;
using IdentityServer4;
using IdentityServer4.Events;
using IdentityServer4.Extensions;
using IdentityServer4.Models;
using IdentityServer4.Services;
using IdentityServer4.Stores;
using IdentityServerHost.Quickstart.UI;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text.RegularExpressions;

namespace FPLSP.Areas.Identity.Pages.Controllers
{
    /// <summary>
    /// This sample controller implements a typical login/logout/provision workflow for local and external accounts.
    /// The login service encapsulates the interactions with the user data store. This data store is in-memory only and cannot be used for production!
    /// The interaction service provides a way for the UI to communicate with identityserver for validation and context retrieval
    /// </summary>
    [SecurityHeaders]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private string Partern = "^[a-z]{3,13}[0-9]{5}@fpt.edu.vn";
        //đây là 2 class cửa asp identity
        private readonly IUserIdentityRepo _userIdentityRepo;
        private readonly ITrainingFacilitiesCPRepo _trainingFacilitiesCPRepo;
        private readonly IStudentUPRepo _studentUPRepo;
        private readonly IRepository<StudentUP> _studentRepo;
        private readonly SignInManager<UserSignIn> _signInManager;
        private readonly UserManager<UserSignIn> _userManager;
        private readonly ILogger<ExternalController> _logger;
        private readonly IIdentityServerInteractionService _interaction;
        private readonly IClientStore _clientStore;
        private readonly IAuthenticationSchemeProvider _schemeProvider;
        private readonly IEventService _events;
        private readonly IStudentClassUPRepo _studentClassUPRepo;
        private readonly ILecturersCPRepo _lecturersCPRepo;
        private readonly ITaskRepositories<ClassUPViewModel> _classRepositories;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IDataProtector _protector;
        string trainingFacilityId;
        private List<ChoosingRedirect> _lstRedirect = new List<ChoosingRedirect>();
        private List<TrainingFacilitiesCP> _lstTraning = new List<TrainingFacilitiesCP>();
        private List<ListChooseRole> _lstMainRole = new List<ListChooseRole>();
        public AccountController(
            IIdentityServerInteractionService interaction,
            IClientStore clientStore,
            IAuthenticationSchemeProvider schemeProvider,
            IEventService events,
            SignInManager<UserSignIn> signInManager,
            UserManager<UserSignIn> userManager,
             ITrainingFacilitiesCPRepo trainingFacilitiesCPRepo,
             IUserIdentityRepo userIdentityRepo,
             ILogger<ExternalController> logger,
            IHttpContextAccessor httpContextAccessor, IDataProtectionProvider protector, HashParameterValues hashParameterValues, ITaskRepositories<ClassUPViewModel> classRepositories, IStudentClassUPRepo studentClassUPRepo, IRepository<StudentUP> studentRepo, IStudentUPRepo studentUPRepo, ILecturersCPRepo lecturersCPRepo)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _studentRepo = studentRepo;
            _interaction = interaction;
            _logger = logger;
            _clientStore = clientStore;
            _classRepositories = classRepositories;
            _lecturersCPRepo = lecturersCPRepo;
            _schemeProvider = schemeProvider;
            _events = events;
            _studentClassUPRepo = studentClassUPRepo;
            _userIdentityRepo = userIdentityRepo;
            _trainingFacilitiesCPRepo = trainingFacilitiesCPRepo;
            _studentUPRepo = studentUPRepo;
            _httpContextAccessor = httpContextAccessor;
            _protector = protector.CreateProtector(hashParameterValues.HashValuesForRouter);
        }

        /// <summary>
        //    ///nhìn đoạn này thấy route chưa mình chỉ cần 
        //    làm lươn cắt kí tự đỡ phải chỉnh sửa tham số truyền vào vì anh để mặc định là /adminlogin
        //    gui là 32 kí tự đúng không nghỉ
        //    giờ bố dùng substring cắt từ(11,47)
        ///hết
        /// </summary>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl)
        {


            _lstTraning = await _trainingFacilitiesCPRepo.GetTrainingFacilitiesAsync();
            // build a model so we know what to show on the login page
            var vm = await BuildLoginViewModelAsync(returnUrl);

            if (vm.IsExternalLoginOnly)
            {
                // we only have one option for logging in and it's an external provider
                return RedirectToAction("Challenge", "External", new { provider = vm.ExternalLoginScheme, returnUrl });
            }

            ViewData["ListModel"] = _lstTraning;
            ViewData["err"] = HttpContext.Session.GetString("err");

            _lstRedirect.Add(new ChoosingRedirect()
            {
                Id = Guid.Parse("269A0425-7E5A-4057-9748-32F1CF3C1479"),
                RedirectToView = "Book Cabin FPL HN"
            });
            _lstRedirect.Add(new ChoosingRedirect()
            {
                Id = Guid.Parse("169A0425-7E5A-4057-9748-32F1CF3C1479"),
                RedirectToView = "FPL Support"
            });
            _lstRedirect.Add(new ChoosingRedirect()
            {
                Id = Guid.Parse("369A0425-7E5A-4057-9748-32F1CF3C1479"),
                RedirectToView = "FPL Exam"
            });
            //
            _lstMainRole.Add(new ListChooseRole()
            {
                Id = Guid.Parse("369A0425-7E5A-4057-9748-32F1CF3C1479"),
                NameToMain = "Cán Bộ Đào Tạo"

            });
            _lstMainRole.Add(new ListChooseRole()
            {
                Id = Guid.Parse("469A0425-7E5A-4057-9748-32F1CF3C1479"),
                NameToMain = "Giảng Viên"

            });
            _lstMainRole.Add(new ListChooseRole()
            {
                Id = Guid.Parse("569A0425-7E5A-4057-9748-32F1CF3C1479"),
                NameToMain = "Sinh Viên"

            });
            ViewData["lstMainRole"] = _lstMainRole;
            ViewData["lstRedirect"] = _lstRedirect;
            return View(vm);

        }
        /// <summary>
        /// phương thức này dùng để check cở sở khi người dùng bấm vào login
        /// </summary>
        /// <param name="getIdSlects"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CheckingLogin(string getIdSlects, string getIdRedirect, string getIdRole)
        {
            var parseID = Guid.Parse(getIdSlects);
            _lstTraning = await _trainingFacilitiesCPRepo.GetTrainingFacilitiesAsync();
            var encrytedRouter = _protector.Protect(getIdSlects);
            var encrytedRouterRedirect = _protector.Protect(getIdRedirect);

            if (parseID == Guid.Empty)
            {
                return Redirect("/");
            }
            else
            {
                return Redirect($"/loginview?returnUrl={encrytedRouter}&redirect={encrytedRouterRedirect}&getidrole={getIdRole}");
            }
            return View();
        }

        /// <summary>
        /// Handle postback from username/password login
        /// </summary>
        [HttpPost]

        [AllowAnonymous]
        // [ValidateAntiForgeryToken]

        public async Task<IActionResult> Login(LoginInputModel model, string button)
        {

            string Partern = "^[a-z]{3,13}[0-9]{5}";

            // check if we are in the context of an authorization request
            var context = await _interaction.GetAuthorizationContextAsync(model.ReturnUrl);

            //if(_userManager.Users.ToList().Any(c=>c.Email==model.Username && c.))

            // the user clicked the "cancel" button
            if (button != "login")
            {
                if (context != null)
                {
                    // if the user cancels, send a result back into IdentityServer as if they 
                    // denied the consent (even if this client does not require consent).
                    // this will send back an access denied OIDC error response to the client.
                    await _interaction.DenyAuthorizationAsync(context, AuthorizationError.AccessDenied);

                    // we can trust model.ReturnUrl since GetAuthorizationContextAsync returned non-null
                    if (context.IsNativeClient())
                    {
                        // The client is native, so this change in how to
                        // return the response is for better UX for the end user.
                        return this.LoadingPage("Redirect", model.ReturnUrl);
                    }

                    return Redirect(model.ReturnUrl);
                }
                else
                {
                    // since we don't have a valid context, then we just go back to the home page
                    return Redirect("~/");
                }
            }

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Username);
                if (user != null)
                {


                    // validate username/password against in-memory store
                    var checker = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberLogin = true, true);
                    if (checker != null)
                    {
                        if (checker == Microsoft.AspNetCore.Identity.SignInResult.Success)
                        {

                            var isuser = new IdentityServerUser(user.Id)
                            {
                                DisplayName = user.UserName,

                            };
                            var localSignInProps = new AuthenticationProperties();
                            await HttpContext.SignInAsync(isuser, localSignInProps);

                            await _events.RaiseAsync(new UserLoginSuccessEvent(user.UserName, user.Id, user.Id, clientId: context?.Client.ClientId));
                            if (model.Username.Contains("@fpt.edu.vn"))
                            {
                                var newliststudent = await _studentUPRepo.GetAllStudentUPAsync();
                                if (_userManager.Users.Any(c => c.Email.ToLower().Trim() == model.Username.ToLower().Trim() == false))
                                {

                                    UserSignIn newuser = new UserSignIn
                                    {
                                        UserName = model.Username,
                                        Email = model.Username,
                                        EmailConfirmed = true,
                                    };
                                    var results = await _userManager.CreateAsync(newuser, "Pass123$");
                                    if (newliststudent.Any(c => c.Email == model.Username) == false)
                                    {

                                        //thêm vào bảng sinh viên hoặc giảng viên
                                        StudentUP student = new StudentUP()
                                        {
                                            Id = Guid.Parse(_userManager.Users.Where(c => c.Email.ToLower().Trim() == model.Username.ToLower()).Select(c => c.Id).FirstOrDefault()),
                                            Email = model.Username,
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
                                            StudentCode = model.Username.Substring(model.Username.ToList().FindIndex(c => c == '@') - 7, 7).ToUpper(),
                                        };
                                        if (Regex.IsMatch(student.Email, Partern))
                                        {
                                            await _studentRepo.AddAsync(student);
                                            await _studentRepo.SaveChangesAsync();
                                        }
                                    }
                                }
                                else
                                {
                                    var tFac = await _trainingFacilitiesCPRepo.GetTrainingFacilityListById(Guid.Parse(trainingFacilityId));
                                    // check user thuộc đúng cơ sở chọn hay không
                                    // check giảng viên
                                    var listLec = await _lecturersCPRepo.GetAllLecturerAsync();
                                    if (listLec.Any(c => c.Email == model.Username))
                                    {
                                        var lec = listLec.FirstOrDefault(c => c.Email == model.Username);
                                        if (lec.TrainingFacilitiesId != Guid.Parse(trainingFacilityId))
                                        {
                                            Console.WriteLine("Giảng viên không thuộc cơ sở", tFac.TrainingInstitutionName);
                                            return Redirect($"/Account/Login?ReturnUrl=/adminlogin/{trainingFacilityId}");
                                        }
                                    }
                                    // check sinh viên từ lớp -> giảng viên -> cơ sở
                                    var listStu = _studentRepo.AsQueryable().ToList();
                                    if (listStu.Any(c => c.Email == model.Username))
                                    {
                                        var stu = listStu.FirstOrDefault(c => c.Email == model.Username);
                                        var listStuClass = await _studentClassUPRepo.GetAllStudentUPAsync();

                                        // nếu tồn tại bản ghi của sinh viên trong lớp -> check lớp có thuộc đúng cơ sở đã chọn không
                                        if (listStuClass.Any(c => c.StudentId == stu.Id))
                                        {
                                            var listClass = await _classRepositories.GetAllClass();
                                            listStuClass = listStuClass.Where(c => c.StudentId == stu.Id).ToList();

                                            List<Guid> listTFacId = new List<Guid>();
                                            foreach (var item in listStuClass)
                                            {
                                                listTFacId.AddRange(listClass.Where(c => c.Id == item.ClassId).Select(c => Guid.Parse(listLec.FirstOrDefault(l => l.Id == c.HomeroomLecturerId).TrainingFacilitiesId.ToString())).ToList());
                                            }

                                            if (!listTFacId.Any(c => c.ToString() == trainingFacilityId))
                                            {
                                                Console.WriteLine("Sinh viên không thuộc cơ sở", tFac.TrainingInstitutionName);
                                                return Redirect($"/Account/Login?ReturnUrl=/adminlogin/{trainingFacilityId}");
                                            }
                                        }

                                    }

                                }

                                var getlistrole = await _userIdentityRepo.GetRoleUser(Convert.ToString(model.Username));

                                //đây là những user có quyền sẽ được navigate to màn của core
                                if (Regex.IsMatch(model.Username, Partern) == false || getlistrole.ListRoles.Count() != 0)
                                {
                                    return Redirect($"/adminlogin/{model.Username.Replace(".", "-")}");
                                }
                                else
                                {
                                    return Redirect($"/viewclass/{model.Username.Replace(".", "-")}");
                                }
                                // only set explicit expiration here if user chooses "remember me". 
                                // otherwise we rely upon expiration configured in cookie middleware.
                                AuthenticationProperties props = null;
                                if (AccountOptions.AllowRememberLogin && model.RememberLogin)
                                {
                                    props = new AuthenticationProperties
                                    {
                                        IsPersistent = true,
                                        ExpiresUtc = DateTimeOffset.UtcNow.Add(AccountOptions.RememberMeLoginDuration)
                                    };
                                };

                                // issue authentication cookie with subject ID and username
                                var result = await HttpContext.AuthenticateAsync(IdentityConstants.ExternalScheme);
                                if (result?.Succeeded != true)
                                {
                                    throw new Exception("External authentication error");
                                }
                                var info = await _signInManager.GetExternalLoginInfoAsync();
                                if (_logger.IsEnabled(LogLevel.Debug))
                                {
                                    var externalClaims = result.Principal.Claims.Select(c => $"{c.Type}: {c.Value}");
                                    _logger.LogDebug("External claims: {@claims}", externalClaims);
                                }

                                // lookup our user and external provider info

                                await HttpContext.SignInAsync(isuser, localSignInProps);

                                if (context != null)
                                {
                                    if (context.IsNativeClient())
                                    {
                                        // The client is native, so this change in how to
                                        // return the response is for better UX for the end user.
                                        return this.LoadingPage("Redirect", model.ReturnUrl);
                                    }

                                    // we can trust model.ReturnUrl since GetAuthorizationContextAsync returned non-null
                                    return Redirect(model.ReturnUrl);
                                }




                                // request for a local page
                                if (Url.IsLocalUrl(model.ReturnUrl))
                                {
                                    return Redirect(model.ReturnUrl);
                                }
                                else if (string.IsNullOrEmpty(model.ReturnUrl))
                                {
                                    return Redirect("~/");
                                }
                                else
                                {
                                    // user might have clicked on a malicious link - should be logged
                                    throw new Exception("invalid return URL");
                                }
                            }

                            await _events.RaiseAsync(new UserLoginFailureEvent(model.Username, "invalid credentials", clientId: context?.Client.ClientId));
                            ModelState.AddModelError(string.Empty, AccountOptions.InvalidCredentialsErrorMessage);
                        }
                    }



                    // something went wrong, show form with error
                }


            }
            var vm = await BuildLoginViewModelAsync(model);
            return View(vm);
        }
        private UserSignIn AutoProvisionUser(string provider, string providerUserId, IEnumerable<Claim> claims)
        {
            var user = new UserSignIn()
            {
                Id = providerUserId
            };
            return user;
        }

        // if the external login is OIDC-based, there are certain things we need to preserve to make logout work
        // this will be different for WS-Fed, SAML2p or other protocols
        private void ProcessLoginCallback(AuthenticateResult externalResult, List<Claim> localClaims, AuthenticationProperties localSignInProps)
        {
            // if the external system sent a session id claim, copy it over
            // so we can use it for single sign-out
            var sid = externalResult.Principal.Claims.FirstOrDefault(x => x.Type == JwtClaimTypes.SessionId);
            if (sid != null)
            {
                localClaims.Add(new Claim(JwtClaimTypes.SessionId, sid.Value));
            }

            // if the external provider issued an id_token, we'll keep it for signout
            var idToken = externalResult.Properties.GetTokenValue("id_token");
            if (idToken != null)
            {
                localSignInProps.StoreTokens(new[] { new AuthenticationToken { Name = "id_token", Value = idToken } });
            }
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

            var user = _userManager.Users.ToList().Find(c => c.Email == result.Principal.Claims.ToList()[4].Value.ToString());

            return (user, provider, providerUserId, claims);
        }
        /// <summary>
        /// Show logout page
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Logout(string logoutId)
        {
            // build a model so the logout page knows what to display
            var vm = await BuildLogoutViewModelAsync(logoutId);

            if (vm.ShowLogoutPrompt == false)
            {
                // if the request for logout was properly authenticated from IdentityServer, then
                // we don't need to show the prompt and can just log the user out directly.
                return await Logout(vm);
            }

            return View(vm);
        }

        /// <summary>
        /// Handle logout page postback
        /// </summary>
        [HttpPost]

        public async Task<IActionResult> Logout(LogoutInputModel model)
        {


            // build a model so the logged out page knows what to display
            var vm = await BuildLoggedOutViewModelAsync(model.LogoutId);

            if (User?.Identity.IsAuthenticated == true)
            {
                // delete local authentication cookie
                await HttpContext.SignOutAsync();

                // raise the logout event
                await _events.RaiseAsync(new UserLogoutSuccessEvent(User.GetSubjectId(), User.GetDisplayName()));
            }

            // check if we need to trigger sign-out at an upstream identity provider
            if (vm.TriggerExternalSignout)
            {
                // build a return URL so the upstream provider will redirect back
                // to us after the user has logged out. this allows us to then
                // complete our single sign-out processing.
                string url = Url.Action("Logout", new { logoutId = vm.LogoutId });

                // this triggers a redirect to the external provider for sign-out
                return SignOut(new AuthenticationProperties { RedirectUri = url }, vm.ExternalAuthenticationScheme);
            }

            return View("LoggedOut", vm);
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }


        /*****************************************/
        /* helper APIs for the AccountController */
        /*****************************************/

        private async Task<LoginViewModel> BuildLoginViewModelAsync(string returnUrl)
        {


            var context = await _interaction.GetAuthorizationContextAsync(returnUrl);
            if (context?.IdP != null && await _schemeProvider.GetSchemeAsync(context.IdP) != null)
            {
                var local = context.IdP == IdentityConstants.ExternalScheme;

                // this is meant to short circuit the UI and only trigger the one external IdP
                var vm = new LoginViewModel
                {
                    EnableLocalLogin = local,
                    ReturnUrl = returnUrl,
                    Username = context?.LoginHint,
                };

                if (!local)
                {
                    //  vm.ExternalProviders = new[] { new ExternalProvider { AuthenticationScheme = context.IdP } };
                }

                return vm;
            }

            var schemes = await _schemeProvider.GetAllSchemesAsync();

            var providers = schemes
                .Where(x => x.DisplayName != null)
                .Select(x => new ExternalProvider
                {
                    DisplayName = x.DisplayName ?? x.Name,
                    AuthenticationScheme = x.Name
                }).ToList();

            var allowLocal = true;
            if (context?.Client.ClientId != null)
            {
                var client = await _clientStore.FindEnabledClientByIdAsync(context.Client.ClientId);
                if (client != null)
                {
                    allowLocal = client.EnableLocalLogin;

                    if (client.IdentityProviderRestrictions != null && client.IdentityProviderRestrictions.Any())
                    {
                        providers = providers.Where(provider => client.IdentityProviderRestrictions.Contains(provider.AuthenticationScheme)).ToList();
                    }
                }
            }

            return new LoginViewModel
            {
                // allowLocal && AccountOptions.AllowLocalLogin
                AllowRememberLogin = AccountOptions.AllowRememberLogin,
                EnableLocalLogin = true,
                ReturnUrl = returnUrl,
                Username = context?.LoginHint,
                ExternalProviders = providers.ToArray()
            };
        }

        private async Task<LoginViewModel> BuildLoginViewModelAsync(LoginInputModel model)
        {
            var vm = await BuildLoginViewModelAsync(model.ReturnUrl);
            vm.Username = model.Username;
            vm.RememberLogin = model.RememberLogin;
            return vm;
        }

        private async Task<LogoutViewModel> BuildLogoutViewModelAsync(string logoutId)
        {
            var vm = new LogoutViewModel { LogoutId = logoutId, ShowLogoutPrompt = AccountOptions.ShowLogoutPrompt };

            if (User?.Identity.IsAuthenticated != true)
            {
                // if the user is not authenticated, then just show logged out page
                vm.ShowLogoutPrompt = false;
                return vm;
            }

            var context = await _interaction.GetLogoutContextAsync(logoutId);
            if (context?.ShowSignoutPrompt == false)
            {
                // it's safe to automatically sign-out
                vm.ShowLogoutPrompt = false;
                return vm;
            }

            // show the logout prompt. this prevents attacks where the user
            // is automatically signed out by another malicious web page.
            return vm;
        }

        private async Task<LoggedOutViewModel> BuildLoggedOutViewModelAsync(string logoutId)
        {
            // get context information (client name, post logout redirect URI and iframe for federated signout)
            var logout = await _interaction.GetLogoutContextAsync(logoutId);

            var vm = new LoggedOutViewModel
            {
                AutomaticRedirectAfterSignOut = AccountOptions.AutomaticRedirectAfterSignOut,
                PostLogoutRedirectUri = logout?.PostLogoutRedirectUri,
                ClientName = string.IsNullOrEmpty(logout?.ClientName) ? logout?.ClientId : logout?.ClientName,
                SignOutIframeUrl = logout?.SignOutIFrameUrl,
                LogoutId = logoutId
            };

            if (User?.Identity.IsAuthenticated == true)
            {
                var idp = User.FindFirst(JwtClaimTypes.IdentityProvider)?.Value;
                if (idp != null && idp != IdentityConstants.ExternalScheme)
                {
                    var providerSupportsSignout = await HttpContext.GetSchemeSupportsSignOutAsync(idp);
                    if (providerSupportsSignout)
                    {
                        if (vm.LogoutId == null)
                        {
                            // if there's no current logout context, we need to create one
                            // this captures necessary info from the current logged in user
                            // before we signout and redirect away to the external IdP for signout
                            vm.LogoutId = await _interaction.CreateLogoutContextAsync();
                        }

                        vm.ExternalAuthenticationScheme = idp;
                    }
                }
            }

            return vm;
        }
    }
}
