using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.LecturerCPVm;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface ILecturersCPServices
    {
        public Task<LecturersCPViewModel> CreateLecturer(LecturersCPRequest request);
        public Task<bool> CreateLecturerForTrain(CreateleatureForTrainVm lecturersCPVM);
        public Task<bool> UpdateLecturer(Guid Id, LecturersCPRequest request);
        public Task<bool> UpdateLecturerTrain(Guid Id, CreateleatureForTrainVm createleatureForTrain);
        public Task<bool> DeleteLecturer(Guid Id);

        public Task<List<LecturersCP>> GetAllLecturerAsync();

        public Task<PageList<LecturersCPViewModel>> GetLecturerList(PagingParameters pagingParameters);
        public Task<PageList<LecturersCPViewModel>> GetLecturerListSearch(LecturersCPListSearch search);
        public Task<LecturersCPViewModel> GetLecturerListById(Guid Id);

        public Task<List<LecturersCP>> GetLecturerMapper();
        Task<bool> UpdateLectureCP(LecturersCP lecturerCP);

        public Task<LecturersCP> GetLecturerMaxCode();
        Task<bool> RemoveListLecturersCP(List<Guid> listId);
    }
}
