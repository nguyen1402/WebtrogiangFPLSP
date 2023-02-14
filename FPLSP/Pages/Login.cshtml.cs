using FPLSP.Data;
using FPLSP.Data.Securities;
using FPLSP.Repositories.Interfaces.FPLExam;
using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using System.Text.RegularExpressions;

namespace Client.Pages
{

    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<UserSignIn> _userManager;
        private readonly CustomAuthStateProvider _customAuthStateProvider;
        private CustomClaimsForUser _customClaimsForUser;
        private readonly IDataProtector _protector;
        private readonly CryptoServices _cryptoServices;
        private readonly IOnlineExamRoomRepo _onlineExamRoomRepo;
        private readonly SignInManager<UserSignIn> _signInManager;
        private readonly IExaminationRoomDetailRepo _examinationRoomDetailRepo;
        private readonly ISupervisorExamRoomRepocs _supervisorExamRoomRepocs;
        private string Partern = "^[a-z]{3,13}[0-9]{5}@fpt.edu.vn";
        public LoginModel(UserManager<UserSignIn> userManager, ISupervisorExamRoomRepocs supervisorExamRoomRepocs, IExaminationRoomDetailRepo examinationRoomDetailRepo, IOnlineExamRoomRepo onlineExamRoomRepo, CryptoServices cryptoServices, IDataProtectionProvider protector, HashParameterValues hashParameterValues, CustomClaimsForUser customClaimsForUser, SignInManager<UserSignIn> signInManager, CustomAuthStateProvider customAuthStateProvider)
        {
            _userManager = userManager;
            _examinationRoomDetailRepo = examinationRoomDetailRepo;
            _onlineExamRoomRepo = onlineExamRoomRepo;
            _protector = protector.CreateProtector(hashParameterValues.HashValuesForRouter);
            _customClaimsForUser = customClaimsForUser;
            _supervisorExamRoomRepocs = supervisorExamRoomRepocs;
            _customAuthStateProvider = customAuthStateProvider;
            _signInManager = signInManager;
            _cryptoServices = cryptoServices;
        }
        public async Task<IActionResult> OnGetAsync(string returnUrl, string redirect, string getidrole)
        {
            string provider = "Google";
            // Request a redirect to the external login provider.
            var authenticationProperties = new AuthenticationProperties
            {
                RedirectUri = Url.Page("./Login",
                pageHandler: "Callback",
                values: new { returnUrl, redirect, getidrole }),
            };

            return new ChallengeResult(provider, authenticationProperties);
        }
        public async Task<IActionResult> OnGetCallbackAsync(
            string returnUrl, string redirect, string getidrole)
        {
            //lấy claim sau khi authen bằng google authication
            var chosing = getidrole;
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            //
            var claims = new List<Claim>();
            //var localSignInProps = new AuthenticationProperties();
            ////target đến phương thức ProcessLoginCallback để lấy id_token với mục đích để xác thực
            //ProcessLoginCallback(result, claims, localSignInProps);
            //await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            //kiểm tra xem tài khoản vừa đăng nhập đã chọn đúng cơ sở hay chưa
            claims = HttpContext.User.Claims.ToList();
            //
            //_signInManager.SignInWithClaimsAsync()
            UserSignIn userSignIn = new UserSignIn();
            var emailuser = claims[4].Value.ToString();
            var TrainId = Guid.Parse(_protector.Unprotect(returnUrl));
            var checkingindex = _userManager.Users.ToList().FindIndex(x => x.Email == emailuser);
            if (checkingindex != -1)
            {
                userSignIn = _userManager.Users.ToList().Find(x => x.Email == emailuser);
            }
            else
            {
                if (emailuser.Contains("@fpt.edu.vn"))
                {
                    UserSignIn newuser = new UserSignIn
                    {
                        UserName = emailuser,
                        Email = emailuser,
                        EmailConfirmed = true,
                        IdTrainingFacility = TrainId
                    };
                    await _userManager.CreateAsync(newuser, "Pass123$");
                    userSignIn = _userManager.Users.ToList().Find(x => x.Email == emailuser);
                }
            }

            //lấy claim user ra để thêm role vào


            //kiểm tra xem có thuộc mail của fpt hay không ?
            if (emailuser.Contains("@fpt.edu.vn") == false)
            {
                return LocalRedirect("/");
            }

            if (userSignIn.IdTrainingFacility != TrainId)
            {

                HttpContext.Session.SetString("err", "Vui Lòng Chọn Lại Cơ Sở Cho Tài Khoản Của Bạn");
                return Redirect("/");
            }

            //var CanCRUD = await _customClaimsForUser.IsCRUDUser(userSignIn);
            //tạo rac các policy để check quyền xem của account đăng nhập
            //quyền xem cabinproject
            var CanViewCabinProject = await _customClaimsForUser.CanViewCabinProject(userSignIn);
            //quyền xem fplsp
            var CanViewFPLSPProject = await _customClaimsForUser.CanViewFPLSPProject(userSignIn);
            //quyền xem FPLExam
            var CanViewFPLExam = await _customClaimsForUser.CanViewFPLExam(userSignIn);

            //lấy list role mà tài khoản này có trong database
            var userRoles = await _userManager.GetRolesAsync(userSignIn);
            //
            var redirectIdDecrypt = _protector.Unprotect(redirect);

            //kiểm tra các trường hợp role còn lại ở đây

            //ở đây xét đến trang người dùng muốn đăng nhập và target tới
            //target FPLSP
            if (redirectIdDecrypt == "169a0425-7e5a-4057-9748-32f1cf3c1479")
            {


                if (CanViewFPLSPProject == "false")
                {
                    HttpContext.Session.SetString("err", "Bạn Không Có Quyền Để Truy Cập Vào FPLSP Project Vui Lòng Liên Hệ daotaopoly@fpt.edu.vn");
                    return Redirect("/");
                }
                else
                {
                    _customAuthStateProvider.ExternalUsers.Clear();
                    //đây là quyền sinh viên
                    if (getidrole.ToUpper() == "569A0425-7E5A-4057-9748-32F1CF3C1479")
                    {
                        if (userRoles.Any(c => c.ToLower() == "student"))
                        {
                            //kiểm tra xem user này đã có claim quyền là student hay chưa nếu có rồi thì add vào enpoint authorize để vào bên trong componet để xác thực
                            claims.Add(new Claim(ClaimTypes.Role, "Student"));
                            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                            var Princilpal = new ClaimsPrincipal(claimsIdentity);
                            _customAuthStateProvider.ExternalUsers.Add(emailuser, Princilpal);
                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, Princilpal);
                            return LocalRedirect("/viewclass");
                        }
                        else
                        {
                            HttpContext.Session.SetString("err", "Bạn Không Có Quyền Để Truy Cập Vào FPLSP Project Vui Lòng Liên Hệ daotaopoly@fpt.edu.vn");
                            return Redirect("/");
                        }
                    }
                    if (userRoles.Any(c => c == "AdminCore" || c == "AdminCS" || c == "LecturerFPLSP"))
                    {
                        foreach (var role in userRoles)
                        {
                            claims.Add(new Claim(ClaimTypes.Role, role));

                        }

                        //thêm cả claims cho phép redirect tới màn mà người dùng chọn nếu người dùng đã được có claims để phục vụ cho chính sách
                        claims.Add(new Claim("CanViewFPLSPProject", "true"));
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var Princilpal = new ClaimsPrincipal(claimsIdentity);
                        _customAuthStateProvider.ExternalUsers.Add(emailuser, Princilpal);
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, Princilpal);
                        //để đây sau còn xét thêm cả việc nếu là admin core thì direct trực tiếp đến dashboard của tất cả cơ sở
                        //còn admin cơ sở thì đến được cơ sở mà người đó đang đào tạo
                        //nếu là giảng viên thì đến trực tiếp lớp đang dạy
                        HttpContext.Session.Remove("err");
                        //đây là của cán bộ đào tạo
                        if (getidrole.ToUpper() == "369A0425-7E5A-4057-9748-32F1CF3C1479")
                        {
                            if ((userRoles.Any(c => c == "AdminCore" || c == "AdminCS")))
                            {



                                return LocalRedirect($"/admin-dashboard/{_cryptoServices.Encrypt(userRoles.Select(c => c).FirstOrDefault().ToString().Replace("/", "I0H"))}/{_cryptoServices.Encrypt(userSignIn.IdTrainingFacility.ToString().Replace("/", "I0H"))}");


                            }
                            else
                            {
                                HttpContext.Session.SetString("err", "Bạn Không Có Quyền Để Truy Cập Vào FPLSP Project Vui Lòng Liên Hệ daotaopoly@fpt.edu.vn");
                                return Redirect("/");
                            }
                        }
                        if (getidrole.ToUpper() == "469A0425-7E5A-4057-9748-32F1CF3C1479")
                        {
                            if ((userRoles.Any(c => c == "LecturerFPLSP")))
                            {

                                // mã hóa id để truyền sang
                                return LocalRedirect($"/AllDanhSachLopOfLecucu/{_cryptoServices.Encrypt(userSignIn.Id)}");

                            }
                            else
                            {
                                HttpContext.Session.SetString("err", "Bạn Không Có Quyền Để Truy Cập Vào FPLSP Project Vui Lòng Liên Hệ daotaopoly@fpt.edu.vn");
                                return Redirect("/");
                            }
                        }
                    }
                    else
                    {
                        HttpContext.Session.SetString("err", "Bạn Không Có Quyền Để Truy Cập Vào FPLSP Project Vui Lòng Liên Hệ daotaopoly@fpt.edu.vn");
                        return Redirect("/");
                    }

                }
            }
            //Cabin Project


            if (redirectIdDecrypt == "269a0425-7e5a-4057-9748-32f1cf3c1479")
            {
                if (CanViewCabinProject == "false")
                {
                    HttpContext.Session.SetString("err", "Bạn Không Có Quyền Để Truy Cập Vào Cabin Project Vui Lòng Liên Hệ daotaopoly@fpt.edu.vn");
                    return Redirect("/");
                }
                else
                {
                    _customAuthStateProvider.ExternalUsers.Clear();
                    //kieemr tra điề kiện phải thuộc ít nhất 1 trong số quyền này thì mới tạo claims cho để vào
                    if (userRoles.Any(c => c == "Lecturer" || c == "DirectorOfTraining" || c == "Staff" || c == "HeadOfDepartment"))
                    {
                        foreach (var role in userRoles)
                        {
                            claims.Add(new Claim(ClaimTypes.Role, role));

                        }
                        //thêm cả claims cho phép redirect tới màn mà người dùng chọn nếu người dùng đã được có claims để phục vụ cho chính sách
                        claims.Add(new Claim("CanViewCabinProject", "true"));
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var Princilpal = new ClaimsPrincipal(claimsIdentity);
                        _customAuthStateProvider.ExternalUsers.Add(emailuser, Princilpal);
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, Princilpal);
                        HttpContext.Session.Remove("err");
                        if ((userRoles.Any(c => c == "DirectorOfTraining" || c == "HeadOfDepartment")))
                        {
                            return LocalRedirect($"/managecabin/{_cryptoServices.Encrypt(userSignIn.IdTrainingFacility.ToString()).Replace("/", "cabin")}");
                        }
                        if ((userRoles.Any(c => c == "Staff")))
                        {
                            return LocalRedirect($"/BookingRequest/{_cryptoServices.Encrypt(userSignIn.IdTrainingFacility.ToString()).Replace("/", "cabin")}");
                        }
                        if ((userRoles.Any(c => c == "Lecturer")))
                        {
                            return LocalRedirect($"/Cabin/lecturer/{_cryptoServices.Encrypt(userSignIn.IdTrainingFacility.ToString()).Replace("/", "cabin")}");
                        }
                    }
                    else
                    {

                        HttpContext.Session.SetString("err", "Bạn Không Có Quyền Để Truy Cập Vào Cabin Project Vui Lòng Liên Hệ daotaopoly@fpt.edu.vn");
                        return Redirect("/");
                    }
                }
            }
            //FPL Exam


            if (redirectIdDecrypt == "369a0425-7e5a-4057-9748-32f1cf3c1479")
            {

                _customAuthStateProvider.ExternalUsers.Clear();
                //kieemr tra điề kiện phải thuộc ít nhất 1 trong số quyền này thì mới tạo claims cho để vào
                if (userRoles.Any(c => c == "GV FPLExam" || c == "TBM FPLExam" || c == "SV FPLExam"))
                {
                    foreach (var role in userRoles)
                    {
                        if (role == "GV FPLExam" || role == "TBM FPLExam" || role == "SV FPLExam")
                        {
                            claims.Add(new Claim(ClaimTypes.Role, role));
                        }


                    }

                    //thêm cả claims cho phép redirect tới màn mà người dùng chọn nếu người dùng đã được có claims để phục vụ cho chính sách
                    claims.Add(new Claim("CanViewFPLExam", "true"));
                    claims.Add(new Claim("IdUserJoin", userSignIn.Id));
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var Princilpal = new ClaimsPrincipal(claimsIdentity);
                    _customAuthStateProvider.ExternalUsers.Add(emailuser, Princilpal);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, Princilpal);
                    HttpContext.Session.Remove("err");
                    //đây là của cán bộ đào tạo
                    if (getidrole.ToUpper() == "369A0425-7E5A-4057-9748-32F1CF3C1479")
                    {
                        if ((userRoles.Any(c => c == "TBM FPLExam")))
                        {


                            //điều hướng tới màn tổng quan môn học 
                            //return LocalRedirect($"/overviewsubject");
                            return LocalRedirect($"/overviewsubject/{_cryptoServices.Encrypt("TBM FPLExam")}/{_cryptoServices.Encrypt(userSignIn.Id)}");
                        }
                        else
                        {
                            HttpContext.Session.SetString("err", "Bạn Không Có Quyền Để Truy Cập Vào FPLExam Vui Lòng Liên Hệ daotaopoly@fpt.edu.vn");
                            return Redirect("/");
                        }
                    }
                    if (getidrole.ToUpper() == "469A0425-7E5A-4057-9748-32F1CF3C1479")
                    {
                        if ((userRoles.Any(c => c == "GV FPLExam")))
                        {


                            //điều hướng tới màn tổng quan môn học 
                            //return LocalRedirect($"/overviewsubject");
                            return LocalRedirect($"/overviewsubject/{_cryptoServices.Encrypt("GV FPLExam")}/{_cryptoServices.Encrypt(userSignIn.Id)}");
                        }
                        else
                        {
                            HttpContext.Session.SetString("err", "Bạn Không Có Quyền Để Truy Cập Vào FPLExam Vui Lòng Liên Hệ daotaopoly@fpt.edu.vn");
                            return Redirect("/");
                        }
                    }
                    if (getidrole.ToUpper() == "569A0425-7E5A-4057-9748-32F1CF3C1479")
                    {
                        if ((userRoles.Any(c => c == "SV FPLExam")))
                        {
                            var checkerlist = await _onlineExamRoomRepo.GetAllOnlineExamRoom();
                            //trong trường hợp đã checkin rồi và có thể là đã thi
                            if (checkerlist.Any(c => c.IdUser == userSignIn.Id))
                            {

                                var GetLastestSecrete = await _onlineExamRoomRepo.GetScretKeyLastestForUser(userSignIn.Id);
                                //var getSecte =
                                var getTurnUser = await _onlineExamRoomRepo.getTurnById(GetLastestSecrete.SecretKey, userSignIn.Id);
                                //láy được ra số lần làm rồi thì check xem đây là lần bao nhiêu nếu bằng 0 thì vào phòng chờ luôn còn nếu bằng 1 hoặc lớn hơn thì phải đợi accept vào phòng
                                //tiếp tục lấy ra thời gian bắt đầu và thời gian kết thúc của thằng làm đề thì
                                var ListUserInRoomBySecret = await _onlineExamRoomRepo.GetOnlineExamRoomById(GetLastestSecrete.SecretKey);
                                //lấy ra thằng user
                                var UserInRoomBySecretById = ListUserInRoomBySecret.Where(c => c.IdUser == userSignIn.Id).FirstOrDefault();
                                // tính toán thời gian đăng nhập xem có nằm trong khoảng thi nào không
                                //check sang bên chi tiết
                                var detailexamchecker = await _examinationRoomDetailRepo.GetExaminamRoomDetailBySecret(UserInRoomBySecretById.SecretKey);
                                if (DateTime.Now < detailexamchecker.EndTime)
                                {

                                    if (DateTime.Now >= UserInRoomBySecretById.EndTime && DateTime.Now < detailexamchecker.EndTime)
                                    {
                                        return LocalRedirect($"/onlineroomhandler/{UserInRoomBySecretById.SecretKey}/{userSignIn.Id}");
                                    }
                                    if (UserInRoomBySecretById.Status == 0)
                                    {
                                        if (UserInRoomBySecretById.StartTime <= DateTime.Now && UserInRoomBySecretById.EndTime >= DateTime.Now)
                                        {
                                            // trường hợp này điều hướng đến thẳng phòng thi vì đã checkin rồi
                                            //nhưng chưa đến giờ thi 


                                            return LocalRedirect($"/onlineroomhandler/{UserInRoomBySecretById.SecretKey}/{userSignIn.Id}");
                                        }
                                    }

                                    if (UserInRoomBySecretById.Status == 4)
                                    {
                                        //kiểm tra trong qyas trình thi thì sinh viên đó lỡ thoát
                                        //số lần vào phòng sẽ tự động bị tăng lên và phải cho giảng viên  accept vào phòng thì mới được

                                        if (UserInRoomBySecretById.StartTime <= DateTime.Now && UserInRoomBySecretById.EndTime >= DateTime.Now)
                                        {
                                            //quá trình trong khi thi
                                            //điều hướng đến waiting room
                                            return LocalRedirect($"/redirecttoonlineroom/{userSignIn.Id}/{UserInRoomBySecretById.SecretKey}/waittingforaccpet");
                                        }
                                        //xét tiếp trường hợp chưa thi môn nào thì điều hướng đến khu vực checkin
                                    }
                                }
                                //ở đây sẽ check xem nếu có ca thi nào đang thi thì lập tức điều hướng tới màn thi
                                //còn nếu không thì di chuyển tới màn nhập mã checkin
                                return LocalRedirect($"/loadingpage/{userSignIn.Id}");
                            }
                            //đây là trường hợp lần đầu tiên vào
                            else
                            {
                                return LocalRedirect($"/loadingpage/{userSignIn.Id}");
                            }

                        }
                        else
                        {
                            HttpContext.Session.SetString("err", "Bạn Không Có Quyền Để Truy Cập Vào FPLExam Vui Lòng Liên Hệ daotaopoly@fpt.edu.vn");
                            return Redirect("/");
                        }
                    }


                }
                else
                {
                    //tạo mới quyền mặc định là quyền SV FPLExam
                    //kiểm tra tài khoản thuộc của sinh viên
                    if (Regex.IsMatch(userSignIn.Email, Partern))
                    {
                        //đây là tạo xong quyền
                        await _userManager.AddToRoleAsync(userSignIn, "SV FPLEXAM");
                        claims.Add(new Claim(ClaimTypes.Role, "SV FPLExam"));
                        claims.Add(new Claim("CanViewFPLExam", "true"));
                        claims.Add(new Claim("IdUserJoin", userSignIn.Id));
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var Princilpal = new ClaimsPrincipal(claimsIdentity);
                        _customAuthStateProvider.ExternalUsers.Add(emailuser, Princilpal);
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, Princilpal);
                        HttpContext.Session.Remove("err");


                        //cái này di chuyển thằng đến màn checkin
                        return LocalRedirect($"/loadingpage/{userSignIn.Id}");




                    }

                }

            }
            return LocalRedirect("/");
        }
        //private void ProcessLoginCallback(AuthenticateResult externalResult, List<Claim> localClaims, AuthenticationProperties localSignInProps)
        //{
        //    if (AccountOptions.AllowRememberLogin)
        //    {
        //        localSignInProps = new AuthenticationProperties
        //        {
        //            IsPersistent = true,
        //            ExpiresUtc = DateTimeOffset.UtcNow.Add(AccountOptions.RememberMeLoginDuration)
        //        };
        //    };
        //    localClaims.AddRange(externalResult.Principal.Claims.ToList());
        //    // if the external provider issued an id_token, we'll keep it for signout
        //    var idToken = externalResult.Properties.GetTokenValue("id_token");
        //    if (idToken != null)
        //    {
        //        localSignInProps.StoreTokens(new[] { new AuthenticationToken { Name = "id_token", Value = idToken } });
        //    }
        //}

    }
}


