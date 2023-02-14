using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.NewFeed;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewFeedsController : ControllerBase
    {
        private readonly INewFeedServices _ifeeder;
        public NewFeedsController(INewFeedServices ifeeder)
        {
            _ifeeder = ifeeder;
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<List<NewFeedOverView>> GetListNewForUser(string id)
        {
            var results = await _ifeeder.GetListNewForUser(Guid.Parse(id));

            return results;
        }

        [HttpGet]

        public async Task<IActionResult> GetListNewForAll([FromQuery] SearchNewFeed searchNewFeed)
        {
            var results = await _ifeeder.GetListAllNewFeed(searchNewFeed);
            var newfeedDTO = results.Items.ToList();
            return Ok(new PageList<NewFeedOverView>(newfeedDTO, results.MetaData.TotalCount, results.MetaData.CurrentPage, results.MetaData.PageSize));
        }
        [HttpPost]

        public async Task<bool> AddNewFeed([FromBody] NewFeedVM newFeedVM)
        {
            var results = await _ifeeder.AddToNewFeed(newFeedVM);
            return results;
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<bool> UpdateNewFeed(Guid id, [FromBody] NewFeedVM newFeedVM)
        {
            var results = await _ifeeder.UpdateNewFeed(id, newFeedVM);
            return results;
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<bool> DeleteNewFeed(Guid id)
        {

            var results = await _ifeeder.RemoveNewFeed(id);
            return results;
        }
        [HttpGet]
        [Route("getnewfeed-class")]
        public async Task<List<NewFeedOverView>> GetNewFeedForClass(Guid idclass, Guid idsubject)
        {

            var results = await _ifeeder.GetListNewForClass(idclass, idsubject);
            return results;
        }

    }
}
