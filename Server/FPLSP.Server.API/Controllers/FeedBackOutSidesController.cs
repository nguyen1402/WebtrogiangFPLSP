using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Entities.Cabin;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedBackOutSidesController : ControllerBase
    {
        private readonly IRepository<FeedBackOutSide> _res;
        public FeedBackOutSidesController(IRepository<FeedBackOutSide> res)
        {
            _res= res;
        }
        [HttpPost]
        public async Task<IActionResult> AddFeedBack(FeedBackOutSide feedBackOutSide)
        {
         
            var response= await _res.AddAsync(feedBackOutSide);
            await _res.SaveChangesAsync();
            return Ok(response);
        }

    }
}
