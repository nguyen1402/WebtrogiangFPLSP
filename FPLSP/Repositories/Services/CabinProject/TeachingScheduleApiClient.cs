using Blazored.LocalStorage;
using DocumentFormat.OpenXml.Office2010.Excel;
using ExcelDataReader;
using FPLSP.Data;
using FPLSP.Repositories.Interfaces.CabinProject;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject.SignalRServices;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.ShiftOfCabin;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.TeachingSchedule;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Data;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using TeachingSchedule = FPLSP.Server.Domain.Entities.CabinProject.TeachingSchedule;
namespace FPLSP.Repositories.Services.CabinProject
{
    public class TeachingScheduleApiClient : ITeachingScheduleApiClient
    {
        private readonly IHubContext<SignalRHubBookingServices> _hubContext;
        private readonly HttpClient _httpClient;
        private readonly IHostingEnvironment _hostingEnvironment;
        private List<TeachingSchedule> _teachingSchedules = new List<TeachingSchedule>();
        private List<TeachingSchedule> _defaultList = new List<TeachingSchedule>();
        private readonly UserManager<UserSignIn> _userManager;
        private Guid GetIdClass;
        private Guid GetIdSubject;
        private DateTime lastdayoffirstweek;
        private DateTime startdayofnewweek;
        private int addingday;
        //
        private readonly ILocalStorageService _localStorageService;
        private List<CheckColumnName> _checkColumnNames = new List<CheckColumnName>()
        {

         new CheckColumnName() { ColumnName = "STT" },
            new CheckColumnName() { ColumnName = "Tên Lớp" },
            new CheckColumnName() { ColumnName = "Mã Môn" } ,
            new CheckColumnName() { ColumnName = "Tên Môn" },
            new CheckColumnName() { ColumnName = "Mã GV" } ,
            new CheckColumnName() { ColumnName = "Block" },
            new CheckColumnName() { ColumnName = "Kỳ" },
            new CheckColumnName() { ColumnName = "Thứ" },
            new CheckColumnName() { ColumnName = "Ca Dạy" },
            new CheckColumnName() { ColumnName = "Ngành" },
            new CheckColumnName() { ColumnName = "Remote" },
            new CheckColumnName() { ColumnName = "Ghi Chú" }
        };
        private List<TeachingSchedule> _getFullList = new List<TeachingSchedule>();
        private List<TeachingSchedule> _lstTeachingFormDatabase = new List<TeachingSchedule>();

        private readonly ITeachingScheduleApiClient _teachingScheduleApiClient;
        private readonly IRepository<SubjectUP> _ISubjectUPrepository;
        private readonly IRepository<ClassUp> _IClassrepository;
        private readonly IRepository<SpecializedUP> _ISpecrepository;
        private readonly IRepository<SpecializedUP> _ISpecializedUPrepository;
        private readonly IRepository<SubjectClassUP> _ISubjectClassUPrepository;
        private readonly IRepository<LecturersCP> _LecturersCPRepository;
        private readonly IRepository<TeachingSchedule> _teachingscheduRepo;
        public TeachingScheduleApiClient(HttpClient httpClient,
            IRepository<SubjectUP> ISubjectUPrepository,
            IRepository<ClassUp> IClassrepository,
            IRepository<TeachingSchedule> teachingscheduRepo,
            IRepository<SpecializedUP> ISpecrepository,
             IRepository<SubjectClassUP> ISubjectClassUPrepository,
             IRepository<SpecializedUP> ISpecializedUPrepository,
             IRepository<LecturersCP> LecturersCPRepository,
              ILocalStorageService localStorageService,
            IHostingEnvironment hostingEnvironment, UserManager<UserSignIn> userManager, IHubContext<SignalRHubBookingServices> hubContext)
        {
            _httpClient = httpClient;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
            _teachingscheduRepo = teachingscheduRepo;
            _ISpecrepository = ISpecrepository;
            _LecturersCPRepository = LecturersCPRepository;
            _ISpecializedUPrepository = ISpecializedUPrepository;
            _ISubjectClassUPrepository = ISubjectClassUPrepository;
            _ISubjectUPrepository = ISubjectUPrepository;
            _IClassrepository = IClassrepository;
            _localStorageService = localStorageService;
            _hubContext = hubContext ?? throw new ArgumentNullException(nameof(hubContext));
        }
        /// <summary>
        /// Thêm mới lịch dạy theo thông tin đối tượng được truyền vào
        /// </summary>
        /// <param name="teachingSchedule">thông tin đối tượng được truyền vào</param>
        /// <returns>Trả về true nếu thành công, false nếu thất bại</returns>
        public async Task<bool> Add(TeachingScheduleCreateVM teachingSchedule)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/TeachingSchedules", teachingSchedule);
            return result.IsSuccessStatusCode;
        }
        /// <summary>
        /// Xóa lịch dạy theo id bằng id được truyền vào
        /// </summary>
        /// <param name="Id">id lịch dạy</param>
        /// <returns>Trả về true nếu thành công, false nếu thất bại</returns>
        public async Task<bool> Delete(Guid Id)
        {
            var result = await _httpClient.DeleteAsync($"/api/TeachingSchedules/{Id}");
            return result.IsSuccessStatusCode;
        }
        /// <summary>
        /// Lấy ra danh sách tất cả lịch dạy
        /// </summary>
        /// <returns>Trả về danh sách tất cả lịch dạy</returns>
        public async Task<List<TeachingScheduleVM>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<TeachingScheduleVM>>("/api/TeachingSchedules/all");
            return result;
        }
        /// <summary>
        /// Lấy ra lịch dạy theo id bằng id được truyền vào
        /// </summary>
        /// <param name="Id">id lịch dạy</param>
        /// <returns>Trả về lịch dạy có id bằng id được truyền vào</returns>
        public async Task<TeachingScheduleVM> GetById(Guid Id)
        {
            var result = await _httpClient.GetFromJsonAsync<TeachingScheduleVM>($"/api/TeachingSchedules/{Id}");
            return result;
        }
        /// <summary>
        /// Lấy ra danh sách lịch dạy theo keyword search
        /// </summary>
        /// <param name="search">keyword search</param>
        /// <returns>Trả về danh sách lịch dạy theo keyword search</returns>
        public async Task<PageList<TeachingScheduleVM>> GetForSearch(TeachingScheduleSearch search)
        {
            var result = await _httpClient.GetFromJsonAsync<PageList<TeachingScheduleVM>>("/api/TeachingSchedules/search");
            return result;
        }
        /// <summary>
        /// Cập nhật lịch dạt với id bằng id được truyền vào và theo thông tin đối tượng được truyền vào
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="teachingSchedule"></param>
        /// <returns></returns>
        public async Task<bool> Update(Guid Id, TeachingscheduleUpdateVM teachingSchedule)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/TeachingSchedules/{Id}", teachingSchedule);
            return result.IsSuccessStatusCode;
        }

        public async Task<PageForTeachingSchedule<TeachingSchedule>> LoadingTeachingSchedule(IBrowserFile file, Guid Iduser, Guid Idtrain, Guid IdBlock, Guid IdSem, TeachinhScheduleSearch pagingParameterForSchedule)
        {

            //string fileName = $"{_hostingEnvironment.WebRootPath}\\files\\{file.Name}";
            string fileName = $"wwwroot/files/{file.Name}";

            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                Stream stream = file.OpenReadStream();
                await stream.CopyToAsync(fileStream);
                fileStream.Flush();              
            }
            _teachingSchedules = await this.GetListTeachingSchedule(file.Name, Iduser, Idtrain, IdBlock, IdSem);
            var res = await GetPagingData(pagingParameterForSchedule);
            return res;
        }
        public async Task<List<TeachingSchedule>> GetListTeachingSchedule(string getfileName, Guid IdUser, Guid Idtrain, Guid IdBlock, Guid IdSem)
        {
            _teachingSchedules.Clear();
            //lấy ra 2 list cần dùng để truy vấn
            var _listSubjectClass = await _httpClient.GetFromJsonAsync<List<SubjectClassUP>>($"/api/SubjectClassOnlys");
            var _lstSemesterBlock = await _httpClient.GetFromJsonAsync<List<SemesterBlockDto>>("api/SemesterBlocks");
            var _lstShift = await _httpClient.GetFromJsonAsync<List<ShiftOfCabinVM>>("/api/ShiftOfCabins/all");
            var _lstUser = await _userManager.Users.ToListAsync();
            var _lstSpec = await _ISpecrepository.AsQueryable().ToListAsync();
            var _lstsubject = await _httpClient.GetFromJsonAsync<List<SubjectDto>>("/api/subjectups/all");
            var _lstClass = await _httpClient.GetFromJsonAsync<List<ClassUp>>($"/api/SubjectClassOnlys/only-class");
            var _lstSem = await _httpClient.GetFromJsonAsync<List<SemesterDto>>($"api/Semesters");
            var _lstBlock = await _httpClient.GetFromJsonAsync<List<BlockDto>>("api/Blocks");
            var _lstLec = await _httpClient.GetFromJsonAsync<List<LecturersCP>>("/api/LecturersCPs/all");

            //fake tạm lấy đúng block 1 fall 2002
            var GetStartDayOfBlock = _lstSemesterBlock.Where(c => c.IdSemester == IdSem && c.IdBlock == IdBlock &&  c.Status != 1).Select(c => c.StartTime).FirstOrDefault();
            var GetEndDayOfBlock = _lstSemesterBlock.Where(c => c.IdSemester == IdSem && c.IdBlock == IdBlock && c.Status != 1).Select(c => c.EndTime).FirstOrDefault();
            var getToTalDayOfBlock = (GetEndDayOfBlock - GetStartDayOfBlock).TotalDays;
            //chia lấy phần dư để tổng hợp ra số tuần
            var sotuannguyen = (int)Math.Ceiling(getToTalDayOfBlock / 7);
            var songaydu = getToTalDayOfBlock % 7;
            var fileName = $"{Directory.GetCurrentDirectory()}{@"/wwwroot/files"}" + "//" + getfileName;
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
                    var counter = tbl.ToList()[0].Row.Count;
                    for (int i = 0; i < tbl.ToList()[0].Row.Count; i++)
                    {

                        //check đầu vào file excel
                        foreach (var col in tbl.ToList()[0].Columns)
                        {
                            if (_checkColumnNames.Any(c => c.ColumnName.ToLower().Trim() == col.ToLower().Trim()) == false)
                            {
                                return _teachingSchedules;
                            }
                        }

                        //check ngay ở trên  này trước khi xử lý các bài toán liên quan đến ngày dạy
                        if (_lstClass.Any(c => c.ClassroomName == Convert.ToString(tbl.ToList()[0].Row[i]["Tên Lớp"])) == false)
                        {
                            //tiến hành gọi services thêm ở đây
                            ClassUp classUp = new ClassUp()
                            {
                                Id = Guid.NewGuid(),
                                ClassroomName = Convert.ToString(tbl.ToList()[0].Row[i]["Tên Lớp"]),
                                Building = "Toa T",
                                Status = 0,
                            };
                            await _IClassrepository.AddAsync(classUp);
                            await _IClassrepository.SaveChangesAsync();
                        }
                        if (_lstsubject.Any(c => c.SubjectCode == Convert.ToString(tbl.ToList()[0].Row[i]["Mã Môn"])) == false)
                        {
                            SubjectUP subjectUP = new SubjectUP()
                            {

                                SubjectCode = Convert.ToString(tbl.ToList()[0].Row[i]["Mã Môn"]),
                                SubjectName = Convert.ToString(tbl.ToList()[0].Row[i]["Tên Môn"]),
                                CreatedBy = IdUser,
                                StartDay = DateTime.Now,
                                IsDemo = false,
                                TotalOfSub = 10,
                                Status = 0,
                                Image = "hahahahhaha"
                            };
                            await _ISubjectUPrepository.AddAsync(subjectUP);
                            await _ISubjectUPrepository.SaveChangesAsync();
                        }
                        if (_lstLec.Any(c => c.Email.ToLower().Contains(Convert.ToString(tbl.ToList()[0].Row[i]["Mã GV"]).ToLower())) == false)
                        {
                            var lec = _lstLec.FirstOrDefault(x => x.Email.Replace("@fpt.edu.vn","") == Convert.ToString(tbl.ToList()[0].Row[i]["Mã GV"]) && x.LecturersCode != "Test");
                            LecturersCP lecturersCP = new LecturersCP();
                            if (lec != null)
                            {
                                
                                lecturersCP = lec;
                            }
                            else
                            {
                               lecturersCP = new LecturersCP()
                                {
                                    Id = Guid.NewGuid(),
                                    LecturersCode = "Test",
                                    LecturersName = Convert.ToString(tbl.ToList()[0].Row[i]["Mã GV"]),
                                    Gender = true,
                                    Dob = DateTime.Now,
                                    Email = Convert.ToString(tbl.ToList()[0].Row[i]["Mã GV"]) + "@fpt.edu.vn",
                                    PhoneNumber = "1111111111",
                                    PassWord = "hahaha",
                                    Address = "hahshass",
                                    IdentityCard = "122388162",
                                    IssuedOn = DateTime.Now,
                                    YearsOfExperience = 2,
                                    ImageUrl = "hahahha",
                                    Ethnic = "Kinh",
                                    HomeTown = "bacgiang",
                                    Description = "haha",
                                    Status = 0,
                                    RoleId = Guid.Parse("87F96A49-681D-4CF5-9825-6BC6A0573081"),
                                    TrainingFacilitiesId = Idtrain

                                };
                            }
                           
                            await _LecturersCPRepository.AddAsync(lecturersCP);
                            await _LecturersCPRepository.SaveChangesAsync();


                        }
                        if (_lstSpec.Any(c => c.SpecializationName == Convert.ToString(tbl.ToList()[0].Row[i]["Ngành"])) == false)
                        {
                            SpecializedUP specializedUP = new SpecializedUP()
                            {
                                SpecializedCode = "8129912",
                                SpecializationName = Convert.ToString(tbl.ToList()[0].Row[i]["Ngành"]),
                                Status = 0,
                                Level = 3,
                                Image = "test",
                                SpecialityId = null
                            };
                            await _ISpecializedUPrepository.AddAsync(specializedUP);
                            await _ISpecializedUPrepository.SaveChangesAsync();
                        }
                        var trumlop = _IClassrepository.AsQueryable().Where(c => c.ClassroomName == tbl.ToList()[0].Row[i]["Tên Lớp"]).Select(c => c.Id).FirstOrDefault();
                        var trummon = _ISubjectUPrepository.AsQueryable().Where(c => c.SubjectCode == tbl.ToList()[0].Row[i]["Mã Môn"]).Select(c => c.Id).FirstOrDefault();
                        var idlec = _LecturersCPRepository.AsQueryable().Where(c => c.LecturersCode == tbl.ToList()[0].Row[i]["Mã GV"]).Select(c => c.Id).FirstOrDefault();
                        var idspec = _ISpecializedUPrepository.AsQueryable().Where(c => c.SpecializationName == tbl.ToList()[0].Row[i]["Ngành"]).Select(c => c.Id).FirstOrDefault();
                        if (_ISubjectClassUPrepository.AsQueryable().Any(c => c.ClassId == trumlop && c.SubjectId == trummon) == false)
                        {
                            SubjectClassUP subjectClassUP = new SubjectClassUP()
                            {
                                SubjectId = trummon,
                                ClassId = trumlop,
                                Status = 0,
                                StudentAmount = 40,
                                JoinCode = "hhhhhhhhhh",
                                DateCreated = DateTime.Now,
                                DateStarted = DateTime.Now,
                                EndDate = DateTime.Now,
                                HomeroomLecturer = idlec,
                                SpecializedOfClass = idspec
                            };
                            await _ISubjectClassUPrepository.AddAsync(subjectClassUP);
                            await _ISubjectClassUPrepository.SaveChangesAsync();


                        }


                        if (songaydu == 0)
                        {
                            for (int dayincre = 0; dayincre < sotuannguyen; dayincre++)
                            {
                                //phải xét theo thứ để lấy lịch dạy và có điều kiện lấy ra thứ
                                //quan trọng nhất là lấy ngày bắt đầu của kì để lấy ra đồng thời ngày dạy để cộng lên
                                var weekday = tbl.ToList()[0].Row[i]["Thứ"].ToString().ToArray();
                                var maxleng = weekday.Length;
                                //lấy ra thức cuối cùng để áp dụng công thức
                                var lastdayofweek = weekday[weekday.Length - 1].ToString();

                                //trường hợp khoảng cách ca dạy của tuần trước và tuần sau không phải là 7 ngày
                                if (weekday.Length != 1)
                                {
                                    //lấy ra phần tử của thứ
                                    for (int charday = 0; charday < weekday.Length; charday++)
                                    {
                                        addingday = 7 - (Convert.ToInt32(weekday[weekday.Length - 1].ToString()) - Convert.ToInt32(weekday[0].ToString()));
                                        //đây sẽ là tuần đầu tiên kể từ các tuần sau thì sẽ lấy ngày cuối cùng được insert vào cộng thêm 
                                        if (dayincre == 0)
                                        {

                                            TeachingSchedule teachingSchedule = new TeachingSchedule()
                                            {

                                                Id = Guid.NewGuid(),
                                                TeachingDay = GetStartDayOfBlock.AddDays(Convert.ToInt32(weekday[charday].ToString()) - 2),
                                                ImportTime = DateTime.Now,
                                                IdAdminImport = IdUser,
                                                SubjectId = _lstsubject.Where(c => c.SubjectCode == Convert.ToString(tbl.ToList()[0].Row[i]["Mã Môn"])).Select(c => c.Id).FirstOrDefault(),
                                                ClassId = _lstClass.Where(c => c.ClassroomName == Convert.ToString(tbl.ToList()[0].Row[i]["Tên Lớp"])).Select(c => c.Id).FirstOrDefault(),
                                                IdShift = _lstShift.Where(c => c.ShiftName.Contains(tbl.ToList()[0].Row[i]["Ca Dạy"].ToString())).Select(c => c.Id).FirstOrDefault(),
                                                IdLecturter = _lstLec.Where(c => c.Email.ToLower().Contains(Convert.ToString(tbl.ToList()[0].Row[i]["Mã GV"]).ToLower())).Select(c => c.Id).FirstOrDefault(),
                                                IndexOfTeachingSchedule = _teachingSchedules.Count() + 1,
                                                Status = 0,
                                                Note = Convert.ToString(tbl.ToList()[0].Row[i]["Ghi Chú"]),
                                                Remote = Convert.ToString(tbl.ToList()[0].Row[i]["Remote"]),
                                                IdBlock = IdBlock,
                                                IdSemester = IdSem,
                                                IdTrainingFacility = Idtrain

                                            };
                                            GetIdClass = _lstClass.Where(c => c.ClassroomName == Convert.ToString(tbl.ToList()[0].Row[i]["Tên Lớp"])).Select(c => c.Id).FirstOrDefault();
                                            GetIdSubject = _lstsubject.Where(c => c.SubjectCode == Convert.ToString(tbl.ToList()[0].Row[i]["Mã Môn"])).Select(c => c.Id).FirstOrDefault();
                                            _teachingSchedules.Add(teachingSchedule);


                                            //và tính ra được số ngày cộng thêm

                                            if (charday == weekday.Length - 1)
                                            {
                                                lastdayoffirstweek = _teachingSchedules.Where(c => c.ClassId == GetIdClass && c.SubjectId == GetIdSubject).Select(c => c.TeachingDay).LastOrDefault();
                                            }
                                            startdayofnewweek = lastdayoffirstweek.AddDays(addingday);
                                        }
                                        //từ ở tuần thứ 2 trở đi là phải áp dụng công thức tính ngày
                                        //( 7-(thứ cuối cùng của tuần đó có lịch dạy -2)) là sẽ ra khoảng cách bắt đầu ngày mới có lịch dạy
                                        else
                                        {
                                            //lấy ra ngày cuối cùng của tuần đầu tiên có lịch dạy để áp dụng vào công thức
                                            //cho ra được ngày bắt đầu của tuần tiếp theo

                                            if (charday == 0)
                                            {

                                                TeachingSchedule teachingSchedule = new TeachingSchedule()
                                                {
                                                    Id = Guid.NewGuid(),
                                                    TeachingDay = startdayofnewweek,
                                                    ImportTime = DateTime.Now,
                                                    IdAdminImport = IdUser,
                                                    SubjectId = _lstsubject.Where(c => c.SubjectCode == Convert.ToString(tbl.ToList()[0].Row[i]["Mã Môn"])).Select(c => c.Id).FirstOrDefault(),
                                                    ClassId = _lstClass.Where(c => c.ClassroomName == Convert.ToString(tbl.ToList()[0].Row[i]["Tên Lớp"])).Select(c => c.Id).FirstOrDefault(),
                                                    IdShift = _lstShift.Where(c => c.ShiftName.Contains(tbl.ToList()[0].Row[i]["Ca Dạy"].ToString())).Select(c => c.Id).FirstOrDefault(),
                                                    IdLecturter = _lstLec.Where(c => c.Email.ToLower().Contains(Convert.ToString(tbl.ToList()[0].Row[i]["Mã GV"]).ToLower())).Select(c => c.Id).FirstOrDefault(),
                                                    IndexOfTeachingSchedule = _teachingSchedules.Count() + 1,
                                                    Status = 0,
                                                    Note = Convert.ToString(tbl.ToList()[0].Row[i]["Ghi Chú"]),
                                                    Remote = Convert.ToString(tbl.ToList()[0].Row[i]["Remote"]),
                                                    IdBlock = IdBlock,
                                                    IdSemester = IdSem,
                                                    IdTrainingFacility = Idtrain
                                                };
                                                _teachingSchedules.Add(teachingSchedule);

                                            }
                                            else
                                            {

                                                //trường hợp là có nhiều hơn 2 ngày dạy trong tuần thì lại tiếp tục lấy ngày bắt đầu cộng thêm thứ
                                                TeachingSchedule teachingSchedule = new TeachingSchedule()
                                                {
                                                    Id = Guid.NewGuid(),
                                                    TeachingDay = startdayofnewweek.AddDays(Convert.ToInt32(weekday[charday].ToString()) - Convert.ToInt32(weekday[charday - 1].ToString())),
                                                    ImportTime = DateTime.Now,
                                                    IdAdminImport = IdUser,
                                                    SubjectId = _lstsubject.Where(c => c.SubjectCode == Convert.ToString(tbl.ToList()[0].Row[i]["Mã Môn"])).Select(c => c.Id).FirstOrDefault(),
                                                    ClassId = _lstClass.Where(c => c.ClassroomName == Convert.ToString(tbl.ToList()[0].Row[i]["Tên Lớp"])).Select(c => c.Id).FirstOrDefault(),
                                                    IdShift = _lstShift.Where(c => c.ShiftName.Contains(tbl.ToList()[0].Row[i]["Ca Dạy"].ToString())).Select(c => c.Id).FirstOrDefault(),
                                                    IdLecturter = _lstLec.Where(c => c.Email.ToLower().Contains(Convert.ToString(tbl.ToList()[0].Row[i]["Mã GV"]).ToLower())).Select(c => c.Id).FirstOrDefault(),
                                                    IndexOfTeachingSchedule = _teachingSchedules.Count() + 1,
                                                    Status = 0,
                                                    Note = Convert.ToString(tbl.ToList()[0].Row[i]["Ghi Chú"]),
                                                    Remote = Convert.ToString(tbl.ToList()[0].Row[i]["Remote"]),
                                                    IdBlock = IdBlock,
                                                    IdSemester = IdSem,
                                                    IdTrainingFacility = Idtrain

                                                };
                                                _teachingSchedules.Add(teachingSchedule);

                                                var lastindex = _teachingSchedules.FindLastIndex(c => c.ClassId == GetIdClass && c.SubjectId == GetIdSubject);
                                                if (charday == weekday.Length - 1)
                                                {
                                                    lastdayoffirstweek = _teachingSchedules.Where(c => c.ClassId == GetIdClass && c.SubjectId == GetIdSubject).Select(c => c.TeachingDay).LastOrDefault();
                                                    startdayofnewweek = lastdayoffirstweek.AddDays(addingday);
                                                }
                                                else
                                                {
                                                    lastdayoffirstweek = _teachingSchedules.Where(c => c.ClassId == GetIdClass && c.SubjectId == GetIdSubject).Select(c => c.TeachingDay).LastOrDefault();
                                                    startdayofnewweek = lastdayoffirstweek;
                                                }

                                            }

                                        }

                                    }
                                }




                                //trường hợp tuần trước cách tuần sau 7 ngày
                                if (weekday.Length == 1)
                                {
                                    if (dayincre == 0)
                                    {
                                        TeachingSchedule teachingSchedule = new TeachingSchedule()
                                        {
                                            Id = Guid.NewGuid(),
                                            TeachingDay = GetStartDayOfBlock.AddDays(Convert.ToInt32(tbl.ToList()[0].Row[i]["Thứ"].ToString()) - 2),
                                            ImportTime = DateTime.Now,
                                            IdAdminImport = IdUser,
                                            SubjectId = _lstsubject.Where(c => c.SubjectCode == Convert.ToString(tbl.ToList()[0].Row[i]["Mã Môn"])).Select(c => c.Id).FirstOrDefault(),
                                            ClassId = _lstClass.Where(c => c.ClassroomName == Convert.ToString(tbl.ToList()[0].Row[i]["Tên Lớp"])).Select(c => c.Id).FirstOrDefault(),
                                            IdShift = _lstShift.Where(c => c.ShiftName.Contains(tbl.ToList()[0].Row[i]["Ca Dạy"].ToString())).Select(c => c.Id).FirstOrDefault(),
                                            IdLecturter = _lstLec.Where(c => c.Email.ToLower().Contains(Convert.ToString(tbl.ToList()[0].Row[i]["Mã GV"]).ToLower())).Select(c => c.Id).FirstOrDefault(),
                                            IndexOfTeachingSchedule = _teachingSchedules.Count() + 1,
                                            Status = 0,
                                            Note = Convert.ToString(tbl.ToList()[0].Row[i]["Ghi Chú"]),
                                            Remote = Convert.ToString(tbl.ToList()[0].Row[i]["Remote"]),
                                            IdBlock = IdBlock,
                                            IdSemester = IdSem,
                                            IdTrainingFacility = Idtrain

                                        };

                                        _teachingSchedules.Add(teachingSchedule);
                                        lastdayoffirstweek = _teachingSchedules[_teachingSchedules.Count() - 1].TeachingDay;
                                        startdayofnewweek = lastdayoffirstweek.AddDays(7);
                                    }
                                    else
                                    {
                                        //trường hợp là có nhiều hơn 2 ngày dạy trong tuần thì lại tiếp tục lấy ngày bắt đầu cộng thêm thứ
                                        TeachingSchedule teachingSchedule = new TeachingSchedule()
                                        {
                                            Id = Guid.NewGuid(),
                                            TeachingDay = startdayofnewweek,
                                            ImportTime = DateTime.Now,
                                            IdAdminImport = IdUser,
                                            SubjectId = _lstsubject.Where(c => c.SubjectCode == Convert.ToString(tbl.ToList()[0].Row[i]["Mã Môn"])).Select(c => c.Id).FirstOrDefault(),
                                            ClassId = _lstClass.Where(c => c.ClassroomName == Convert.ToString(tbl.ToList()[0].Row[i]["Tên Lớp"])).Select(c => c.Id).FirstOrDefault(),
                                            IdShift = _lstShift.Where(c => c.ShiftName.Contains(tbl.ToList()[0].Row[i]["Ca Dạy"].ToString())).Select(c => c.Id).FirstOrDefault(),
                                            IdLecturter = _lstLec.Where(c => c.Email.ToLower().Contains(Convert.ToString(tbl.ToList()[0].Row[i]["Mã GV"]).ToLower())).Select(c => c.Id).FirstOrDefault(),
                                            IndexOfTeachingSchedule = _teachingSchedules.Count() + 1,
                                            Status = 0,
                                            Note = Convert.ToString(tbl.ToList()[0].Row[i]["Ghi Chú"]),
                                            Remote = Convert.ToString(tbl.ToList()[0].Row[i]["Remote"]),
                                            IdBlock = IdBlock,
                                            IdSemester = IdSem,
                                            IdTrainingFacility = Idtrain

                                        };
                                        _teachingSchedules.Add(teachingSchedule);

                                        lastdayoffirstweek = _teachingSchedules[_teachingSchedules.Count() - 1].TeachingDay;
                                        startdayofnewweek = lastdayoffirstweek.AddDays(7);

                                    }
                                }

                            }

                            _getFullList = _teachingSchedules;
                            _defaultList = _teachingSchedules;
                            ///await _localStorageService.SetItemAsync("listdefault", _defaultList);
                            return _teachingSchedules;
                        }
                        //đây là tính theo số nguyên tuần bị dư và ở tuần cuối cùng phải xét
                        else
                        {
                            for (int dayincre = 0; dayincre < sotuannguyen; dayincre++)
                            {
                                if (dayincre < sotuannguyen - 1)
                                {
                                    //phải xét theo thứ để lấy lịch dạy và có điều kiện lấy ra thứ
                                    //quan trọng nhất là lấy ngày bắt đầu của kì để lấy ra đồng thời ngày dạy để cộng lên
                                    var weekday = tbl.ToList()[0].Row[i]["Thứ"].ToString().ToArray();
                                    var maxleng = weekday.Length;
                                    //lấy ra thức cuối cùng để áp dụng công thức
                                    var lastdayofweek = weekday[weekday.Length - 1].ToString();

                                    //trường hợp khoảng cách ca dạy của tuần trước và tuần sau không phải là 7 ngày
                                    if (weekday.Length != 1)
                                    {
                                        //lấy ra phần tử của thứ
                                        for (int charday = 0; charday < weekday.Length; charday++)
                                        {
                                            addingday = 7 - (Convert.ToInt32(weekday[weekday.Length - 1].ToString()) - Convert.ToInt32(weekday[0].ToString()));
                                            //đây sẽ là tuần đầu tiên kể từ các tuần sau thì sẽ lấy ngày cuối cùng được insert vào cộng thêm 
                                            if (dayincre == 0)
                                            {

                                                TeachingSchedule teachingSchedule = new TeachingSchedule()
                                                {

                                                    Id = Guid.NewGuid(),
                                                    TeachingDay = GetStartDayOfBlock.AddDays(Convert.ToInt32(weekday[charday].ToString()) - 2),
                                                    ImportTime = DateTime.Now,
                                                    IdAdminImport = IdUser,
                                                    SubjectId = _lstsubject.Where(c => c.SubjectCode == Convert.ToString(tbl.ToList()[0].Row[i]["Mã Môn"])).Select(c => c.Id).FirstOrDefault(),
                                                    ClassId = _lstClass.Where(c => c.ClassroomName == Convert.ToString(tbl.ToList()[0].Row[i]["Tên Lớp"])).Select(c => c.Id).FirstOrDefault(),
                                                    IdShift = _lstShift.Where(c => c.ShiftName.Contains(tbl.ToList()[0].Row[i]["Ca Dạy"].ToString())).Select(c => c.Id).FirstOrDefault(),
                                                    IdLecturter = _lstLec.Where(c => c.Email.ToLower().Contains(Convert.ToString(tbl.ToList()[0].Row[i]["Mã GV"]).ToLower())).Select(c => c.Id).FirstOrDefault(),
                                                    IndexOfTeachingSchedule = _teachingSchedules.Count() + 1,
                                                    Status = 0,
                                                    Note = Convert.ToString(tbl.ToList()[0].Row[i]["Ghi Chú"]),
                                                    Remote = Convert.ToString(tbl.ToList()[0].Row[i]["Remote"]),
                                                    IdBlock = IdBlock,
                                                    IdSemester = IdSem,
                                                    IdTrainingFacility = Idtrain

                                                };
                                                GetIdClass = _lstClass.Where(c => c.ClassroomName == Convert.ToString(tbl.ToList()[0].Row[i]["Tên Lớp"])).Select(c => c.Id).FirstOrDefault();
                                                GetIdSubject = _lstsubject.Where(c => c.SubjectCode == Convert.ToString(tbl.ToList()[0].Row[i]["Mã Môn"])).Select(c => c.Id).FirstOrDefault();
                                                _teachingSchedules.Add(teachingSchedule);


                                                //và tính ra được số ngày cộng thêm

                                                if (charday == weekday.Length - 1)
                                                {
                                                    lastdayoffirstweek = _teachingSchedules.Where(c => c.ClassId == GetIdClass && c.SubjectId == GetIdSubject).Select(c => c.TeachingDay).LastOrDefault();
                                                }
                                                startdayofnewweek = lastdayoffirstweek.AddDays(addingday);
                                            }
                                            //từ ở tuần thứ 2 trở đi là phải áp dụng công thức tính ngày
                                            //( 7-(thứ cuối cùng của tuần đó có lịch dạy -2)) là sẽ ra khoảng cách bắt đầu ngày mới có lịch dạy
                                            else
                                            {
                                                //lấy ra ngày cuối cùng của tuần đầu tiên có lịch dạy để áp dụng vào công thức
                                                //cho ra được ngày bắt đầu của tuần tiếp theo

                                                if (charday == 0)
                                                {

                                                    TeachingSchedule teachingSchedule = new TeachingSchedule()
                                                    {
                                                        Id = Guid.NewGuid(),
                                                        TeachingDay = startdayofnewweek,
                                                        ImportTime = DateTime.Now,
                                                        IdAdminImport = IdUser,
                                                        SubjectId = _lstsubject.Where(c => c.SubjectCode == Convert.ToString(tbl.ToList()[0].Row[i]["Mã Môn"])).Select(c => c.Id).FirstOrDefault(),
                                                        ClassId = _lstClass.Where(c => c.ClassroomName == Convert.ToString(tbl.ToList()[0].Row[i]["Tên Lớp"])).Select(c => c.Id).FirstOrDefault(),
                                                        IdShift = _lstShift.Where(c => c.ShiftName.Contains(tbl.ToList()[0].Row[i]["Ca Dạy"].ToString())).Select(c => c.Id).FirstOrDefault(),
                                                        IdLecturter = _lstLec.Where(c => c.Email.ToLower().Contains(Convert.ToString(tbl.ToList()[0].Row[i]["Mã GV"]).ToLower())).Select(c => c.Id).FirstOrDefault(),
                                                        IndexOfTeachingSchedule = _teachingSchedules.Count() + 1,
                                                        Status = 0,
                                                        Note = Convert.ToString(tbl.ToList()[0].Row[i]["Ghi Chú"]),
                                                        Remote = Convert.ToString(tbl.ToList()[0].Row[i]["Remote"]),
                                                        IdBlock = IdBlock,
                                                        IdSemester = IdSem,
                                                        IdTrainingFacility = Idtrain

                                                    };
                                                    _teachingSchedules.Add(teachingSchedule);

                                                }
                                                else
                                                {

                                                    //trường hợp là có nhiều hơn 2 ngày dạy trong tuần thì lại tiếp tục lấy ngày bắt đầu cộng thêm thứ
                                                    TeachingSchedule teachingSchedule = new TeachingSchedule()
                                                    {
                                                        Id = Guid.NewGuid(),
                                                        TeachingDay = startdayofnewweek.AddDays(Convert.ToInt32(weekday[charday].ToString()) - Convert.ToInt32(weekday[charday - 1].ToString())),
                                                        ImportTime = DateTime.Now,
                                                        IdAdminImport = IdUser,
                                                        SubjectId = _lstsubject.Where(c => c.SubjectCode == Convert.ToString(tbl.ToList()[0].Row[i]["Mã Môn"])).Select(c => c.Id).FirstOrDefault(),
                                                        ClassId = _lstClass.Where(c => c.ClassroomName == Convert.ToString(tbl.ToList()[0].Row[i]["Tên Lớp"])).Select(c => c.Id).FirstOrDefault(),
                                                        IdShift = _lstShift.Where(c => c.ShiftName.Contains(tbl.ToList()[0].Row[i]["Ca Dạy"].ToString())).Select(c => c.Id).FirstOrDefault(),
                                                        IdLecturter = _lstLec.Where(c => c.Email.ToLower().Contains(Convert.ToString(tbl.ToList()[0].Row[i]["Mã GV"]).ToLower())).Select(c => c.Id).FirstOrDefault(),
                                                        IndexOfTeachingSchedule = _teachingSchedules.Count() + 1,
                                                        Status = 0,
                                                        Note = Convert.ToString(tbl.ToList()[0].Row[i]["Ghi Chú"]),
                                                        Remote = Convert.ToString(tbl.ToList()[0].Row[i]["Remote"]),
                                                        IdBlock = IdBlock,
                                                        IdSemester = IdSem,
                                                        IdTrainingFacility = Idtrain

                                                    };
                                                    _teachingSchedules.Add(teachingSchedule);

                                                    var lastindex = _teachingSchedules.FindLastIndex(c => c.ClassId == GetIdClass && c.SubjectId == GetIdSubject);
                                                    if (charday == weekday.Length - 1)
                                                    {
                                                        lastdayoffirstweek = _teachingSchedules.Where(c => c.ClassId == GetIdClass && c.SubjectId == GetIdSubject).Select(c => c.TeachingDay).LastOrDefault();
                                                        startdayofnewweek = lastdayoffirstweek.AddDays(addingday);
                                                    }
                                                    else
                                                    {
                                                        lastdayoffirstweek = _teachingSchedules.Where(c => c.ClassId == GetIdClass && c.SubjectId == GetIdSubject).Select(c => c.TeachingDay).LastOrDefault();
                                                        startdayofnewweek = lastdayoffirstweek;
                                                    }

                                                }

                                            }

                                        }
                                    }




                                    //trường hợp tuần trước cách tuần sau 7 ngày
                                    if (weekday.Length == 1)
                                    {
                                        if (dayincre == 0)
                                        {
                                            TeachingSchedule teachingSchedule = new TeachingSchedule()
                                            {
                                                Id = Guid.NewGuid(),
                                                TeachingDay = GetStartDayOfBlock.AddDays(Convert.ToInt32(tbl.ToList()[0].Row[i]["Thứ"].ToString()) - 2),
                                                ImportTime = DateTime.Now,
                                                IdAdminImport = IdUser,
                                                SubjectId = _lstsubject.Where(c => c.SubjectCode == Convert.ToString(tbl.ToList()[0].Row[i]["Mã Môn"])).Select(c => c.Id).FirstOrDefault(),
                                                ClassId = _lstClass.Where(c => c.ClassroomName == Convert.ToString(tbl.ToList()[0].Row[i]["Tên Lớp"])).Select(c => c.Id).FirstOrDefault(),
                                                IdShift = _lstShift.Where(c => c.ShiftName.Contains(tbl.ToList()[0].Row[i]["Ca Dạy"].ToString())).Select(c => c.Id).FirstOrDefault(),
                                                IdLecturter = _lstLec.Where(c => c.Email.ToLower().Contains(Convert.ToString(tbl.ToList()[0].Row[i]["Mã GV"]).ToLower())).Select(c => c.Id).FirstOrDefault(),
                                                IndexOfTeachingSchedule = _teachingSchedules.Count() + 1,
                                                Status = 0,
                                                Note = Convert.ToString(tbl.ToList()[0].Row[i]["Ghi Chú"]),
                                                Remote = Convert.ToString(tbl.ToList()[0].Row[i]["Remote"]),
                                                IdBlock = IdBlock,
                                                IdSemester = IdSem,
                                                IdTrainingFacility = Idtrain

                                            };

                                            _teachingSchedules.Add(teachingSchedule);
                                            lastdayoffirstweek = _teachingSchedules[_teachingSchedules.Count() - 1].TeachingDay;
                                            startdayofnewweek = lastdayoffirstweek.AddDays(7);
                                        }
                                        else
                                        {
                                            //trường hợp là có nhiều hơn 2 ngày dạy trong tuần thì lại tiếp tục lấy ngày bắt đầu cộng thêm thứ
                                            TeachingSchedule teachingSchedule = new TeachingSchedule()
                                            {
                                                Id = Guid.NewGuid(),
                                                TeachingDay = startdayofnewweek,
                                                ImportTime = DateTime.Now,
                                                IdAdminImport = IdUser,
                                                SubjectId = _lstsubject.Where(c => c.SubjectCode == Convert.ToString(tbl.ToList()[0].Row[i]["Mã Môn"])).Select(c => c.Id).FirstOrDefault(),
                                                ClassId = _lstClass.Where(c => c.ClassroomName == Convert.ToString(tbl.ToList()[0].Row[i]["Tên Lớp"])).Select(c => c.Id).FirstOrDefault(),
                                                IdShift = _lstShift.Where(c => c.ShiftName.Contains(tbl.ToList()[0].Row[i]["Ca Dạy"].ToString())).Select(c => c.Id).FirstOrDefault(),
                                                IdLecturter = _lstLec.Where(c => c.Email.ToLower().Contains(Convert.ToString(tbl.ToList()[0].Row[i]["Mã GV"]).ToLower())).Select(c => c.Id).FirstOrDefault(),
                                                IndexOfTeachingSchedule = _teachingSchedules.Count() + 1,
                                                Status = 0,
                                                Note = Convert.ToString(tbl.ToList()[0].Row[i]["Ghi Chú"]),
                                                Remote = Convert.ToString(tbl.ToList()[0].Row[i]["Remote"]),
                                                IdBlock = IdBlock,
                                                IdSemester = IdSem,
                                                IdTrainingFacility = Idtrain

                                            };
                                            _teachingSchedules.Add(teachingSchedule);

                                            lastdayoffirstweek = _teachingSchedules[_teachingSchedules.Count() - 1].TeachingDay;
                                            startdayofnewweek = lastdayoffirstweek.AddDays(7);

                                        }

                                    }

                                }
                                //đây là tuần cuối cùng phải sét từng thứ trong tuần đấy
                                if (dayincre == sotuannguyen - 1)
                                {
                                    //lấy ra ngày bắt đầu của tuần cuối cùng còn lại
                                    var startneweek = GetStartDayOfBlock.AddDays((sotuannguyen - 1) * 7);
                                    //
                                    //phải xét theo thứ để lấy lịch dạy và có điều kiện lấy ra thứ
                                    //quan trọng nhất là lấy ngày bắt đầu của kì để lấy ra đồng thời ngày dạy để cộng lên
                                    var weekday = tbl.ToList()[0].Row[i]["Thứ"].ToString().ToArray();
                                    var maxleng = weekday.Length;
                                    //lấy ra thức cuối cùng để áp dụng công thức
                                    var lastdayofweek = weekday[weekday.Length - 1].ToString();

                                    //trường hợp khoảng cách ca dạy của tuần trước và tuần sau không phải là 7 ngày

                                    for (int charday = 0; charday < weekday.Length; charday++)
                                    {
                                        if (startneweek.AddDays(Convert.ToInt32(weekday[charday].ToString()) - 2) <= startneweek.AddDays(songaydu))
                                        {
                                            TeachingSchedule teachingSchedule = new TeachingSchedule()
                                            {

                                                Id = Guid.NewGuid(),
                                                TeachingDay = startneweek.AddDays(Convert.ToInt32(weekday[charday].ToString()) - 2),
                                                ImportTime = DateTime.Now,
                                                IdAdminImport = IdUser,
                                                SubjectId = _lstsubject.Where(c => c.SubjectCode == Convert.ToString(tbl.ToList()[0].Row[i]["Mã Môn"])).Select(c => c.Id).FirstOrDefault(),
                                                ClassId = _lstClass.Where(c => c.ClassroomName == Convert.ToString(tbl.ToList()[0].Row[i]["Tên Lớp"])).Select(c => c.Id).FirstOrDefault(),
                                                IdShift = _lstShift.Where(c => c.ShiftName.Contains(tbl.ToList()[0].Row[i]["Ca Dạy"].ToString())).Select(c => c.Id).FirstOrDefault(),
                                                IdLecturter = _lstLec.Where(c => c.Email.ToLower().Contains(Convert.ToString(tbl.ToList()[0].Row[i]["Mã GV"]).ToLower())).Select(c => c.Id).FirstOrDefault(),
                                                IndexOfTeachingSchedule = _teachingSchedules.Count() + 1,
                                                Status = 0,
                                                Note = Convert.ToString(tbl.ToList()[0].Row[i]["Ghi Chú"]),
                                                Remote = Convert.ToString(tbl.ToList()[0].Row[i]["Remote"]),
                                                IdBlock = IdBlock,
                                                IdSemester = IdSem,
                                                IdTrainingFacility = Idtrain

                                            };
                                            _teachingSchedules.Add(teachingSchedule);
                                        }
                                        else
                                        {
                                            break;
                                        }

                                    }

                                }
                            }
                        }


                        _lstSpec = await _ISpecrepository.AsQueryable().ToListAsync();
                    }

                }
            }
            _getFullList = _teachingSchedules;
            _defaultList = _teachingSchedules;
            // await _localStorageService.SetItemAsync("listdefault", _defaultList);
            return _teachingSchedules;
        }
        public async Task<PageForTeachingSchedule<TeachingSchedule>> GetPagingData(TeachinhScheduleSearch pagingParameterForSchedule)
        {
            var chech = _teachingSchedules;
            var _lstSpec = await _ISpecrepository.AsQueryable().ToListAsync();
            var _lstLec = await _httpClient.GetFromJsonAsync<List<LecturersCP>>("/api/LecturersCPs/all");
            List<TeachingSchedule> _lstfake = new List<TeachingSchedule>();
            if (!string.IsNullOrEmpty(pagingParameterForSchedule.Email))
            {

                //lấy ra id tên giảng viên
                var getIdLec = _lstLec.Where(c => c.Email.ToLower().Contains(pagingParameterForSchedule.Email)).Select(c => c.Id).FirstOrDefault();
                var forclass = await _ISubjectClassUPrepository.AsQueryable().ToListAsync();
                foreach (var x in forclass.Where(c => c.HomeroomLecturer == getIdLec))
                {
                    foreach (TeachingSchedule z in _teachingSchedules.Where(z => z.ClassId == x.ClassId && z.SubjectId == x.SubjectId))
                    {
                        _lstfake.Add(z);
                    }
                }
                _teachingSchedules = _lstfake;
            }
            if (pagingParameterForSchedule.specializedUPId.HasValue)
            {

                var forclass = await _ISubjectClassUPrepository.AsQueryable().ToListAsync();
                var cpunter = forclass.Where(c => c.SpecializedOfClass == pagingParameterForSchedule.specializedUPId).Count();
                foreach (var x in forclass.Where(c => c.SpecializedOfClass == pagingParameterForSchedule.specializedUPId))
                {
                    foreach (TeachingSchedule z in _teachingSchedules.Where(z => z.ClassId == x.ClassId && z.SubjectId == x.SubjectId))
                    {
                        _lstfake.Add(z);
                    }
                }
                _teachingSchedules = _lstfake;
            }
            if (pagingParameterForSchedule.SemesterId.HasValue && pagingParameterForSchedule.BlockId.HasValue)
            {
                _teachingSchedules.Where(c => c.IdSemester == pagingParameterForSchedule.SemesterId && c.IdBlock == pagingParameterForSchedule.BlockId).ToList();
            }

            var finaldata = _teachingSchedules.OrderBy(c => c.TeachingDay).Skip((pagingParameterForSchedule.PageNumber - 1) * pagingParameterForSchedule.PageSize)
                .Take(pagingParameterForSchedule.PageSize)
                .ToList();
            return new PageForTeachingSchedule<TeachingSchedule>(finaldata, _teachingSchedules.Count(), pagingParameterForSchedule.PageNumber, pagingParameterForSchedule.PageSize);
        }

        public async Task<bool> AddRangeTeachingSchedules(List<TeachingSchedule> teachingSchedules)
        {

            var res = await _teachingscheduRepo.AddRangeAsync(teachingSchedules);
            await _teachingscheduRepo.SaveChangesAsync();
            if (res.Count() > 0)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRTeachingSchedules", responsemess);
                return true;
            }
            return false;
        }

        public async Task<List<TeachingSchedule>> GetFullListTeachingSchedules()
        {


            return _getFullList;
        }

        public async Task<List<TeachingSchedule>> GetDefault()
        {
            return _defaultList = _teachingSchedules;
        }

        public async Task<PageForTeachingSchedule<TeachingSchedule>> AddNewTeachingSchedules(TeachingSchedule teachingSchedule)
        {
            // _getFullList.Add(teachingSchedule);
            _teachingSchedules.Add(teachingSchedule);

            var responsemess = "Done";
            await _hubContext.Clients.All.SendAsync("SignalRTeachingSchedules", responsemess);

            var finaldata = _teachingSchedules.OrderBy(c => c.TeachingDay).Skip(0).Take(100)
               .ToList();
            return new PageForTeachingSchedule<TeachingSchedule>(finaldata, _teachingSchedules.Count(), 1, 100);
        }
        public async Task<bool> AddTeachingSchedules(TeachingSchedule teachingSchedule)
        {
            //var res = await _httpClient.PostAsJsonAsync("/api/TeachingSchedules/adding-teaching", teachingSchedule);
            var res = await _teachingscheduRepo.AddAsync(teachingSchedule);
            await _teachingscheduRepo.SaveChangesAsync();
            var result = false;
            if (res.Id == teachingSchedule.Id)
            {

                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRTeachingSchedules", responsemess);
                
                result = true;
            }

            return result;


        }
        public async Task<bool> UpdateTeachingSchedules(TeachingSchedule teachingSchedule)
        {

            var result = false;
            if (teachingSchedule == null)
            {
                return result;
            }
            else
            {
                var res = await _teachingscheduRepo.UpdateAsync(teachingSchedule);
                await _teachingscheduRepo.SaveChangesAsync();

                if (res.Id == teachingSchedule.Id)
                {
                    var responsemess = "Done";
                    await _hubContext.Clients.All.SendAsync("SignalRTeachingSchedules", responsemess);

                    result = true;
                }
            }

            return result;
        }
        public async Task<TeachingSchedule> GetTeachingScheduleById(Guid Id)
        {
            var result = await _httpClient.GetFromJsonAsync<TeachingSchedule>($"/api/TeachingSchedules/getting-teaching/{Id}");
            return result;
        }

        public async Task<bool> DeteleTeachingSchedules(Guid Id)
        {

            var result = false;
            var listcheck = await _teachingscheduRepo.AsQueryable().ToListAsync();
            if (listcheck.Any(c => c.Id == Id) == false)
            {
                return result;
            }
            else
            {
                foreach (var x in listcheck.Where(c => c.Id == Id))
                {
                    x.Status = 1;
                    await _teachingscheduRepo.UpdateAsync(x);
                    await _teachingscheduRepo.SaveChangesAsync();
                }
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRTeachingSchedules", responsemess);
                return result = true;
            }

        }

        public async Task<PageForTeachingSchedule<TeachingSchedule>> GetAllTeachingSchedules(Guid idblock, Guid idsem, Guid idtrain, TeachinhScheduleSearch pagingParameterForSchedule)
        {
            var ListFormDatabase =  _teachingscheduRepo.AsQueryable().ToList();
            ListFormDatabase = ListFormDatabase.Where(c => c.Status != 1 && c.IdBlock == idblock && c.IdSemester == idsem && c.IdTrainingFacility == idtrain).ToList();
            var _lstSpec = await _ISpecrepository.AsQueryable().ToListAsync();
            var _lstLec = await _httpClient.GetFromJsonAsync<List<LecturersCP>>("/api/LecturersCPs/all");
            List<TeachingSchedule> _lstfake = new List<TeachingSchedule>();
            if (!string.IsNullOrEmpty(pagingParameterForSchedule.Email))
            {

                //lấy ra id tên giảng viên
                var getIdLec = _lstLec.Where(c => c.Email.ToLower().Contains(pagingParameterForSchedule.Email)).Select(c => c.Id).FirstOrDefault();

                ListFormDatabase = ListFormDatabase.Where(c => c.IdLecturter == getIdLec).ToList();
            }
            if (pagingParameterForSchedule.specializedUPId.HasValue)
            {

                var forclass = await _ISubjectClassUPrepository.AsQueryable().ToListAsync();
                var cpunter = forclass.Where(c => c.SpecializedOfClass == pagingParameterForSchedule.specializedUPId).Count();
                foreach (var x in forclass.Where(c => c.SpecializedOfClass == pagingParameterForSchedule.specializedUPId))
                {
                    foreach (TeachingSchedule z in ListFormDatabase.Where(z => z.ClassId == x.ClassId && z.SubjectId == x.SubjectId))
                    {
                        _lstfake.Add(z);
                    }
                }
                ListFormDatabase = _lstfake;
            }
            if (pagingParameterForSchedule.SemesterId.HasValue && pagingParameterForSchedule.BlockId.HasValue)
            {
                ListFormDatabase.Where(c => c.IdSemester == pagingParameterForSchedule.SemesterId && c.IdBlock == pagingParameterForSchedule.BlockId).ToList();
            }
            if (!string.IsNullOrEmpty(pagingParameterForSchedule.Email))
            {
                var email =  _lstLec.Where(x=>x.Email.Replace("@fpt.edu.vn","").Contains(pagingParameterForSchedule.Email)).ToList();
                
                if (!string.IsNullOrEmpty(email.ToString()))
                {
                    foreach (var item in email)
                    {
                        ListFormDatabase.Where(c => c.IdLecturter == item.Id).ToList();
                    }
                   
            }
            }
            

            var finaldata = ListFormDatabase.OrderBy(c => c.TeachingDay).Skip((pagingParameterForSchedule.PageNumber - 1) * pagingParameterForSchedule.PageSize)
                .Take(pagingParameterForSchedule.PageSize)
                .ToList();
            return new PageForTeachingSchedule<TeachingSchedule>(finaldata, ListFormDatabase.Count(), pagingParameterForSchedule.PageNumber, pagingParameterForSchedule.PageSize);
        }

        public async Task<List<TeachingSchedule>> GetListTeachingFormDatabase(Guid idblock, Guid idsem, Guid idtrain)
        {


            _lstTeachingFormDatabase = await _teachingscheduRepo.AsQueryable().Where(c => c.Status != 1 && c.IdBlock == idblock && c.IdSemester == idsem && c.IdTrainingFacility == idtrain).ToListAsync();

            return _lstTeachingFormDatabase;
        }
    }
}


