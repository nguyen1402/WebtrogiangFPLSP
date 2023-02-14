using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;



namespace FPLSP.Server.Infrastructure.Services.Implements;

public class StudentServices : IStudentServices
{
    private readonly IRepository<StudentCP> _studentRepository;
    private readonly IMapper _mapper;
    //private  readonly ILogger _logger;

    public StudentServices(IRepository<StudentCP> studentRepository, IMapper mapper)
    {
        _studentRepository = studentRepository ?? throw new ArgumentNullException(nameof(studentRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper)); ;
        //_logger = logger ?? throw new ArgumentNullException(nameof(logger)); ;
    }
    public Task<IQueryable<StudentDto>> GetStudentsAsync()
    {

        Serilog.Log.Information("Started--Log Of Weather Forecast-- > Get Method");

        var studentCollection = _studentRepository.AsQueryable().ProjectTo<StudentDto>(_mapper.ConfigurationProvider);
        // _logger.Information(studentCollection.ToString());

        return Task.FromResult(studentCollection);
    }
}