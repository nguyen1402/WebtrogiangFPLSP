using FPLSP.Server.Data.FPLSPDbContext;
using FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.GroupCabin;
using Microsoft.AspNetCore.Mvc;
using FPLSP.Server.Data.SeedWork;
using DocumentFormat.OpenXml.Office2010.Excel;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin;
using DocumentFormat.OpenXml.Office2016.Excel;
using Microsoft.AspNetCore.SignalR;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject.SignalRServices;

namespace FPLSP.Server.API.Controllers.CabinProject
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupCabinsController : ControllerBase
    {
        private readonly IHubContext<SignalRHubBookingServices> _hubContext;
        private readonly IGroupCabinServices _groupCabinServices;
        private ApplicationDbContext _ApplicationDbContext;
        public GroupCabinsController(IGroupCabinServices groupCabinServices, IHubContext<SignalRHubBookingServices> hubContext)
        {
            _groupCabinServices = groupCabinServices ?? throw new ArgumentNullException(nameof(groupCabinServices));
            _hubContext = hubContext ?? throw new ArgumentNullException(nameof(hubContext));
            _ApplicationDbContext = new ApplicationDbContext();
        }

        [HttpGet]
        public async Task<IActionResult> GetListGroupCabinPaging([FromQuery] GroupCabinSearchViewModel search)
        {
            var objCollection = await _groupCabinServices.GetGroupCabinListSearch(search);

            var result = objCollection.Items.Select(c => new GroupCabinViewModel
            {
                IdCabin = c.IdCabin,
                IdSpec = c.IdSpec,
                GroupCabinName = c.GroupCabinName,
                DateOfGrouping = c.DateOfGrouping,
                StartTime = c.StartTime,
                EndTime = c.EndTime,
                IndexOfGroupCabin = c.IndexOfGroupCabin,
                Status = c.Status,
            }).ToList();
            return Ok(new PageList<GroupCabinViewModel>(result, objCollection.MetaData.TotalCount, objCollection.MetaData.CurrentPage, objCollection.MetaData.PageSize));
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllGroupCabin()
        {
            var objCollection = await _groupCabinServices.GetAllGroupCabinAsync();
            return Ok(objCollection);
        }

        [HttpGet]
        [Route("{IdSpec}/{IdCabin}")]
        public async Task<IActionResult> GetGroupCabinListById(Guid IdSpec, Guid IdCabin)
        {
            var lecturerModel = await _groupCabinServices.GetGroupCabinListById(IdSpec, IdCabin);
            return Ok(lecturerModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateGroupCabin([FromBody] GroupCabinCreateViewModel request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            var result = await _groupCabinServices.CreateGroupCabin(request);
            var responsemess = "Done";
            await _hubContext.Clients.All.SendAsync("SignalRGroupCabins", responsemess);

            return Ok(result);
        }

        [HttpPut]
        [Route("{IdSpec}/{IdCabin}")]
        public async Task<IActionResult> UpdateGroupCabin(Guid IdSpec, Guid IdCabin, [FromBody] GroupCabinUpdateViewModel request)
        {           
            var result = await _groupCabinServices.UpdateGroupCabin(IdSpec, IdCabin, request);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRGroupCabins", responsemess);

                return Ok(result);
            }
            return BadRequest();
            
        }
        [HttpPut]
        [Route("ChangeStatus/{IdSpec}")]
        public async Task<bool> ChangeStatus(Guid IdSpec, [FromBody] Guid IdCabin)
        {
            var result = await _groupCabinServices.ChangeStatus(IdSpec, IdCabin);
            return result;
        }

        [HttpDelete]
        [Route("{IdSpec}/{IdCabin}")]
        public async Task<IActionResult> DeleteGroupCabin([FromRoute] Guid IdSpec, Guid IdCabin)
        {
            var objDelete = await _groupCabinServices.GetGroupCabinListById(IdSpec, IdCabin);
            if (objDelete == null)
            {
                return NotFound();
            }

            objDelete.Status = 1;
            var x = await _groupCabinServices.UpdateGroupCabin(IdSpec, IdCabin, new GroupCabinUpdateViewModel()
            {
                GroupCabinName = objDelete.GroupCabinName,
                StartTime = objDelete.StartTime,
                EndTime = objDelete.EndTime,
                IndexOfGroupCabin = objDelete.IndexOfGroupCabin,
                Status = objDelete.Status,
            });            
            if (x)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRGroupCabins", responsemess);

                return Ok(x);
            }
            return BadRequest();           
        }
    }
}
