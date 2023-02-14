using FPLSP.Server.Infrastructure.Services.Implements;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.NewFeed;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticaficationsController : ControllerBase
    {
        private readonly IHubContext<NotificationHub> _hubContext;
        private readonly INewFeedServices _newFeedServices;

        public NoticaficationsController(IHubContext<NotificationHub> hubContext, INewFeedServices newFeedServices)
        {
            _hubContext = hubContext;
            _newFeedServices = newFeedServices;
        }

        [HttpPost]
        public async Task<bool> Post([FromBody] NewFeedVM newFeedVM)
        {
            if (newFeedVM == null)
            {
                return false;
            }
            var res = await _newFeedServices.AddToNewFeed(newFeedVM);
            if (res)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("Noticafications", responsemess);
            }

            return true;
        }
    }
}
