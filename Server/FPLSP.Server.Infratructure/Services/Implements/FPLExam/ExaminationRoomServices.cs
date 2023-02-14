using AutoMapper;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements.FPLExam
{
    public class ExaminationRoomServices : IExaminationRoomServices
    {
        private readonly IRepository<ExaminationRoom> _examRoomRepo;
        private IMapper _mapper;
        private readonly ITrainingFacilitiesCPServices _trainingFacilitiesCPServices;
        public ExaminationRoomServices(IRepository<ExaminationRoom> examRoomRepo, IMapper mapper, ITrainingFacilitiesCPServices trainingFacilitiesCPServices)
        {
            _examRoomRepo = examRoomRepo;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _trainingFacilitiesCPServices = trainingFacilitiesCPServices;
        }
        public async Task<bool> AddExaminationRoom(ExaminationRoomDetailView examinationRoomViewModel)
        {
            // var finalexamroom = _mapper.Map<ExaminationRoom>(examinationRoomViewModel);
            ExaminationRoom examinationRoom = new ExaminationRoom()
            {
                Id = examinationRoomViewModel.Id,
                ExaminationRoomName = examinationRoomViewModel.ExaminationRoomName,
                CreateTime = examinationRoomViewModel.CreateTime,
                IndexOfExaminationRoom = examinationRoomViewModel.IndexOfExaminationRoom,
                Status = examinationRoomViewModel.Status,
                IdTrainingFacility = examinationRoomViewModel.IdTrainingFacility,



            };
            if (examinationRoom != null)
            {
                var res = await _examRoomRepo.AddAsync(examinationRoom);
                await _examRoomRepo.SaveChangesAsync();


                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<List<ExaminationRoom>> GetAllExamRoom()
        {

            //đây là trạng thái xóa
            var finalList = await _examRoomRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            return finalList;
        }
        public async Task<PageList<ExaminationRoomDetailView>> GetExamRoomForPaging(ExaminationRoomSearch examinationRoomSearch)
        {
            var finalList = await _examRoomRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            var listTrain = await _trainingFacilitiesCPServices.GetTrainingFacilitiesAsync();


            var joinlist = (from a in finalList
                            join b in listTrain on a.IdTrainingFacility equals b.Id


                            select new ExaminationRoomDetailView()
                            {
                                Id = a.Id,
                                CreateTime = a.CreateTime,
                                ExaminationRoomName = a.ExaminationRoomName,
                                IndexOfExaminationRoom = a.IndexOfExaminationRoom,
                                IdTrainingFacility = a.IdTrainingFacility,
                                TrainingFacilityName = b.TrainingInstitutionName,
                                Status = a.Status,

                            }
                            ).ToList();
            if (examinationRoomSearch.TrainId.HasValue)
            {
                joinlist = joinlist.Where(c => c.IdTrainingFacility == examinationRoomSearch.TrainId).ToList();
            }
            if (string.IsNullOrEmpty(examinationRoomSearch.ExaminationRoomName))
            {
                joinlist = joinlist.Where(c => c.ExaminationRoomName.ToLower().Contains(examinationRoomSearch.ExaminationRoomName.ToLower())).ToList();
            }

            var data = joinlist.Skip((examinationRoomSearch.PageNumber - 1) * examinationRoomSearch.PageSize).Take(examinationRoomSearch.PageSize).ToList();
            return new PageList<ExaminationRoomDetailView>(data, joinlist.Count, examinationRoomSearch.PageNumber, examinationRoomSearch.PageSize);
        }

        public async Task<bool> DeleteExamRoom(Guid IdExamroom)
        {
            if (IdExamroom == Guid.Empty)
            {
                return false;
            }
            var finalList = await _examRoomRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            foreach (var room in finalList.Where(c => c.Id == IdExamroom))
            {
                room.Status = 1;

                await _examRoomRepo.UpdateAsync(room);
                await _examRoomRepo.SaveChangesAsync();
            }

            return true;
        }
        public async Task<bool> UpdateExamRoom(ExaminationRoomDetailView examinationRoomViewModel)
        {
            if (examinationRoomViewModel == null)
            {
                return false;
            }
            var examupdate = _mapper.Map<ExaminationRoom>(examinationRoomViewModel);
            await _examRoomRepo.UpdateAsync(examupdate);
            await _examRoomRepo.SaveChangesAsync();
            return true;
        }

        public async Task<ExaminationRoom> GetExamRoomById(Guid Id)
        {
            var finalList = await _examRoomRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            var exam = finalList.Find(c => c.Id == Id);
            return exam;
        }
    }
}
