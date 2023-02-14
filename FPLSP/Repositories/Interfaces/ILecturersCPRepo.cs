using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.LecturerCPVm;
using Microsoft.AspNetCore.Components.Forms;

namespace FPLSP.Repositories.Interfaces
{
    public interface ILecturersCPRepo
    {
        public Task<bool> CreateLecturer(LecturersCPRequest LecturerCPViewModel);
        public Task<bool> CreateLecturerForTrain(CreateleatureForTrainVm lecturersCPVM);
        public Task<bool> UpdateLecturer(Guid Id, LecturersCPRequest LecturerCPViewModel);
        public Task<bool> UpdateLecturerTrain(Guid Id, CreateleatureForTrainVm createleatureForTrain);
        public Task<bool> DeleteLecturer(Guid Id);
        public Task<List<LecturersCP>> GetAllLecturerAsync();
        public Task<PageList<LecturersCPViewModel>> GetLecturerListAsync(PagingParameters pagingParameters);
        public Task<PageList<LecturersCPViewModel>> GetLecturerListPagingAsync(LecturersCPListSearch search);
        public Task<LecturersCPViewModel> GetLecturerListById(Guid Id);
        public Task<List<LecturersCP>> GetLecturerMapper();
        public Task<LecturersCPViewModel> GetMaxCodeLecturer();
        public Task<string> LoadingImageUrl(IBrowserFile file, string lecturerCode);
        Task<bool> RemoveListLecturer(List<Guid> listIdLecturer);
        Task<bool> UpdateLectureCP(LecturersCP lecturerCP);

    }
}
