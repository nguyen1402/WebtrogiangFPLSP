using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class ClassRoomServices : IClassRoomServices
    {
        private readonly IRepository<ClassUp> _classRepository;
        //private readonly IMapper _mapper;

        public ClassRoomServices(IRepository<ClassUp> classRepository)
        {
            _classRepository = classRepository;
            // _mapper = mapper;
        }

        public async Task<List<ClassUp>> GetClassAsync()
        {
            var studentCollection = _classRepository.AsQueryable().ToList();

            return studentCollection;
        }
    }
}
