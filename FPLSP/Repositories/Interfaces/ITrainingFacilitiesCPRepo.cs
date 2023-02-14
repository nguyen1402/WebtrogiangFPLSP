using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.TrainingFacilitiesCPVm;
using Microsoft.AspNetCore.Components.Forms;

namespace FPLSP.Repositories.Interfaces
{
    public interface ITrainingFacilitiesCPRepo
    {
        public Task<List<TrainingFacilitiesCP>> GetTrainingFacilitiesAsync();

        public Task<bool> CreateTrainingFacility(TrainingFacilitiesCPRequest TrainingFacilityCPViewModel);
        public Task<bool> UpdateTrainingFacility(Guid Id, TrainingFacilitiesCPRequest TrainingFacilityCPViewModel);
        public Task<bool> DeleteTrainingFacility(Guid Id);

        public Task<PageList<TrainingFacilitiesCPViewModel>> GetTrainingFacilityList(TrainingFacilitiesCPListSearch _trainingFacilitiesCPListSearch);

        public Task<TrainingFacilitiesCPViewModel> GetTrainingFacilityListById(Guid Id);

        public Task<IQueryable<TrainingFacilitiesCPViewModel>> GetTrainingFacilityMapper();

        public Task<TrainingFacilitiesCP> GetTrainingFacilityMaxCode();
        public Task<string> LoadingImageUrl(IBrowserFile file, string trainingFacilityCode);
        Task<bool> RemoveListTF(List<Guid> listIdTF);
    }
}
