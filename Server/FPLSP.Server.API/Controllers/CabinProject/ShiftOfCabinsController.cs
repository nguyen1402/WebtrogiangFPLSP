using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject.SignalRServices;
using FPLSP.Server.Infrastructure.Services.Interfaces.Cabin;
using FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.ShiftOfCabin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace FPLSP.Server.API.Controllers.CabinProject
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftOfCabinsController : ControllerBase
    {
        private readonly IHubContext<SignalRHubBookingServices> _hubContext;
        private IShiftOfCabinServices _shiftOfCabinServices;

        public ShiftOfCabinsController(IShiftOfCabinServices shiftOfCabinServices, IHubContext<SignalRHubBookingServices> hubContext)
        {
            _shiftOfCabinServices = shiftOfCabinServices ?? throw new ArgumentNullException(nameof(shiftOfCabinServices));
            _hubContext = hubContext ?? throw new ArgumentNullException(nameof(hubContext));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ShiftOfCabinCreateVM shiftOfCabinVM)
        {
            var result = await _shiftOfCabinServices.Add(shiftOfCabinVM);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRShiftOfCabins", responsemess);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("{Id}")]
        public async Task<IActionResult> Update([FromRoute] Guid Id, ShiftOfCabinUpdateVM shiftOfCabinVM)
        {
            var result = await _shiftOfCabinServices.Update(Id, shiftOfCabinVM);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRShiftOfCabins", responsemess);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid Id)
        {
            var result = await _shiftOfCabinServices.Delete(Id);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRShiftOfCabins", responsemess);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _shiftOfCabinServices.GetAll());
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetById(Guid Id)
        {
            return Ok(await _shiftOfCabinServices.GetById(Id));
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetForSearch([FromQuery] ShiftOfCabinSearch shiftOfCabin)
        {
            return Ok(await _shiftOfCabinServices.GetForSearch(shiftOfCabin));
        }

        [HttpGet("allForDashboard")]
        public async Task<IActionResult> GetAllForDashboard()
        {
            return Ok(await _shiftOfCabinServices.GetAllInformationOfShiftOfCabin());
        }

        [HttpGet("allNotDeletedForDashboard")]
        public async Task<IActionResult> GetAllNotDeletedForDashboard()
        {
            return Ok(await _shiftOfCabinServices.GetAllInformationOfShiftOfCabinIsNotDeleted());
        }
    }
}
