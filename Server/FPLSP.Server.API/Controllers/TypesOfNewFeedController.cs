using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypesOfNewFeedController : ControllerBase
    {
        private readonly ITypeOfNewFeedServices _typeOfNewFeed;
        public TypesOfNewFeedController(ITypeOfNewFeedServices typeOfNewFeed)
        {
            _typeOfNewFeed = typeOfNewFeed;
        }

        [HttpGet]
        public async Task<List<TypeOfNewFeed>> TypeOfNewFeeds()
        {
            return await _typeOfNewFeed.TypeOfNewFeeds();
        }
    }
}
