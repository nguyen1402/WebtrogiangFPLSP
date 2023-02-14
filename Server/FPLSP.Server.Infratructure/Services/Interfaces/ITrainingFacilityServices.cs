using FPLSP.Server.Domain.Entities.CoresParts;

namespace FPLSP.Server.Infrastructure.Services.Interfaces;

public interface ITrainingFacilityServices
{
    Task<List<TrainingFacilitiesCP>> GetTrainingFacilitiesAsync();
    Task<List<TrainingFacilitiesCP>> GetTrainingFacilitiesAsync(string code);
}