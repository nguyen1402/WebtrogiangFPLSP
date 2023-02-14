using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements.FPLExam
{
    public class OnlineExamRoomServices : IOnlineExamRoomServices
    {
        private readonly IRepository<OnlineExamRoom> _onLineroomRepo;
        private readonly UserManager<UserSignIn> _userManager;
        private readonly ISubjectUPServices _subjectUPServices;
        private readonly IRepository<ExaminationRoomDetail> _examroomdetailRepo;
        public OnlineExamRoomServices(IRepository<OnlineExamRoom> onLineroomRepo, ISubjectUPServices subjectUPServices, IRepository<ExaminationRoomDetail> examroomdetailRepo, UserManager<UserSignIn> userManager)
        {
            _onLineroomRepo = onLineroomRepo;
            _userManager = userManager;
            _subjectUPServices = subjectUPServices;
            _examroomdetailRepo = examroomdetailRepo;
        }
        public async Task<List<OnlineExamRoom>> GetAllOnlineExamRoom()
        {
            var res = await _onLineroomRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            return res;
        }
        public async Task<bool> AddOnlineExamRoom(OnlineExamViewModel onlineExamRoom)
        {
            if (onlineExamRoom == null)
            {
                return false;
            }
            OnlineExamRoom onlineExam = new OnlineExamRoom()
            {
                IdUser = onlineExamRoom.IdUser,
                SecretKey = onlineExamRoom.SecretKey,
                IdExaminationRoom = onlineExamRoom.IdExaminationRoom,
                JoinTime = onlineExamRoom.JoinTime,
                StartTime = onlineExamRoom.StartTime,
                CountTurnJoin = onlineExamRoom.CountTurnJoin,
                ChekinImage = onlineExamRoom.ChekinImage,
                EndTime = onlineExamRoom.EndTime,
                IsHandlerRequest = onlineExamRoom.IsHandlerRequest,
                LeaveTime = onlineExamRoom.LeaveTime,
                Status = onlineExamRoom.Status,
                IndexOfStudent = 1,
                Note = onlineExamRoom.Note,
                IsCompletedExam = onlineExamRoom.IsCompletedExam,
                IsViewExamFile = onlineExamRoom.IsViewExamFile,
            };
            await _onLineroomRepo.AddAsync(onlineExam);
            await _onLineroomRepo.SaveChangesAsync();
            return true;
        }

        public async Task<List<OnlineExamHasImageViewModel>> GetOnlineExamRoomById(string Secret)
        {

            var res = await _onLineroomRepo.AsQueryable().Where(c => c.Status != 1 && c.SecretKey == Secret).ToListAsync();
            var userlist = _userManager.Users.ToList();
            var jojnerlist = (from a in res
                              join b in userlist on a.IdUser equals b.Id
                              select new OnlineExamHasImageViewModel
                              {
                                  IdUser = a.IdUser,
                                  SecretKey = a.SecretKey,
                                  IdExaminationRoom = a.IdExaminationRoom,
                                  JoinTime = a.JoinTime,
                                  StartTime = a.StartTime,
                                  CountTurnJoin = a.CountTurnJoin,
                                  ChekinImage = a.ChekinImage,
                                  EndTime = a.EndTime,
                                  IsHandlerRequest = a.IsHandlerRequest,
                                  LeaveTime = a.LeaveTime,
                                  Status = a.Status,
                                  IndexOfStudent = 1,
                                  Note = a.Note,
                                  IsCompletedExam = a.IsCompletedExam,
                                  IsViewExamFile = a.IsViewExamFile,
                                  ImageUser = "",
                                  Email = b.Email,
                                  StudentCode = ""
                              }).ToList();

            return jojnerlist;
        }


        public async Task<bool> AddRangeOnlineExamRoom(List<OnlineExamRoom> onlineExamRoom)
        {
            if (onlineExamRoom == null || onlineExamRoom.Count() == 0)
            {
                return false;
            }
            var res = await _onLineroomRepo.AddRangeAsync(onlineExamRoom);
            await _onLineroomRepo.SaveChangesAsync();
            if (res.Count() != onlineExamRoom.Count())
            {
                return false;
            }
            return true;
        }
        public async Task<OnlineExamRoom> getScretKeyLastestForUser(string IdUser)
        {
            var res = await _onLineroomRepo.AsQueryable().Where(c => c.Status != 1 && c.Status != 2).ToListAsync();
            var secretforuser = res.Where(c => c.IdUser == IdUser).OrderByDescending(c => c.JoinTime).FirstOrDefault();
            if (secretforuser != null)
            {
                return secretforuser;
            }
            else
            {
                OnlineExamRoom onlineExamRoom = new OnlineExamRoom();
                return onlineExamRoom;
            }

        }
        public async Task<bool> DeleteOnlineExamRoom(string ScreateKey, string IdUser)
        {
            var res = await _onLineroomRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            if (string.IsNullOrEmpty(ScreateKey) || string.IsNullOrEmpty(IdUser))
            {
                return false;
            }
            foreach (var x in res.Where(c => c.IdUser == IdUser && c.SecretKey == ScreateKey))
            {

                await _onLineroomRepo.RemoveAsync(x);
                await _onLineroomRepo.SaveChangesAsync();
            }
            return true;
        }
        public async Task<bool> FastUpdateTurn(string ScreateKey, string IdUser)
        {
            if (String.IsNullOrEmpty(IdUser) || String.IsNullOrEmpty(ScreateKey))
            {
                return false;
            }
            var res = await _onLineroomRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            foreach (var x in res.Where(c => c.IdUser == IdUser && c.SecretKey == ScreateKey))
            {
                //trạng thái bằng 4 tức là sinh viên chưa được accecept vào phòng
                x.CountTurnJoin = x.CountTurnJoin + 1;
                x.Status = 4;
                x.IsHandlerRequest = false;
                await _onLineroomRepo.UpdateAsync(x);
                await _onLineroomRepo.SaveChangesAsync();
            }
            return true;
        }

        public async Task<bool> FastChangingStatus(string ScreateKey, string IdUser)
        {
            if (String.IsNullOrEmpty(IdUser) || String.IsNullOrEmpty(ScreateKey))
            {
                return false;
            }
            var res = await _onLineroomRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            foreach (var x in res.Where(c => c.IdUser == IdUser && c.SecretKey == ScreateKey))
            {
                x.Status = 0;
                x.IsHandlerRequest = true;
                await _onLineroomRepo.UpdateAsync(x);
                await _onLineroomRepo.SaveChangesAsync();
            }
            return true;
        }
        public async Task<bool> ReOpenExamFileForUser(string ScreateKey, string IdUser)
        {
            var res = await _onLineroomRepo.AsQueryable().Where(c => c.Status != 1 && c.IdUser == IdUser && c.SecretKey == ScreateKey).ToListAsync();
            if (res.Any(c => c.SecretKey == ScreateKey && c.IdUser == IdUser) == false)
            {
                return false;
            }
            foreach (var x in res)
            {
                x.IsViewExamFile = true;
                await _onLineroomRepo.UpdateAsync(x);
                await _onLineroomRepo.SaveChangesAsync();
            }
            return true;
        }








        public async Task<int> getTurnById(string ScreateKey, string IdUser)
        {
            var res = await _onLineroomRepo.AsQueryable().Where(c => c.Status != 1 && c.IdUser == IdUser && c.SecretKey == ScreateKey).ToListAsync();
            var turnback = res[0].CountTurnJoin;
            return turnback;
        }
        public async Task<bool> UpdateOnlineExamRoom(OnlineExamViewModel onlineExamRoom)
        {

            if (onlineExamRoom == null)
            {
                return false;
            }
            OnlineExamRoom onlineExam = new OnlineExamRoom()
            {
                IdUser = onlineExamRoom.IdUser,
                SecretKey = onlineExamRoom.SecretKey,
                IdExaminationRoom = onlineExamRoom.IdExaminationRoom,
                JoinTime = onlineExamRoom.JoinTime,
                StartTime = onlineExamRoom.StartTime,
                CountTurnJoin = onlineExamRoom.CountTurnJoin,
                ChekinImage = onlineExamRoom.ChekinImage,
                EndTime = onlineExamRoom.EndTime,

                IsHandlerRequest = onlineExamRoom.IsHandlerRequest,
                LeaveTime = onlineExamRoom.LeaveTime,
                Status = onlineExamRoom.Status,
                IndexOfStudent = 1,
                Note = onlineExamRoom.Note,
                IsCompletedExam = onlineExamRoom.IsCompletedExam,
                IsViewExamFile = onlineExamRoom.IsViewExamFile,
            };
            await _onLineroomRepo.UpdateAsync(onlineExam);
            await _onLineroomRepo.SaveChangesAsync();
            return true;
        }

        public async Task<int> FastGettingStatus(string ScreateKey, string IdUser)
        {

            var res = await _onLineroomRepo.AsQueryable().Where(c => c.IdUser == IdUser && c.SecretKey == ScreateKey).ToListAsync();
            var gettingstatus = Convert.ToInt32(res.FirstOrDefault().Status);
            return gettingstatus;
        }

        public async Task<List<OnlineExamHasImageViewModel>> HandlerRequestComeIn(string Secret)
        {
            var res = await _onLineroomRepo.AsQueryable().Where(c => c.Status == 4 && c.SecretKey == Secret).ToListAsync();
            var userlist = _userManager.Users.ToList();
            var jojnerlist = (from a in res
                              join b in userlist on a.IdUser equals b.Id
                              select new OnlineExamHasImageViewModel
                              {
                                  IdUser = a.IdUser,
                                  SecretKey = a.SecretKey,
                                  IdExaminationRoom = a.IdExaminationRoom,
                                  JoinTime = a.JoinTime,
                                  StartTime = a.StartTime,
                                  CountTurnJoin = a.CountTurnJoin,
                                  ChekinImage = a.ChekinImage,
                                  EndTime = a.EndTime,
                                  IsHandlerRequest = a.IsHandlerRequest,
                                  LeaveTime = a.LeaveTime,
                                  Status = a.Status,
                                  IndexOfStudent = 1,
                                  Note = a.Note,
                                  IsCompletedExam = a.IsCompletedExam,
                                  IsViewExamFile = a.IsViewExamFile,
                                  ImageUser = "",
                                  Email = b.Email,
                                  StudentCode = ""
                              }).ToList();

            return jojnerlist;
        }

        public async Task<bool> FastUpdateHanlerWhenOut(string ScreateKey, string IdUser)
        {

            if (String.IsNullOrEmpty(IdUser) || String.IsNullOrEmpty(ScreateKey))
            {
                return false;
            }
            var res = await _onLineroomRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            foreach (var x in res.Where(c => c.IdUser == IdUser && c.SecretKey == ScreateKey))
            {
                //trạng thái bằng 4 tức là sinh viên chưa được accecept vào phòng
                x.CountTurnJoin = x.CountTurnJoin + 1;
                x.Status = 4;
                x.LeaveTime = DateTime.Now;
                x.IsHandlerRequest = false;
                await _onLineroomRepo.UpdateAsync(x);
                await _onLineroomRepo.SaveChangesAsync();
            }
            return true;
        }
        public async Task<List<StudentGoToExamViewModel>> GetAllOfExamByIdStudent(string idStudent)
        {
            var detailer = await _examroomdetailRepo.AsQueryable().ToListAsync();
            var Subjecter = await _subjectUPServices.GetAllSubjectAsync();
            var res = await _onLineroomRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            if (res.Any(c => c.IdUser == idStudent))
            {
                var userlist = _userManager.Users.Where(c => c.Id == idStudent).ToList();
                var jojnerlist = (from a in res
                                  join b in userlist on a.IdUser equals b.Id
                                  join c in detailer on a.SecretKey equals c.SecretKey
                                  join d in Subjecter on c.IdSubject equals d.Id
                                  select new StudentGoToExamViewModel
                                  {
                                      IdUser = a.IdUser,
                                      SecretKey = a.SecretKey,
                                      IdExaminationRoom = a.IdExaminationRoom,
                                      JoinTime = a.JoinTime,
                                      StartTime = c.StartTime,
                                      CountTurnJoin = a.CountTurnJoin,
                                      ChekinImage = a.ChekinImage,
                                      EndTime = c.EndTime,
                                      SubjetCode = d.SubjectCode,
                                      IsHandlerRequest = a.IsHandlerRequest,
                                      LeaveTime = a.LeaveTime,
                                      Status = a.Status,
                                      IndexOfStudent = 1,
                                      Note = a.Note,
                                      IsCompletedExam = a.IsCompletedExam,
                                      IsViewExamFile = a.IsViewExamFile,
                                      SubjectName = d.SubjectName
                                  }).ToList();
                return jojnerlist;
            }
            else
            {
                List<StudentGoToExamViewModel> studentGoToExamViewModels = new List<StudentGoToExamViewModel>();
                return studentGoToExamViewModels;
            }


        }
        public async Task<bool> FastUpdateHanlerOneTime(string ScreateKey, string IdUser)
        {
            if (String.IsNullOrEmpty(IdUser) || String.IsNullOrEmpty(ScreateKey))
            {
                return false;
            }
            var res = await _onLineroomRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            foreach (var x in res.Where(c => c.IdUser == IdUser && c.SecretKey == ScreateKey))
            {

                x.IsCompletedExam = true;
                x.IsViewExamFile = false;
                await _onLineroomRepo.UpdateAsync(x);
                await _onLineroomRepo.SaveChangesAsync();
            }
            return true;
        }
    }
}
