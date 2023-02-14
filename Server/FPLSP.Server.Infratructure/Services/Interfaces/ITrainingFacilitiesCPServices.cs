using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.TrainingFacilitiesCPVm;

namespace FPLSP.Server.Infrastructure.Services.Interfaces;

public interface ITrainingFacilitiesCPServices
{
    public Task<List<TrainingFacilitiesCP>> GetTrainingFacilitiesAsync();

    public Task<TrainingFacilitiesCPViewModel> CreateTrainingFacility(TrainingFacilitiesCPRequest TrainingFacilityCPRequest);
    public Task<bool> UpdateTrainingFacility(Guid Id, TrainingFacilitiesCPRequest TrainingFacilityCPRequest);
    public Task<bool> DeleteTrainingFacility(Guid Id);

    public Task<PageList<TrainingFacilitiesCPViewModel>> GetTrainingFacilityList(TrainingFacilitiesCPListSearch pagingParameters);

    public Task<TrainingFacilitiesCPViewModel> GetTrainingFacilityListById(Guid Id);

    public Task<IQueryable<TrainingFacilitiesCPViewModel>> GetTrainingFacilityMapper();

    public Task<TrainingFacilitiesCP> GetTrainingFacilityMaxCode();
    Task<bool> RemoveListTF(List<Guid> listId);

}