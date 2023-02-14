using AutoMapper;
using ExcelDataReader;
using FPLSP.Data;
using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.FPLSPDbContext;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels;
using IdentityModel.Client;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text.RegularExpressions;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
namespace FPLSP.Repositories.Services
{
    public class TaskClassServices : ITaskRepositories<ClassUPViewModel>
    {
        public HttpClient _httpClient { get; set; }


        public List<StudentViewModel> _lstStudents = new List<StudentViewModel>();
        public List<StudentViewModel> _lstStudentsNew = new List<StudentViewModel>();
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IRepository<ClassUp> _IClassrepository;
        private readonly IRepository<LectuterSpecializedUP> _ILectuterSpecializedUPrepository;
        private readonly IRepository<SpecializedUP> _ISpecializedUPrepository;
        private List<LectuterSpecializedUP> _lstLecturterSpecialized = new List<LectuterSpecializedUP>(); // 

        private List<SpecializedUP> lstSpecialized = new List<SpecializedUP>();
        private List<SpecializedSubjectUP> lstSpecializedSubject = new List<SpecializedSubjectUP>();
        private List<SubjectClassUP> _lstSubjectClass = new List<SubjectClassUP>();

        private List<StudentClassUP> lstStudentClass = new List<StudentClassUP>();
        private List<ClassUp> _lstClassUP = new List<ClassUp>();
        private List<StudentUP> lstStudent = new List<StudentUP>();
        private List<LecturersCP> lstLecturersCP = new List<LecturersCP>();
        private List<SubjectUP> lstSubject = new List<SubjectUP>();
        private readonly IRepository<SpecializedSubjectUP> _ISpecializedSubjectUPrepository;
        private readonly IRepository<SubjectClassUP> _ISubjectClassUPrepository;
        private readonly IRepository<StudentClassUP> _IStudentClassUPrepository;

        private readonly IRepository<LecturersCP> _ILecturersCPrepository;
        private readonly IRepository<SubjectUP> _ISubjectUPrepository;

        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IMapper _mapper;
        private List<ExcelErrors> _listexcelErrors = new List<ExcelErrors>();
        private string Partern = "^[a-z]{3,13}[0-9]{5}@fpt.edu.vn";
        private readonly ApplicationDbContext _ApplicationDbContext;

        private readonly ITokenServices _tokenServices;

        public TaskClassServices(HttpClient httpClient, ITokenServices TokenService, IRepository<ClassUp> iClassrepository, IRepository<LectuterSpecializedUP> iLectuterSpecializedUPrepository, IRepository<SpecializedUP> iSpecializedUPrepository, IRepository<SpecializedSubjectUP> iSpecializedSubjectUPrepository, IRepository<SubjectClassUP> iSubjectClassUPrepository, IRepository<StudentClassUP> iStudentClassUPrepository, IRepository<StudentUP> iStudentUPrepository, IRepository<LecturersCP> iLecturersCPrepository, IRepository<SubjectUP> iSubjectUPrepository, IHostingEnvironment hostingEnvironment, IMapper mapper, ApplicationDbContext ApplicationDbContext)
        {
            _httpClient = httpClient;
            _mapper = mapper;
            _IClassrepository = iClassrepository;
            _ILectuterSpecializedUPrepository = iLectuterSpecializedUPrepository;
            _ISpecializedUPrepository = iSpecializedUPrepository;
            _ISpecializedSubjectUPrepository = iSpecializedSubjectUPrepository;
            _ISubjectClassUPrepository = iSubjectClassUPrepository;
            _IStudentClassUPrepository = iStudentClassUPrepository;

            _ILecturersCPrepository = iLecturersCPrepository;
            _ISubjectUPrepository = iSubjectUPrepository;
            _ApplicationDbContext = ApplicationDbContext;
            _hostingEnvironment = hostingEnvironment;
            //token
            _tokenServices = TokenService;
        }
        public async Task<bool> AddAsync(CreateClassVM entity)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/classes/creater", entity);
            return result.IsSuccessStatusCode;
        }

        public Task<IEnumerable<ClassUPViewModel>> AddRangeAsync(IEnumerable<ClassUPViewModel> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ClassUPViewModel> AsQueryable()
        {
            throw new NotImplementedException();
        }

        public async Task<PageList<ClassUPViewModel>> GetListDataAsync(ClassSearchDTO classSearchDTO)
        {
            var tokenRes = await _tokenServices.GetToken("IdentityFPLSP.read");
            _httpClient.SetBearerToken(tokenRes.AccessToken);
            //cai dit con me no nam o day
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = classSearchDTO.PageNumber.ToString()
            };

            if (!string.IsNullOrEmpty(classSearchDTO.ClassroomName))
            {
                queryStringParam.Add("ClassroomName", classSearchDTO.ClassroomName.ToString());
            }
            if (!string.IsNullOrEmpty(classSearchDTO.ClassroomCode))
            {
                queryStringParam.Add("ClassroomCode", classSearchDTO.ClassroomCode.ToString());
            }
            if (classSearchDTO.specializedUPId.HasValue)
            {
                queryStringParam.Add("specializedUPId", classSearchDTO.specializedUPId.ToString());
            }
            if (classSearchDTO.LecturterId.HasValue)
            {
                queryStringParam.Add("LecturterId", classSearchDTO.LecturterId.ToString());
            }
            if (classSearchDTO.SubjectId.HasValue)
            {
                queryStringParam.Add("SubjectId", classSearchDTO.SubjectId.ToString());
            }
            if (!string.IsNullOrEmpty(classSearchDTO.JoinCode))
            {
                queryStringParam.Add("ClassroomName", classSearchDTO.JoinCode.ToString());
            }

            string url = QueryHelpers.AddQueryString("/api/classes/fordetail", queryStringParam);
            var result = await _httpClient.GetFromJsonAsync<PageList<ClassUPViewModel>>(url);
            return result;
        }
        //
        public async Task<bool> UpdateAsync(string Id, CreateClassVM entity)
        {
            var tokenRes = await _tokenServices.GetToken("IdentityFPLSP.read");
            _httpClient.SetBearerToken(tokenRes.AccessToken);
            var result = await _httpClient.PutAsJsonAsync($"/api/classes/{Id.ToString()}", entity);
            return result.IsSuccessStatusCode;
        }

        public Task<IEnumerable<ClassUPViewModel>> UpdateRangeAsync(IEnumerable<ClassUPViewModel> entities)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RemoveAsync(string Id)
        {
            var result = await _httpClient.DeleteAsync($"/api/classes/{Id}");
            return true;
        }

        public Task<IEnumerable<ClassUPViewModel>> RemoveRangeAsync(IEnumerable<ClassUPViewModel> entities)
        {
            throw new NotImplementedException();
        }

        public async Task<CreateClassVM> GetClassById(string Id)
        {

            lstLecturersCP = _ILecturersCPrepository.AsQueryable().AsNoTracking().ToList();
            lstSpecialized = _ISpecializedUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstLecturterSpecialized = _ILectuterSpecializedUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstClassUP = _IClassrepository.AsQueryable().AsNoTracking().ToList();
            lstSpecializedSubject = _ISpecializedSubjectUPrepository.AsQueryable().AsNoTracking().ToList();
            lstSubject = _ISubjectUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstSubjectClass = _ISubjectClassUPrepository.AsQueryable().AsNoTracking().ToList();
            lstStudentClass = _IStudentClassUPrepository.AsQueryable().AsNoTracking().ToList();


            var FinalList = (from subcl in _lstSubjectClass
                             where subcl.JoinCode == Id && subcl.Status == 0
                             select new CreateClassVM()
                             {
                                 Id = Guid.Parse(subcl.ClassId.ToString()),
                                 SubjectName = lstSubject.Where(c => c.Id == subcl.SubjectId).Select(c => c.SubjectName).FirstOrDefault(),
                                 ClassroomName = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.ClassroomName).FirstOrDefault(),

                                 Building = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.Building).FirstOrDefault(),


                                 SubjectId = Guid.Parse(subcl.SubjectId.ToString()),

                                 Status = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.Status).FirstOrDefault(),
                                 specializedUPId = subcl.SpecializedOfClass,
                                 HomeroomLecturer = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.LecturersName).FirstOrDefault(),
                                 lecturersCPId = subcl.HomeroomLecturer,
                                 HomeroomLecturerId = subcl.HomeroomLecturer,
                                 ActualNumberOfStudent = lstStudentClass.Count(c => c.JoinCodeAsign == subcl.JoinCode),
                                 JoinCode = _lstSubjectClass.Where(c => c.JoinCode == subcl.JoinCode.ToString()).Select(c => c.JoinCode).FirstOrDefault(),
                                 subjectUP = _lstSubjectClass.Where(c => c.ClassId == subcl.ClassId).Select(c => c.SubjectId).ToList(),
                                 StudentAmount = _lstSubjectClass.Where(c => c.JoinCode == subcl.JoinCode.ToString()).Select(c => c.StudentAmount).FirstOrDefault(),
                                 ListStudent = lstStudentClass.Where(c => c.JoinCodeAsign == subcl.JoinCode).Select(c => c.StudentId).ToList(),
                                 SpecializedName = lstSpecialized.Where(c => c.Id == subcl.SpecializedOfClass).Select(c => c.SpecializationName).FirstOrDefault()
                             }).ToList().FirstOrDefault();

            if (FinalList == null)
            {
                FinalList = new CreateClassVM()
                {
                    Id = Guid.NewGuid(),
                    ClassroomName = string.Empty,
                    ClassroomCode = string.Empty,
                    Building = string.Empty,
                    StudentAmount = 0,
                    DateCreated = DateTime.Now,
                    HomeroomLecturer = string.Empty,
                    DateStarted = DateTime.Now,
                    EndDate = DateTime.Now,
                    Status = 0,
                    JoinCode = string.Empty,
                    SubjectId = Guid.Empty,
                    HomeroomLecturerId = Guid.Empty,
                    lecturersCPId = Guid.Empty,
                    ListStudent = new List<Guid?>(),
                    specializedUPId = Guid.Empty,
                    SpecializedName = String.Empty,
                    ActualNumberOfStudent = 0,
                    SubjectName = string.Empty,
                    subjectUP = new List<Guid?>()

                };
            }
            return FinalList;
        }

        public async Task<List<StudentViewModel>> LoadingBigData(IBrowserFile file)
        {
            var tokenRes = await _tokenServices.GetToken("IdentityFPLSP.read");
            _httpClient.SetBearerToken(tokenRes.AccessToken);
            string fileName = $"{_hostingEnvironment.WebRootPath}\\files\\{file.Name}";

            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                Stream stream = file.OpenReadStream();

                await stream.CopyToAsync(fileStream);
                fileStream.Flush();
            }
            var lstST = await this.GetListST(file.Name);



            return lstST;
        }
        public async Task<List<StudentViewModel>> GetListST(string getfileName)
        {

            //_httpContextAccessor.HttpContext.Session.SetString("filename", getfileName);
            var GetListStudentFromAPI = await _httpClient.GetFromJsonAsync<List<StudentUP>>($"/api/Student/all");


            var fileName = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\files"}" + "\\" + getfileName;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


            using (var stream = System.IO.File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader read;

                using (read = ExcelReaderFactory.CreateReader(stream))
                {
                    DataTable dt = new DataTable();


                    var result = read.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });
                    var tbl = result.Tables
                     .Cast<DataTable>()
                     .Select(t => new
                     {
                         TableName = t.TableName,
                         Columns = t.Columns.Cast<DataColumn>()
                                            .Select(x => x.ColumnName)
                                            .ToList(),
                         Row = t.Rows
                     });

                    for (int i = 0; i < tbl.ToList()[0].Row.Count; i++)
                    {
                        foreach (var datacolcheck in tbl.ToList()[0].Columns)
                        {


                            if (Regex.IsMatch(Convert.ToString(tbl.ToList()[0].Row[i][datacolcheck]), Partern))
                            {
                                Console.WriteLine(Convert.ToString(tbl.ToList()[0].Row[i][datacolcheck]));
                                var StudentFormExcel = GetListStudentFromAPI.FirstOrDefault(c => c.Email == Convert.ToString(tbl.ToList()[0].Row[i][datacolcheck]));

                                if (_lstStudents.Any(c => c.Email == Convert.ToString(tbl.ToList()[0].Row[i][datacolcheck])))
                                {
                                    var excel = new ExcelErrors()
                                    {
                                        ErrorLine = i + 2,
                                        IndexCol = tbl.ToList()[0].Columns.FindIndex(c => c == datacolcheck) + 1,

                                        Message = "AI Đã Phát Hiện Ra Email Bị Trùng Mời Bạn Sửa Lại !"
                                    };

                                    _listexcelErrors.Add(excel);
                                }
                                if (StudentFormExcel != null)
                                {
                                    var StudentMapp = _mapper.Map<StudentViewModel>(StudentFormExcel);
                                    _lstStudents.Add(StudentMapp);
                                }
                            }
                            if (Regex.IsMatch(Convert.ToString(tbl.ToList()[0].Row[i][datacolcheck]), Partern) == false && !String.IsNullOrEmpty(Convert.ToString(tbl.ToList()[0].Row[i][datacolcheck])))
                            {
                                var excel = new ExcelErrors()
                                {
                                    ErrorLine = i + 2,
                                    IndexCol = tbl.ToList()[0].Columns.FindIndex(c => c == datacolcheck) + 1,
                                    Message = " AI Đã Phát Hiện Ra Email Bị Sai Định Dạng Mời Bạn Sửa Lại !"
                                };
                                _listexcelErrors.Add(excel);
                            }


                        }


                    }


                    return _lstStudents;
                }

            }
        }
        public async Task<CreateClassVM> GetClassModel()
        {
            var tokenRes = await _tokenServices.GetToken("IdentityFPLSP.read");
            _httpClient.SetBearerToken(tokenRes.AccessToken);
            var result = await _httpClient.GetFromJsonAsync<CreateClassVM>("/api/classes/manage-create");
            return result;
        }

        public async Task<List<ExcelErrors>> GetListErr()
        {
            var tokenRes = await _tokenServices.GetToken("IdentityFPLSP.read");
            _httpClient.SetBearerToken(tokenRes.AccessToken);
            return _listexcelErrors;
        }

        public async Task<List<StudentViewModel>> GetAllStudent()
        {
            var tokenRes = await _tokenServices.GetToken("IdentityFPLSP.read");
            _httpClient.SetBearerToken(tokenRes.AccessToken);
            var result = await _httpClient.GetFromJsonAsync<List<StudentUP>>("/api/Student/all");
            foreach (var x in result)
            {
                var StudentMapp = _mapper.Map<StudentViewModel>(x);
                _lstStudentsNew.Add(StudentMapp);
            }
            return _lstStudentsNew;
        }

        public async Task<int> CountAsync()
        {
            var tokenRes = await _tokenServices.GetToken("IdentityFPLSP.read");
            _httpClient.SetBearerToken(tokenRes.AccessToken);
            var lst = await _ApplicationDbContext.SubjectClassUPs.ToListAsync();
            return lst.Where(c => c.Status == 0).Count();

        }

        public async Task<List<SubjectUP>> GetAllSub()
        {
            var tokenRes = await _tokenServices.GetToken("IdentityFPLSP.read");
            _httpClient.SetBearerToken(tokenRes.AccessToken);
            var result = await _httpClient.GetFromJsonAsync<List<SubjectUP>>($"/api/SubjectUPs/all");
            return result;
        }

        public async Task<List<SpecializedDto>> GetAllSpec()
        {
            var tokenRes = await _tokenServices.GetToken("IdentityFPLSP.read");
            _httpClient.SetBearerToken(tokenRes.AccessToken);
            var result = await _httpClient.GetFromJsonAsync<List<SpecializedDto>>($"/api/SpecializedUPs/getall/tatca");
            return result;
        }

        public async Task<List<LecturersCPViewModel>> GetAllLec()
        {
            var tokenRes = await _tokenServices.GetToken("IdentityFPLSP.read");
            _httpClient.SetBearerToken(tokenRes.AccessToken);
            var result = await _httpClient.GetFromJsonAsync<List<LecturersCPViewModel>>($"/api/LecturersCPs/all");
            return result;
        }

        public async Task<List<ClassUPViewModel>> GetAllClass()
        {
            lstLecturersCP = _ILecturersCPrepository.AsQueryable().AsNoTracking().ToList();
            lstSpecialized = _ISpecializedUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstLecturterSpecialized = _ILectuterSpecializedUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstClassUP = _IClassrepository.AsQueryable().AsNoTracking().ToList();
            lstSpecializedSubject = _ISpecializedSubjectUPrepository.AsQueryable().AsNoTracking().ToList();
            lstSubject = _ISubjectUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstSubjectClass = _ISubjectClassUPrepository.AsQueryable().AsNoTracking().ToList();
            lstStudentClass = _IStudentClassUPrepository.AsQueryable().AsNoTracking().ToList();

            var FinalList = (from
                              subcl in _lstSubjectClass
                             select new ClassUPViewModel()
                             {

                                 Id = Guid.Parse(subcl.ClassId.ToString()),
                                 SubjectName = lstSubject.Where(c => c.Id == subcl.SubjectId).Select(c => c.SubjectName).FirstOrDefault(),
                                 ClassroomName = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.ClassroomName).FirstOrDefault(),

                                 Building = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.Building).FirstOrDefault(),

                                 SubjectId = subcl.SubjectId,

                                 Status = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.Status).FirstOrDefault(),
                                 HomeroomLecturerId = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.Id).FirstOrDefault(),
                                 HomeroomLecturer = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.LecturersName).FirstOrDefault(),
                                 HomeroomLecturerEmail = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.Email).FirstOrDefault(),
                                 HomeroomLecturerPhoneNumber = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.PhoneNumber).FirstOrDefault(),
                                 SpecializedId = subcl.SpecializedOfClass,
                                 ActualNumberOfStudent = lstStudentClass.Count(c => c.JoinCodeAsign == subcl.JoinCode),
                                 JoinCode = _lstSubjectClass.Where(c => c.JoinCode == subcl.JoinCode).Select(c => c.JoinCode).FirstOrDefault(),
                                 subjectUP = _lstSubjectClass.Where(c => c.JoinCode == subcl.JoinCode).Select(c => c.SubjectId).ToList(),
                                 ListStudent = lstStudentClass.Where(c => c.JoinCodeAsign == subcl.JoinCode).Select(c => c.StudentId).ToList()
                                 
                             }).ToList();
            return FinalList;
        }

        public async Task<List<ClassUPViewModel>> GetListClassDetailForLec(string emaillec)
        {
            var tokenRes = await _tokenServices.GetToken("IdentityFPLSP.read");
            _httpClient.SetBearerToken(tokenRes.AccessToken);
            var res = await _httpClient.GetFromJsonAsync<List<ClassUPViewModel>>($"/api/classes/getclass-forlec/{emaillec}");
            return res.Where(c => c.Status == 0).ToList();
        }


        public async Task<List<ClassUPViewModel>> GetAllClass(Guid idstudent)
        {
            var tokenRes = await _tokenServices.GetToken("IdentityFPLSP.read");
            _httpClient.SetBearerToken(tokenRes.AccessToken);
            // _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenRes.AccessToken);
            var res = await _httpClient.GetFromJsonAsync<List<ClassUPViewModel>>($"/api/classes/fordetail-all/{idstudent}");
            return res;
        }

        public async Task<List<ClassUp>> getOnlyClass()
        {
            var res = await _httpClient.GetFromJsonAsync<List<ClassUp>>($"/api/SubjectClassOnlys/only-class");
            return res;
        }
    }
}
