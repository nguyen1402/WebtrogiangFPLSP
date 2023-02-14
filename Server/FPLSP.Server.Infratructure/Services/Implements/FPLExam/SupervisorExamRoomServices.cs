using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements.FPLExam
{
    public class SupervisorExamRoomServices : ISupervisorExamRoomServices
    {
        private readonly IRepository<SupervisorExamRoom> _supervisiorRepo;
        private readonly IRepository<ExaminationRoomDetail> _examroomdetailRepo;
        private readonly ISubjectUPServices _subjectUPServices;
        public SupervisorExamRoomServices(IRepository<SupervisorExamRoom> supervisiorRepo, IRepository<ExaminationRoomDetail> examroomdetailRepo, ISubjectUPServices subjectUPServices)
        {
            _supervisiorRepo = supervisiorRepo;
            _examroomdetailRepo = examroomdetailRepo;
            _subjectUPServices = subjectUPServices;
        }
        public async Task<List<SupervisorExamRoom>> GetAllSupervisorExamRoom()
        {
            var res = await _supervisiorRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            return res;
        }


        public async Task<bool> AddingRangeSupervisorExamRoom(List<ExamRoomSupervisorViewModel> supervisorExamRooms)
        {
            var getIdroom = supervisorExamRooms[0].IdExaminationRoom;
            var getScrete = supervisorExamRooms[0].SecretKey;
            var res = await _supervisiorRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            List<SupervisorExamRoom> _lstSupervisor = new List<SupervisorExamRoom>();
            if (supervisorExamRooms == null)
            {
                return false;
            }
            if (supervisorExamRooms.Count() == 0)
            {

                if (res.Any(c => c.SecretKey == getScrete && c.IdExaminationRoom == getIdroom))
                {
                    foreach (var x in res.Where(c => c.SecretKey == getScrete && c.IdExaminationRoom == getIdroom))
                    {
                        await _supervisiorRepo.RemoveAsync(x);
                        await _supervisiorRepo.SaveChangesAsync();
                    }
                }
                else
                {
                    return true;
                }

            }
            if (supervisorExamRooms.Count() > 0)
            {
                foreach (var x in res.Where(c => c.SecretKey == getScrete && c.IdExaminationRoom == getIdroom))
                {
                    await _supervisiorRepo.RemoveAsync(x);
                    await _supervisiorRepo.SaveChangesAsync();
                }
                foreach (var z in supervisorExamRooms)
                {
                    SupervisorExamRoom supervisorExamRoom = new SupervisorExamRoom()
                    {
                        IdExaminationRoom = z.IdExaminationRoom,
                        SecretKey = z.SecretKey,
                        StartTime = z.StartTime,
                        EndTime = z.EndTime,
                        IdLecturter = z.IdLecturter,
                        Status = z.Status,
                        IsMainSupervisor = z.IsMainSupervisor,
                        Note = z.Note,

                    };
                    _lstSupervisor.Add(supervisorExamRoom);
                }
                await _supervisiorRepo.AddRangeAsync(_lstSupervisor);
                await _supervisiorRepo.SaveChangesAsync();

                return true;

            }

            return true;
        }
        public async Task<bool> AddingSupervisorExamRoom(SupervisorExamRoom supervisorExamRooms)
        {
            if (supervisorExamRooms == null)
            {
                return false;
            }

            var res = await _supervisiorRepo.AddAsync(supervisorExamRooms);
            await _supervisiorRepo.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdatingSupervisorExamRoom(SupervisorExamRoom supervisorExamRooms)
        {
            if (supervisorExamRooms == null)
            {
                return false;
            }

            var res = await _supervisiorRepo.UpdateAsync(supervisorExamRooms);
            await _supervisiorRepo.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeletingSupervisorExamRoom(SupervisorExamRoom supervisorExamRooms)
        {
            var res = await _supervisiorRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            if (supervisorExamRooms == null)
            {
                return false;
            }
            foreach (var x in res.Where(c => c.IdLecturter == supervisorExamRooms.IdLecturter
          && c.SecretKey == supervisorExamRooms.SecretKey))
            {
                x.Status = 1;
                await _supervisiorRepo.UpdateAsync(x);
                await _supervisiorRepo.SaveChangesAsync();
            }

            return true;
        }

        public async Task<SupervisorExamRoom> GetCrurrntTimeForSupervisor(string IdUser)
        {
            var res = await _supervisiorRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            //bây giờ xét xem thời gian mình chuyeenr vào thuộc khoảng key nào
            foreach (var x in res)
            {
                if (DateTime.Now >= x.StartTime && DateTime.Now <= x.EndTime && x.IdLecturter == Guid.Parse(IdUser))
                {
                    return x;
                }
            }
            SupervisorExamRoom supervisorExamRoom = new SupervisorExamRoom();
            return supervisorExamRoom;
        }

        public async Task<List<ExamRoomSupervisorViewModel>> GetSupervisorById(string IdUser)
        {
            var detailer = await _examroomdetailRepo.AsQueryable().ToListAsync();
            var Subjecter = await _subjectUPServices.GetAllSubjectAsync();
            var res = await _supervisiorRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            if (res.Any(c => c.IdLecturter == Guid.Parse(IdUser)))
            {
                var joinerlist = (from a in res
                                  join b in detailer
                                  on a.SecretKey equals b.SecretKey
                                  join c in Subjecter on b.IdSubject equals c.Id
                                  select new ExamRoomSupervisorViewModel
                                  {
                                      IdExaminationRoom = a.IdExaminationRoom,
                                      SecretKey = a.SecretKey,
                                      StartTime = b.StartTime,
                                      EndTime = b.EndTime,
                                      IdLecturter = a.IdLecturter,
                                      Status = a.Status,
                                      IsMainSupervisor = a.IsMainSupervisor,
                                      Note = a.Note,
                                      SubjectName = c.SubjectName
                                  }).ToList();
                return joinerlist;
            }
            else
            {
                List<ExamRoomSupervisorViewModel> examRoomSupervisorViewModels = new List<ExamRoomSupervisorViewModel>();
                return examRoomSupervisorViewModels;
            }

        }
    }
}
