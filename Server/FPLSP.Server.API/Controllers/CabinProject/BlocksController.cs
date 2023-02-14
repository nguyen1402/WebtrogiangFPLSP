using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2016.Excel;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject.SignalRServices;
using FPLSP.Server.Infrastructure.Services.Interfaces.Cabin;
using FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace FPLSP.Server.API.Controllers.CabinProject
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlocksController : ControllerBase
    {
        private readonly IHubContext<SignalRHubBookingServices> _hubContext;
        private readonly IBlockServices _IBlockServices;
        public BlocksController(IBlockServices IBlockServices, IHubContext<SignalRHubBookingServices> hubContext)
        {
            _IBlockServices = IBlockServices ?? throw new ArgumentNullException(nameof(IBlockServices));
            _hubContext = hubContext ?? throw new ArgumentNullException(nameof(hubContext));
        }
        [HttpGet]
        public async Task<IQueryable<BlockDto>> GettAll()
        {
            return await _IBlockServices.GetAll();
        }
        [HttpGet]
        [Route("{Id}")]
        public async Task<BlockVM> GetById([FromRoute] Guid Id)
        {
            return await _IBlockServices.GetById(Id);
        }
        [HttpPost]
        public async Task<bool> CreateBlock([FromBody] BlockVM blockVM)
        {
            var result = await _IBlockServices.CreateBlock(blockVM);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRBlocks", responsemess);
            }
            return result;
        }
        [HttpPut]
        public async Task<bool> UpdateBlock([FromBody] BlockVM blockVM)
        {
            var result = await _IBlockServices.UpdateBlock(blockVM);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRBlocks", responsemess);
            }
            return result;
        }
        [HttpDelete]
        [Route("{Id}")]
        public async Task<bool> DeleteBlock([FromRoute] Guid Id)
        {
            var result = await _IBlockServices.DeleteBlock(Id);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRBlocks", responsemess);
            }
            return result;
        }

    }
}
