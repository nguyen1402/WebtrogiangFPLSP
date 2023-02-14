using AutoMapper;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.Services.Interfaces.Cabin;
using FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject;
using FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements.FPLExam
{
    public class ExaminationRoomDetailServices : IExaminationRoomDetailServices
    {


        private readonly IRepository<ExaminationRoomDetail> _examroomdetailRepo;
        private readonly IRepository<UserSignIn> _UserSignInRepo;
        private IMapper _mapper;
        private readonly IOnlineExamRoomServices _onlineExamRoomServices;
        private readonly UserManager<UserSignIn> _userManager;

        private readonly ISupervisorExamRoomServices _supervisorExamRoomServices;
        private readonly IBlockServices _blockServices;
        private readonly ISemesterServices _semesterServices;
        private readonly IExaminationRoomServices _examinationRoomServices;
        private readonly IExamFileServices _examFileServices;
        private readonly ILecturersCPServices _lecturersCPServices;
        //
        private readonly ISubjectUPServices _subjectUPServices;
        private Random random = new Random();

        public ExaminationRoomDetailServices(IRepository<ExaminationRoomDetail> examroomdetailRepo, IRepository<UserSignIn> userSignInRepo, IMapper mapper, IOnlineExamRoomServices onlineExamRoomServices, UserManager<UserSignIn> userManager, ISupervisorExamRoomServices supervisorExamRoomServices, IBlockServices blockServices, ISemesterServices semesterServices, IExaminationRoomServices examinationRoomServices, IExamFileServices examFileServices, ILecturersCPServices lecturersCPServices, ISubjectUPServices subjectUPServices)
        {
            _examroomdetailRepo = examroomdetailRepo;
            _UserSignInRepo = userSignInRepo;
            _mapper = mapper;
            _onlineExamRoomServices = onlineExamRoomServices;
            _userManager = userManager;
            _supervisorExamRoomServices = supervisorExamRoomServices;
            _blockServices = blockServices;
            _semesterServices = semesterServices;
            _examinationRoomServices = examinationRoomServices;
            _examFileServices = examFileServices;
            _lecturersCPServices = lecturersCPServices;
            _subjectUPServices = subjectUPServices;
        }

        public async Task<List<LecturersCP>> GetAllLectureAddExam()
        {
            var listlectuter = await _lecturersCPServices.GetAllLecturerAsync();
            var lstUserSignInByRole = await _userManager.GetUsersInRoleAsync("GV FPLExam");

            var lstIdUserSingin = lstUserSignInByRole.Select(c => c.Id).ToList();
            listlectuter = listlectuter.Where(c => lstIdUserSingin.Contains(c.Id.ToString())).ToList();
            // Cac de thi cung ca

            return listlectuter;
        }
        public async Task<List<ExaminationRoomDetail>> GetAllExaminationRoomDetail()
        {
            var res = await _examroomdetailRepo.AsQueryable().Where(c => c.Status != 1 && c.Status != 2).ToListAsync();
            return res;
        }
        public async Task<PageList<ExaminationRoomDetailViewModel>> GetALlOfficialExaminationroom(ExamRoomDetailSearch examRoomDetailSearch)
        {
            var LstExaminationRoomDetail = await _examroomdetailRepo.AsQueryable().Where(c => c.Status != 1 && c.Status != 2).ToListAsync();

            var listStudentRoom = await _onlineExamRoomServices.GetAllOnlineExamRoom();//2
            var listSupervisor = await _supervisorExamRoomServices.GetAllSupervisorExamRoom();//3

            var listroom = await _examinationRoomServices.GetAllExamRoom();
            //
            var listsem = await _semesterServices.GetAll();
            var listBlock = await _blockServices.GetAll();
            var listSubject = await _subjectUPServices.GetAllSubjectAsync();
            var listExamfiles = await _examFileServices.GetAllExamFiles();
            var listlectuter = await _lecturersCPServices.GetAllLecturerAsync();

            var joinerlist = (from a in LstExaminationRoomDetail
                              join b in listroom on a.IdExaminationRoom equals b.Id

                              join d in listBlock on a.IdBlock equals d.Id
                              join e in listsem on a.IdSemester equals e.Id
                              select new ExaminationRoomDetailViewModel()
                              {
                                  IdExaminationRoom = a.IdExaminationRoom,
                                  EndTime = a.EndTime,
                                  StartTime = a.StartTime,
                                  SecretKey = a.SecretKey,
                                  IndexOfExaminationRoomDetail = a.IndexOfExaminationRoomDetail,
                                  Status = a.Status,
                                  IdExamFile = a.IdExamFile,
                                  Note = a.Note,
                                  ExamFileName = listExamfiles.Where(c => c.Id == a.IdExamFile).Select(c => c.FileName).FirstOrDefault(),
                                  IdSubject = a.IdSubject,
                                  SubjectName = listSubject.FirstOrDefault(k => k.Id == a.IdSubject).SubjectName,
                                  IdBlock = a.IdBlock,
                                  TotalTimeOfExam = a.TotalTimeOfExam,
                                  IdSemester = a.IdSemester,
                                  ExaminationRoomName = b.ExaminationRoomName,
                                  SemesterName = e.NameofSemester,
                                  BlockName = d.NameOfBlock,
                                  ListSupervisorID = listSupervisor.Where(x => x.SecretKey == a.SecretKey).Select(c => c.IdLecturter).ToList(),
                                  ListStudentId = listStudentRoom.Where(z => z.SecretKey == a.SecretKey).Select(c => c.IdUser).ToList(),
                              }
                              ).ToList();
            if (examRoomDetailSearch.StartTime.HasValue)
            {
                joinerlist = joinerlist.Where(c => c.StartTime == examRoomDetailSearch.StartTime).ToList();
            }
            if (examRoomDetailSearch.EndTime.HasValue)
            {
                joinerlist = joinerlist.Where(c => c.EndTime == examRoomDetailSearch.EndTime).ToList();
            }
            if (examRoomDetailSearch.IdBlock.HasValue && examRoomDetailSearch.IdSemester.HasValue)
            {
                joinerlist = joinerlist.Where(c => c.IdBlock == examRoomDetailSearch.IdBlock && c.IdSemester == examRoomDetailSearch.IdSemester).ToList();
            }
            if (string.IsNullOrEmpty(examRoomDetailSearch.ExamRoomDetailName))
            {
                joinerlist = joinerlist.Where(c => c.ExaminationRoomName.ToLower().Contains(examRoomDetailSearch.ExamRoomDetailName.ToLower())).ToList();
            }
            if (examRoomDetailSearch.IdSubJect.HasValue)
            {
                joinerlist = joinerlist.Where(c => c.IdSubject == examRoomDetailSearch.IdSubJect).ToList();

            }
            if (!string.IsNullOrEmpty(examRoomDetailSearch.SupervisorName))
            {
                var getIdLect = listlectuter.Where(c => c.LecturersName.ToLower().Contains(examRoomDetailSearch.SupervisorName.ToLower()) || c.LecturersCode.ToLower().Contains(examRoomDetailSearch.SupervisorName.ToLower())).Select(c => c.Id).FirstOrDefault();
                joinerlist = joinerlist.Where(c => c.ListSupervisorID.Any(l => l == getIdLect)).ToList();
            }
            var data = joinerlist.Skip((examRoomDetailSearch.PageNumber - 1) * examRoomDetailSearch.PageSize).Take(examRoomDetailSearch.PageSize).ToList();
            return new PageList<ExaminationRoomDetailViewModel>(data, joinerlist.Count(), examRoomDetailSearch.PageNumber, examRoomDetailSearch.PageSize);
        }

        public async Task<ExaminationRoomDetailViewModel> GetExaminamRoomDetailBySecret(string SercretKey)
        {
            var LstExaminationRoomDetail = await _examroomdetailRepo.AsQueryable().Where(c => c.Status != 1 && c.Status != 2).ToListAsync();

            var listStudentRoom = await _onlineExamRoomServices.GetAllOnlineExamRoom();//2
            var listSupervisor = await _supervisorExamRoomServices.GetAllSupervisorExamRoom();//3

            var listroom = await _examinationRoomServices.GetAllExamRoom();
            //
            var listsem = await _semesterServices.GetAll();
            var listBlock = await _blockServices.GetAll();
            var listSubject = await _subjectUPServices.GetAllSubjectAsync();
            var listExamfiles = await _examFileServices.GetAllExamFiles();
            var listlectuter = await _lecturersCPServices.GetAllLecturerAsync();

            var joinerlist = (from a in LstExaminationRoomDetail.Where(c => c.SecretKey == SercretKey)
                              join b in listroom on a.IdExaminationRoom equals b.Id

                              join d in listBlock on a.IdBlock equals d.Id
                              join e in listsem on a.IdSemester equals e.Id
                              select new ExaminationRoomDetailViewModel()
                              {
                                  IdExaminationRoom = a.IdExaminationRoom,
                                  EndTime = a.EndTime,
                                  StartTime = a.StartTime,
                                  SecretKey = a.SecretKey,
                                  IndexOfExaminationRoomDetail = a.IndexOfExaminationRoomDetail,
                                  Status = a.Status,
                                  Note = a.Note,
                                  IdExamFile = a.IdExamFile,
                                  IdSubject = a.IdSubject,
                                  ExamFileName = listExamfiles.Where(c => c.Id == a.IdExamFile).Select(c => c.FileName).FirstOrDefault(),
                                  SubjectName = listSubject.FirstOrDefault(k => k.Id == a.IdSubject).SubjectName,
                                  IdBlock = a.IdBlock,
                                  TotalTimeOfExam = a.TotalTimeOfExam,
                                  IdSemester = a.IdSemester,
                                  ExaminationRoomName = b.ExaminationRoomName,
                                  SemesterName = e.NameofSemester,
                                  BlockName = d.NameOfBlock,
                                  ListSupervisorID = listSupervisor.Where(x => x.SecretKey == a.SecretKey).Select(c => c.IdLecturter).ToList(),
                                  ListStudentId = listStudentRoom.Where(z => z.SecretKey == a.SecretKey).Select(c => c.IdUser).ToList(),
                              }
                              ).ToList().FirstOrDefault();


            return joinerlist;
        }
        //dành cho giảng viên
        public async Task<List<ExaminationRoomDetailViewModel>> GetALlOfficialForSupervisor(Guid IdSuper)
        {
            var LstExaminationRoomDetail = await _examroomdetailRepo.AsQueryable().Where(c => c.Status != 1 && c.Status != 2).ToListAsync();

            var listStudentRoom = await _onlineExamRoomServices.GetAllOnlineExamRoom();//2
            var listSupervisor = await _supervisorExamRoomServices.GetAllSupervisorExamRoom();//3

            var listroom = await _examinationRoomServices.GetAllExamRoom();
            //
            var listsem = await _semesterServices.GetAll();
            var listBlock = await _blockServices.GetAll();
            var listSubject = await _subjectUPServices.GetAllSubjectAsync();
            var listExamfiles = await _examFileServices.GetAllExamFiles();
            var listlectuter = await _lecturersCPServices.GetAllLecturerAsync();

            var joinerlist = (from a in LstExaminationRoomDetail
                              join b in listroom on a.IdExaminationRoom equals b.Id

                              join d in listBlock on a.IdBlock equals d.Id
                              join e in listsem on a.IdSemester equals e.Id
                              select new ExaminationRoomDetailViewModel()
                              {
                                  IdExaminationRoom = a.IdExaminationRoom,
                                  EndTime = a.EndTime,
                                  StartTime = a.StartTime,
                                  SecretKey = a.SecretKey,
                                  IndexOfExaminationRoomDetail = a.IndexOfExaminationRoomDetail,
                                  Status = a.Status,
                                  Note = a.Note,
                                  IdExamFile = a.IdExamFile,
                                  IdSubject = a.IdSubject,
                                  SubjectName = listSubject.FirstOrDefault(k => k.Id == a.IdSubject).SubjectName,
                                  IdBlock = a.IdBlock,
                                  TotalTimeOfExam = a.TotalTimeOfExam,
                                  ExamFileName = listExamfiles.Where(c => c.Id == a.IdExamFile).Select(c => c.FileName).FirstOrDefault(),
                                  IdSemester = a.IdSemester,
                                  ExaminationRoomName = b.ExaminationRoomName,
                                  SemesterName = e.NameofSemester,
                                  BlockName = d.NameOfBlock,
                                  ListSupervisorID = listSupervisor.Where(x => x.SecretKey == a.SecretKey).Select(c => c.IdLecturter).ToList(),
                                  ListStudentId = listStudentRoom.Where(z => z.SecretKey == a.SecretKey).Select(c => c.IdUser).ToList(),

                              }
                              ).ToList();

            joinerlist = joinerlist.Where(lone => lone.ListSupervisorID.Any(c => c == IdSuper)).ToList();
            return joinerlist;
        }

        public async Task<List<ExaminationRoomDetailViewModel>> GetALlOfficialForStudent(Guid IdStu)
        {
            var LstExaminationRoomDetail = await _examroomdetailRepo.AsQueryable().Where(c => c.Status != 1 && c.Status != 2).ToListAsync();

            var listStudentRoom = await _onlineExamRoomServices.GetAllOnlineExamRoom();//2
            var listSupervisor = await _supervisorExamRoomServices.GetAllSupervisorExamRoom();//3

            var listroom = await _examinationRoomServices.GetAllExamRoom();
            //
            var listsem = await _semesterServices.GetAll();
            var listBlock = await _blockServices.GetAll();
            var listSubject = await _subjectUPServices.GetAllSubjectAsync();
            var listExamfiles = await _examFileServices.GetAllExamFiles();
            var listlectuter = await _lecturersCPServices.GetAllLecturerAsync();

            var joinerlist = (from a in LstExaminationRoomDetail
                              join b in listroom on a.IdExaminationRoom equals b.Id

                              join d in listBlock on a.IdBlock equals d.Id
                              join e in listsem on a.IdSemester equals e.Id
                              select new ExaminationRoomDetailViewModel()
                              {
                                  IdExaminationRoom = a.IdExaminationRoom,
                                  EndTime = a.EndTime,
                                  StartTime = a.StartTime,
                                  SecretKey = a.SecretKey,
                                  ExamFileName = listExamfiles.Where(c => c.Id == a.IdExamFile).Select(c => c.FileName).FirstOrDefault(),
                                  IndexOfExaminationRoomDetail = a.IndexOfExaminationRoomDetail,
                                  Status = a.Status,
                                  Note = a.Note,
                                  IdExamFile = a.IdExamFile,
                                  IdSubject = a.IdSubject,
                                  SubjectName = listSubject.FirstOrDefault(k => k.Id == a.IdSubject).SubjectName,
                                  IdBlock = a.IdBlock,
                                  TotalTimeOfExam = a.TotalTimeOfExam,
                                  IdSemester = a.IdSemester,
                                  ExaminationRoomName = b.ExaminationRoomName,
                                  SemesterName = e.NameofSemester,
                                  BlockName = d.NameOfBlock,
                                  ListSupervisorID = listSupervisor.Where(x => x.SecretKey == a.SecretKey).Select(c => c.IdLecturter).ToList(),
                                  ListStudentId = listStudentRoom.Where(z => z.SecretKey == a.SecretKey).Select(c => c.IdUser).ToList(),
                              }
                              ).ToList();

            joinerlist = joinerlist.Where(lone => lone.ListStudentId.Any(c => c == IdStu.ToString())).ToList();
            return joinerlist;
        }

        public async Task<List<ExaminationRoomDetailViewModel>> GetExamFileForSubject(Guid IdSubject)
        {
            var LstExaminationRoomDetail = await _examroomdetailRepo.AsQueryable().Where(c => c.Status != 1 && c.Status != 2).ToListAsync();

            var listStudentRoom = await _onlineExamRoomServices.GetAllOnlineExamRoom();//2
            var listSupervisor = await _supervisorExamRoomServices.GetAllSupervisorExamRoom();//3

            var listroom = await _examinationRoomServices.GetAllExamRoom();
            //
            var listsem = await _semesterServices.GetAll();
            var listBlock = await _blockServices.GetAll();
            var listSubject = await _subjectUPServices.GetAllSubjectAsync();
            var listExamfiles = await _examFileServices.GetAllExamFiles();
            var listlectuter = await _lecturersCPServices.GetAllLecturerAsync();

            var joinerlist = (from a in LstExaminationRoomDetail
                              join b in listroom on a.IdExaminationRoom equals b.Id

                              join d in listBlock on a.IdBlock equals d.Id
                              join e in listsem on a.IdSemester equals e.Id
                              select new ExaminationRoomDetailViewModel()
                              {
                                  IdExaminationRoom = a.IdExaminationRoom,
                                  EndTime = a.EndTime,
                                  StartTime = a.StartTime,
                                  SecretKey = a.SecretKey,
                                  IndexOfExaminationRoomDetail = a.IndexOfExaminationRoomDetail,
                                  Status = a.Status,
                                  Note = a.Note,
                                  IdExamFile = a.IdExamFile,
                                  IdSubject = a.IdSubject,
                                  ExamFileName = listExamfiles.Where(c => c.Id == a.IdExamFile).Select(c => c.FileName).FirstOrDefault(),
                                  SubjectName = listSubject.FirstOrDefault(k => k.Id == a.IdSubject).SubjectName,
                                  IdBlock = a.IdBlock,
                                  TotalTimeOfExam = a.TotalTimeOfExam,
                                  IdSemester = a.IdSemester,
                                  ExaminationRoomName = b.ExaminationRoomName,
                                  SemesterName = e.NameofSemester,
                                  BlockName = d.NameOfBlock,
                                  ListSupervisorID = listSupervisor.Where(x => x.SecretKey == a.SecretKey).Select(c => c.IdLecturter).ToList(),
                                  ListStudentId = listStudentRoom.Where(z => z.SecretKey == a.SecretKey).Select(c => c.IdUser).ToList(),
                              }
                              ).ToList();

            joinerlist = joinerlist.Where(lone => lone.IdSubject == IdSubject).ToList();
            return joinerlist;
        }


        public async Task<bool> AddingRangeExamRoomDtail(ExamDetaiRoomForAdding examDetaiRoomForAdding)
        {
            var LstExaminationRoomDetail = await _examroomdetailRepo.AsQueryable().Where(c => c.Status != 1 && c.Status != 2).ToListAsync();
            var listExamfiles = await _examFileServices.GetAllExamFiles();

            // var listSupervisor = await _supervisorExamRoomServices.GetAllSupervisorExamRoom();//3


            //

            if (examDetaiRoomForAdding == null)
            {
                return false;
            }
            foreach (var x in examDetaiRoomForAdding.keyValueAdding)
            {
                //step by step tạo chi tiết phòng trước để lấy key
                ExaminationRoomDetail examinationRoomDetail = new ExaminationRoomDetail()
                {


                    StartTime = Convert.ToDateTime(x.StartTime),
                    EndTime = Convert.ToDateTime(x.EndTime),
                    IdSubject = examDetaiRoomForAdding.IdSubject,
                    TotalTimeOfExam = x.TotalTimeOfExam,
                    IdExaminationRoom = examDetaiRoomForAdding.IdExaminationRoom,
                    SecretKey = x.SecretKey,
                    IdExamFile = x.IdExamFile,
                    IndexOfExaminationRoomDetail = 1,
                    Status = x.Status,
                    Note = x.Note,
                    IdBlock = examDetaiRoomForAdding.IdBlock,
                    IdSemester = examDetaiRoomForAdding.IdSemester
                    //

                };
                var ressss = await _examroomdetailRepo.AddAsync(examinationRoomDetail);
                var hahaha = await _examroomdetailRepo.SaveChangesAsync();
                //tiếp đến là add sinh viên vào phòng thi


                //thêm danh sách giám thị vào nếu có
                //if (x.ListSupervisorID.Count > 0)
                //{
                //    foreach (var sup in x.ListSupervisorID)
                //    {
                //        SupervisorExamRoom supervisorExamRoom = new SupervisorExamRoom()
                //        {
                //            IdLecturter = sup,
                //            SecretKey = x.SecretKey,
                //            IdExaminationRoom = examDetaiRoomForAdding.IdExaminationRoom,
                //            Status = 0,
                //            Note = listSupervisor.Where(c => c.SecretKey == x.SecretKey && c.IdExaminationRoom == examDetaiRoomForAdding.IdExaminationRoom).Count() == 0 ? "Giám Thị 1" : "Giám Thị 2",
                //            IsMainSupervisor = listSupervisor.Where(c => c.SecretKey == x.SecretKey && c.IdExaminationRoom == examDetaiRoomForAdding.IdExaminationRoom).Count() == 0 ? true : false
                //        };
                //        var res = await _supervisorExamRoomServices.AddingSupervisorExamRoom(supervisorExamRoom);
                //        if (res == false) return false;

                //    }
                //}





            }
            return true;
        }

        public async Task<bool> UpdatingExamRoomDtail(ExaminationRoomDetailViewModel examinationRoomDetailView)
        {
            //đầu tiên là sett null

            var LstExaminationRoomDetail = await _examroomdetailRepo.AsQueryable().Where(c => c.Status != 1 && c.Status != 2).ToListAsync();
            foreach (var x in LstExaminationRoomDetail.Where(c => c.IdExaminationRoom == examinationRoomDetailView.IdExaminationRoom && c.SecretKey == examinationRoomDetailView.SecretKey))
            {
                x.StartTime = Convert.ToDateTime(examinationRoomDetailView.StartTime);
                x.EndTime = Convert.ToDateTime(examinationRoomDetailView.EndTime);
                x.TotalTimeOfExam = examinationRoomDetailView.TotalTimeOfExam;
                x.Status = examinationRoomDetailView.Status;
                await _examroomdetailRepo.UpdateAsync(x);
                await _examroomdetailRepo.SaveChangesAsync();
            }



            return true;
        }





        public async Task<bool> DeletingExamRoomDtail(ExaminationRoomDetailViewModel examinationRoomDetailView)
        {
            var LstExaminationRoomDetail = await _examroomdetailRepo.AsQueryable().Where(c => c.Status != 1 && c.Status != 2).ToListAsync();
            var examinationRoomDetail = LstExaminationRoomDetail.Find(c => c.SecretKey == examinationRoomDetailView.SecretKey && c.IdExaminationRoom == examinationRoomDetailView.IdExaminationRoom);

            if (examinationRoomDetail == null)
            {
                return false;
            }
            //trước hết là xóa sinh viên đi trước

            examinationRoomDetail.Status = 1;
            await _examroomdetailRepo.UpdateAsync(examinationRoomDetail);
            await _examroomdetailRepo.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AutoHideExamRoomDtail(ExaminationRoomDetailViewModel examinationRoomDetailView)
        {
            var LstExaminationRoomDetail = await _examroomdetailRepo.AsQueryable().Where(c => c.Status != 1 && c.Status != 2).ToListAsync();
            var examinationRoomDetail = LstExaminationRoomDetail.Find(c => c.SecretKey == examinationRoomDetailView.SecretKey && c.IdExaminationRoom == examinationRoomDetailView.IdExaminationRoom);

            if (examinationRoomDetail == null)
            {
                return false;
            }
            examinationRoomDetail.Status = 2;
            examinationRoomDetail.Note = "Phòng thi đã hết hạn";
            await _examroomdetailRepo.UpdateAsync(examinationRoomDetail);
            await _examroomdetailRepo.SaveChangesAsync();
            return true;
        }
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public async Task<byte[]> GetExamFileBySerceate(string Secret)
        {
            var listExamfiles = await _examFileServices.GetAllExamFiles();
            var LstExaminationRoomDetail = await _examroomdetailRepo.AsQueryable().Where(c => c.Status != 1 && c.Status != 2 && c.SecretKey == Secret).ToListAsync();
            var res = listExamfiles.Where(c => c.Id == LstExaminationRoomDetail.FirstOrDefault().IdExamFile).Select(c => c.ExamFile).FirstOrDefault();
            return res;
        }
    }
}
