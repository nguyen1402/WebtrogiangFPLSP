using AutoMapper;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class TypeOfNewFeedServices : ITypeOfNewFeedServices
    {

        private readonly IRepository<TypeOfNewFeed> _bookMarkIser;
        private readonly IMapper _mapper;
        public TypeOfNewFeedServices(IRepository<TypeOfNewFeed> bookMarkIser, IMapper mapper
            )
        {
            _bookMarkIser = bookMarkIser;
            _mapper = mapper;



        }
        public async Task<List<TypeOfNewFeed>> TypeOfNewFeeds()
        {
            return await _bookMarkIser.AsQueryable().ToListAsync();
        }
    }
}
