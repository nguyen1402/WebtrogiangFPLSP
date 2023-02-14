using AutoMapper;
using DocumentFormat.OpenXml.Spreadsheet;
using ExcelDataReader;
using FPLSP.Data;
using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.StudentClassUPDtos;
using FPLSP.Server.Domain.Dtos.StudentUPDtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.StudentClassUPVm;
using FPLSP.Server.Infrastructure.ViewModels.StudentsUPVm;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using System.Data;
using System.Security.Claims;
using System.Text.RegularExpressions;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace FPLSP.Repositories.Services
{
    public class StudentClassUPRepo : IStudentClassUPRepo
    {
        private readonly IUserIdentityRepo identityRepo;
        private readonly HttpClient _client;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<UserSignIn> _userManager;
        private readonly IMapper _mapper;
        public IUserIdentityRepo _UserIdentityRepo { get; set; }


        private List<ExcelErrors> _listexcelErrors = new List<ExcelErrors>();
        public List<StudentUpDto> _lstStudents = new List<StudentUpDto>();
        public List<UserInListRoles> _lstuserInListRoles = new List<UserInListRoles>();

        private string Partern = "^[a-z]{3,13}[0-9]{5}@fpt.edu.vn";
        UserRoleSearch userRoleSearch = new UserRoleSearch();
        string fpl = "CanViewFPLSPProject";
        //public StudentClassUPRepo(IUserIdentityRepo identityRepo, HttpClient client, IHttpContextAccessor httpContextAccessor, IHostingEnvironment hostingEnvironment, UserManager<UserSignIn> userManager, IMapper mapper)
        //{
        //    this.identityRepo = identityRepo;
        //    _client = client;
        //    _httpContextAccessor = httpContextAccessor;
        //    _hostingEnvironment = hostingEnvironment;
        //    _userManager = userManager;
        //    _mapper = mapper;
        //GetTask();

        //}


        public StudentClassUPRepo(IUserIdentityRepo identityRepo, HttpClient client, IHttpContextAccessor httpContextAccessor, IHostingEnvironment hostingEnvironment, UserManager<UserSignIn> userManager, IMapper mapper, IUserIdentityRepo userIdentityRepo)
        {
            this.identityRepo = identityRepo;
            _client = client;
            _httpContextAccessor = httpContextAccessor;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
            _mapper = mapper;
            _UserIdentityRepo = userIdentityRepo;
            GetTask();
        }

        private List<Claim> _lstRedirect = new List<Claim>();
        public async Task GetTask()
        {
            var lstUser = await identityRepo.GetAllUser(userRoleSearch);
            _lstuserInListRoles = lstUser.Items;
            _lstRedirect.Add(new Claim("CanViewFPLSPProject", "true"));
        }
        public async Task<int> CreateStudentClassUP(StudentClassUPCreateVm createVm)
        {
            var url = Path.Combine($"/api/StudentClassUPs/Create");
            var result = await _client.PostAsJsonAsync(url, createVm);
            if (result != null)
            {
                return 1;
            }
            return 0;
        }

        public async Task<int> CreateStudentInClassByJoinCode(Guid idClass, Guid idStudent, string joinCode)
        {
            StudentClassUPCreateVm createVm = new StudentClassUPCreateVm
            {
                ClassId = idClass,
                JoinCodeAsign = joinCode,
                Status = 0,
                StatusOfStudent = 0,
                StudentId = idStudent
            };
            var url = Path.Combine($"/api/StudentClassUPs/Create");
            var result = await _client.PostAsJsonAsync(url, createVm);
            if (result != null)
            {
                return 1;
            }
            return 0;
        }

        public async Task<int> DeleteStudentUP(string jocode, Guid idStudent)
        {
            var result = await _client.DeleteAsync($"/api/StudentClassUps/{jocode}/{idStudent}");
            if (result != null)
            {
                return 1;
            }
            return 0;
        }
        public async Task<List<ExcelErrors>> GetListErr()
        {
            return _listexcelErrors;
        }

        public async Task<List<StudentUpDto>> LoadingBigData(IBrowserFile file)
        {
            //if (file == null)
            //{
            //    return null;
            //}
            //string fileName = $"{_hostingEnvironment.WebRootPath}\\files\\{file.Name}";

            //using (FileStream fileStream = System.IO.File.Create(fileName))
            //{
            //    Stream stream = file.OpenReadStream();

            //    await stream.CopyToAsync(fileStream);
            //    fileStream.Flush();
            //}
            //var lstST = await this.GetListST(file.Name);



            //return lstST;
            return null;
        }

        public async Task<List<StudentClassUP>> GetAllStudentUPAsync()
        {
            var url = Path.Combine("/api/StudentClassUps/all");

            var result = await _client.GetFromJsonAsync<List<StudentClassUP>>(url);
            return result;
        }



        public async Task<StudentClassUPDtos> GetStudentUPById(Guid id)
        {
            var url = Path.Combine("api/StudentClassUps", id.ToString());

            var result = await _client.GetFromJsonAsync<StudentClassUPDtos>(url);

            return result;
        }

        public async Task<PageList<StudentClassUPDtos>> GetStudentUPList(StudentUPListSearchVm student)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = student.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(student.NameStudent))
            {
                queryStringParam.Add("NameStudent", student.NameStudent);
            }
            if (!string.IsNullOrEmpty(student.Status))
            {
                queryStringParam.Add("Status", student.Status);
            }
            string url = QueryHelpers.AddQueryString("/api/StudentClassUps", queryStringParam);

            var result = await _client.GetFromJsonAsync<PageList<StudentClassUPDtos>>(url);

            return result;
        }

        public async Task<int> UpdateStudentUP(Guid idClass, Guid idStudent, StudentClassUPUpdateVm student)
        {
            var url = Path.Combine($"/api/StudentClassUps/{idClass}/{idStudent}");
            var putResult = await _client.PutAsJsonAsync(url, student);
            if (putResult.IsSuccessStatusCode)
                return 1;

            return 0;
        }


        public async Task<List<StudentUpDto>> GetListSTTestAre(string getfileName, Guid idTrain)
        {

            //_httpContextAccessor.HttpContext.Session.SetString("filename", getfileName);
            var GetListStudentFromAPI = await _client.GetFromJsonAsync<List<StudentUP>>($"/api/Student/all");

            string[] arrSt = getfileName.Trim().Split("\n");




            for (int i = 0; i < arrSt.Count(); i++)
            {

                if (Regex.IsMatch(Convert.ToString(arrSt[i]), Partern) == false && !String.IsNullOrEmpty(Convert.ToString(arrSt[i])))
                {
                    continue;
                }

                if (Regex.IsMatch(Convert.ToString(arrSt[i]), Partern))
                {

                    GetListStudentFromAPI = await _client.GetFromJsonAsync<List<StudentUP>>($"/api/Student/all");
                    var StudentFormExcel = GetListStudentFromAPI.FirstOrDefault(c => c.Email == Convert.ToString(arrSt[i]));

                    if (_lstStudents.Any(c => c.Email == Convert.ToString(arrSt[i])))
                    {
                        continue;
                    }
                    if (StudentFormExcel != null)
                    {
                        var StudentMapp = new StudentUpDto()
                        {
                            Email = StudentFormExcel.Email,
                            Ethnic = StudentFormExcel.Ethnic,
                            Address = StudentFormExcel.Address,
                            DateOfBirth = Convert.ToDateTime(StudentFormExcel.DateOfBirth),
                            Description = StudentFormExcel.Description,
                            FathersName = StudentFormExcel.FathersName,
                            Gender = Convert.ToBoolean(StudentFormExcel.Gender),
                            HomeTown = StudentFormExcel.HomeTown,
                            Id = StudentFormExcel.Id,
                            IdentityCardNumber = StudentFormExcel.IdentityCardNumber,
                            ImageUrl = StudentFormExcel.ImageUrl,
                            IssuedOn = Convert.ToDateTime(StudentFormExcel.IssuedOn),
                            MotherName = StudentFormExcel.MotherName,
                            Password = StudentFormExcel.Password,
                            PhoneNumber = StudentFormExcel.PhoneNumber,
                            Status = Convert.ToInt32(StudentFormExcel.Status),
                            StudentCode = StudentFormExcel.StudentCode,
                            StudentName = StudentFormExcel.StudentName
                        };
                        if (_lstStudents.Any(c => c.Email == StudentMapp.Email))
                        {
                            continue;
                        }
                        _lstStudents.Add(StudentMapp);
                    }
                    else
                    {
                        var gmailExcel = Convert.ToString(arrSt[i]);
                        var studentgmail = gmailExcel.Split("@")[0];
                        var studentCode = studentgmail.Substring(studentgmail.Length - 7).ToUpper();
                        var studentInClassCreate = new StudentUpDto()
                        {
                            Email = Convert.ToString(arrSt[i]),
                            Ethnic = "",
                            Address = "",
                            DateOfBirth = DateTime.Now,
                            Description = "",
                            FathersName = "",
                            Gender = false,
                            HomeTown = "",
                            Id = Guid.NewGuid(),
                            IdentityCardNumber = "",
                            ImageUrl = "",
                            IssuedOn = DateTime.Now,
                            MotherName = "",
                            Password = "",
                            PhoneNumber = "",
                            Status = 2,
                            StudentCode = studentCode,
                            StudentName = ""

                        };
                        var url = Path.Combine($"/api/StudentClassUPs/createStudentInClass");
                        var studentInClass = await _client.PostAsJsonAsync(url, studentInClassCreate);
                        var StudentMapp = new StudentUpDto()
                        {
                            Email = studentInClassCreate.Email,
                            Ethnic = studentInClassCreate.Ethnic,
                            Address = studentInClassCreate.Address,
                            DateOfBirth = studentInClassCreate.DateOfBirth,
                            Description = studentInClassCreate.Description,
                            FathersName = studentInClassCreate.FathersName,
                            Gender = studentInClassCreate.Gender,
                            HomeTown = studentInClassCreate.HomeTown,
                            Id = studentInClassCreate.Id,
                            IdentityCardNumber = studentInClassCreate.IdentityCardNumber,
                            ImageUrl = studentInClassCreate.ImageUrl,
                            IssuedOn = studentInClassCreate.IssuedOn,
                            MotherName = studentInClassCreate.MotherName,
                            Password = studentInClassCreate.Password,
                            PhoneNumber = studentInClassCreate.PhoneNumber,
                            Status = studentInClassCreate.Status,
                            StudentCode = studentInClassCreate.StudentCode,
                            StudentName = studentInClassCreate.StudentName
                        };
                        _lstStudents.Add(StudentMapp);

                        UserSignIn newuser = new UserSignIn()
                        {
                            Email = Convert.ToString(arrSt[i]),
                            UserName = Convert.ToString(arrSt[i]),
                            ConcurrencyStamp = Guid.NewGuid().ToString(),
                            PhoneNumber = "123456",
                            PhoneNumberConfirmed = true,
                            TwoFactorEnabled = true,
                            LockoutEnabled = true,
                            AccessFailedCount = 0,
                            Id = studentInClassCreate.Id.ToString(),
                            IdTrainingFacility = idTrain,
                        };

                        if (_lstuserInListRoles.Any(c => c.Email == newuser.Email))
                        {
                            continue;
                        } 
                        var results = await _userManager.CreateAsync(newuser, "Pass123$");
                        

                        var _User = new UserInListRoles();
                        var claim = _lstRedirect.Find(c => c.Type == fpl);

                        if (claim != null)
                        _User.ListRedirectClaims.Add(claim);
                        _User.Id = newuser.Id;
                        _User.UserName = newuser.Email;
                        _User.IdTrainingFacility = newuser.IdTrainingFacility;
                        _User.ListRoles.Add("Student");
                         UserUpdateRolesHasClaims userUpdateRoles = new UserUpdateRolesHasClaims()
                        {
                            ID = _User.Id,
                            Name = _User.UserName,
                            claims = _User.ListRedirectClaims,
                            RoleNames = _User.ListRoles.ToArray()
                        };
                        var res = await _UserIdentityRepo.AddRolesToUser(userUpdateRoles);
                    }
                }
            }

            return _lstStudents;
        }

        //public async Task<List<StudentUpDto>> GetListST(string getfileName)
        //{

        //    //_httpContextAccessor.HttpContext.Session.SetString("filename", getfileName);
        //    var GetListStudentFromAPI = await _client.GetFromJsonAsync<List<StudentUP>>($"/api/Student/all");


        //    var fileName = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\files"}" + "\\" + getfileName;
        //    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


        //    using (var stream = System.IO.File.Open(fileName, FileMode.Open, FileAccess.Read))
        //    {
        //        IExcelDataReader read;

        //        using (read = ExcelReaderFactory.CreateReader(stream))
        //        {
        //            DataTable dt = new DataTable();


        //            var result = read.AsDataSet(new ExcelDataSetConfiguration()
        //            {
        //                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
        //                {
        //                    UseHeaderRow = true
        //                }
        //            });
        //            var tbl = result.Tables
        //             .Cast<DataTable>()
        //             .Select(t => new
        //             {
        //                 TableName = t.TableName,
        //                 Columns = t.Columns.Cast<DataColumn>()
        //                                    .Select(x => x.ColumnName)
        //                                    .ToList(),
        //                 Row = t.Rows
        //             });

        //            for (int i = 0; i < tbl.ToList()[0].Row.Count; i++)
        //            {
        //                foreach (var datacolcheck in tbl.ToList()[0].Columns)
        //                {
        //                    if (Regex.IsMatch(Convert.ToString(tbl.ToList()[0].Row[i][datacolcheck]), Partern) == false && !String.IsNullOrEmpty(Convert.ToString(tbl.ToList()[0].Row[i][datacolcheck])))
        //                    {
        //                        var excel = new ExcelErrors()
        //                        {
        //                            ErrorLine = i + 2,
        //                            IndexCol = tbl.ToList()[0].Columns.FindIndex(c => c == datacolcheck) + 1,
        //                            Message = " AI Đã Phát Hiện Ra Email Bị Sai Định Dạng Mời Bạn Sửa Lại !"
        //                        };
        //                        _listexcelErrors.Add(excel);
        //                    }

        //                    if (Regex.IsMatch(Convert.ToString(tbl.ToList()[0].Row[i][datacolcheck]), Partern))
        //                    {
        //                        Console.WriteLine(Convert.ToString(tbl.ToList()[0].Row[i][datacolcheck]));
        //                        GetListStudentFromAPI = await _client.GetFromJsonAsync<List<StudentUP>>($"/api/Student/all");
        //                        var StudentFormExcel = GetListStudentFromAPI.FirstOrDefault(c => c.Email == Convert.ToString(tbl.ToList()[0].Row[i][datacolcheck]));

        //                        if (_lstStudents.Any(c => c.Email == Convert.ToString(tbl.ToList()[0].Row[i][datacolcheck])))
        //                        {
        //                            var excel = new ExcelErrors()
        //                            {
        //                                ErrorLine = i + 2,
        //                                IndexCol = tbl.ToList()[0].Columns.FindIndex(c => c == datacolcheck) + 1,

        //                                Message = "AI Đã Phát Hiện Ra Email Bị Trùng Mời Bạn Sửa Lại !"
        //                            };

        //                            _listexcelErrors.Add(excel);
        //                        }
        //                        if (StudentFormExcel != null)
        //                        {





        //                            var StudentMapp = new StudentUpDto()
        //                            {
        //                                Email = StudentFormExcel.Email,
        //                                Ethnic = StudentFormExcel.Ethnic,
        //                                Address = StudentFormExcel.Address,
        //                                DateOfBirth = Convert.ToDateTime(StudentFormExcel.DateOfBirth),
        //                                Description = StudentFormExcel.Description,
        //                                FathersName = StudentFormExcel.FathersName,
        //                                Gender = Convert.ToBoolean(StudentFormExcel.Gender),
        //                                HomeTown = StudentFormExcel.HomeTown,
        //                                Id = StudentFormExcel.Id,
        //                                IdentityCardNumber = StudentFormExcel.IdentityCardNumber,
        //                                ImageUrl = StudentFormExcel.ImageUrl,
        //                                IssuedOn = Convert.ToDateTime(StudentFormExcel.IssuedOn),
        //                                MotherName = StudentFormExcel.MotherName,
        //                                Password = StudentFormExcel.Password,
        //                                PhoneNumber = StudentFormExcel.PhoneNumber,
        //                                Status = Convert.ToInt32(StudentFormExcel.Status),
        //                                StudentCode = StudentFormExcel.StudentCode,
        //                                StudentName = StudentFormExcel.StudentName
        //                            };
        //                            if (_lstStudents.Any(c => c.Email == StudentMapp.Email))
        //                            {
        //                                continue;
        //                            }
        //                            _lstStudents.Add(StudentMapp);
        //                        }
        //                        else
        //                        {
        //                            var gmailExcel = Convert.ToString(tbl.ToList()[0].Row[i][datacolcheck]);
        //                            var studentgmail = gmailExcel.Split("@")[0];
        //                            var studentCode = studentgmail.Substring(studentgmail.Length - 7).ToUpper();
        //                            var studentInClassCreate = new StudentUpDto()
        //                            {
        //                                Email = Convert.ToString(tbl.ToList()[0].Row[i][datacolcheck]),
        //                                Ethnic = "",
        //                                Address = "",
        //                                DateOfBirth = DateTime.Now,
        //                                Description = "",
        //                                FathersName = "",
        //                                Gender = false,
        //                                HomeTown = "",
        //                                Id = Guid.NewGuid(),
        //                                IdentityCardNumber = "",
        //                                ImageUrl = "",
        //                                IssuedOn = DateTime.Now,
        //                                MotherName = "",
        //                                Password = "",
        //                                PhoneNumber = "",
        //                                Status = 2,
        //                                StudentCode = studentCode,
        //                                StudentName = ""

        //                            };
        //                            var url = Path.Combine($"/api/StudentClassUPs/createStudentInClass");
        //                            var studentInClass = await _client.PostAsJsonAsync(url, studentInClassCreate);
        //                            var StudentMapp = new StudentUpDto()
        //                            {
        //                                Email = studentInClassCreate.Email,
        //                                Ethnic = studentInClassCreate.Ethnic,
        //                                Address = studentInClassCreate.Address,
        //                                DateOfBirth = studentInClassCreate.DateOfBirth,
        //                                Description = studentInClassCreate.Description,
        //                                FathersName = studentInClassCreate.FathersName,
        //                                Gender = studentInClassCreate.Gender,
        //                                HomeTown = studentInClassCreate.HomeTown,
        //                                Id = studentInClassCreate.Id,
        //                                IdentityCardNumber = studentInClassCreate.IdentityCardNumber,
        //                                ImageUrl = studentInClassCreate.ImageUrl,
        //                                IssuedOn = studentInClassCreate.IssuedOn,
        //                                MotherName = studentInClassCreate.MotherName,
        //                                Password = studentInClassCreate.Password,
        //                                PhoneNumber = studentInClassCreate.PhoneNumber,
        //                                Status = studentInClassCreate.Status,
        //                                StudentCode = studentInClassCreate.StudentCode,
        //                                StudentName = studentInClassCreate.StudentName
        //                            };
        //                            _lstStudents.Add(StudentMapp);

        //                            UserSignIn newuser = new UserSignIn()
        //                            {
        //                                Email = Convert.ToString(tbl.ToList()[0].Row[i][datacolcheck]),
        //                                UserName = Convert.ToString(tbl.ToList()[0].Row[i][datacolcheck]),
        //                                ConcurrencyStamp = Guid.NewGuid().ToString(),
        //                                PhoneNumber = "123456",
        //                                PhoneNumberConfirmed = true,
        //                                TwoFactorEnabled = true,
        //                                LockoutEnabled = true,
        //                                AccessFailedCount = 0,
        //                                Id = studentInClassCreate.Id.ToString(),
        //                            };

        //                            if (_lstuserInListRoles.Any(c => c.Email == newuser.Email))
        //                            {
        //                                continue;
        //                            }
        //                            var results = await _userManager.CreateAsync(newuser, "Pass123$");

        //                        }
        //                    }



        //                }


        //            }


        //            return _lstStudents;
        //        }

        //    }
        //}

        public Task<int> CreateStudentUP(StudentClassUPCreateVm student)
        {
            throw new NotImplementedException();
        }
    }
}
