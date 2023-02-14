using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;



namespace FPLSP.Server.Infrastructure.Services.Implements;

public class TrainingFacilityServices : ITrainingFacilityServices
{
    private readonly IRepository<TrainingFacilitiesCP> _trainingFacilityRepository;
    //private readonly IMapper _mapper;
    //private  readonly ILogger _logger;

    public TrainingFacilityServices(IRepository<TrainingFacilitiesCP> trainingFacilityRepository)
    {
        _trainingFacilityRepository = trainingFacilityRepository;
        // ?? throw new ArgumentNullException( nameof(trainingFacilityRepository));
        //_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper)); ;
        //_logger = logger ?? throw new ArgumentNullException(nameof(logger)); ;
    }

    public async Task<List<TrainingFacilitiesCP>> GetTrainingFacilitiesAsync()
    {

        var trainingFacilityCollection = _trainingFacilityRepository.AsQueryable().ToList();

        return trainingFacilityCollection;
    }

    public async Task<List<TrainingFacilitiesCP>> GetTrainingFacilitiesAsync(string code)
    {

        var trainingFacilityCollection = _trainingFacilityRepository.AsQueryable().ToList();

        return trainingFacilityCollection;
    }
}