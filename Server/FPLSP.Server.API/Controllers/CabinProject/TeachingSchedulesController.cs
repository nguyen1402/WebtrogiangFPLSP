using DocumentFormat.OpenXml.Office2010.Excel;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject.SignalRServices;
using FPLSP.Server.Infrastructure.Services.Interfaces.Cabin;
using FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.ShiftOfCabin;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.TeachingSchedule;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace FPLSP.Server.API.Controllers.CabinProject
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachingSchedulesController : ControllerBase
    {
        private ITeachingScheduleServices _teachingScheduleService;
        private readonly IHubContext<SignalRHubBookingServices> _hubContext;

        public TeachingSchedulesController(ITeachingScheduleServices teachingScheduleService, IHubContext<SignalRHubBookingServices> hubContext)
        {
            _teachingScheduleService = teachingScheduleService ?? throw new ArgumentNullException(nameof(teachingScheduleService));
            _hubContext = hubContext ?? throw new ArgumentNullException(nameof(hubContext));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] TeachingScheduleCreateVM teachingSchedule)
        {
            var result = await _teachingScheduleService.Add(teachingSchedule);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRTeachingSchedules", responsemess);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("{Id}")]
        public async Task<IActionResult> Update([FromRoute] Guid Id, TeachingscheduleUpdateVM teachingSchedule)
        {
            var result = await _teachingScheduleService.Update(Id, teachingSchedule);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRTeachingSchedules", responsemess);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid Id)
        {
            var result = await _teachingScheduleService.Delete(Id);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRTeachingSchedules", responsemess);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _teachingScheduleService.GetAll());
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetById(Guid Id)
        {
            return Ok(await _teachingScheduleService.GetById(Id));
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetForSearch([FromQuery] TeachingScheduleSearch teachingScheduleSearch)
        {
            return Ok(await _teachingScheduleService.GetForSearch(teachingScheduleSearch));
        }

        [HttpPost("adding-teaching")]
        public async Task<IActionResult> AddingTeaching([FromBody] TeachingSchedule teaching)
        {
            var result = await _teachingScheduleService.AddTeachingSchedules(teaching);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRTeachingSchedules", responsemess);
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPut]
        [Route("updating-teaching")]
        public async Task<IActionResult> UpdatingTeaching(TeachingSchedule teaching)
        {
            var result = await _teachingScheduleService.UpdateTeachingSchedules(teaching);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRTeachingSchedules", responsemess);
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpDelete("Removing-teaching/{Id}")]
        public async Task<IActionResult> RemovingTeaching([FromRoute] Guid Id)
        {
            var result = await _teachingScheduleService.DeteleTeachingSchedules(Id);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRTeachingSchedules", responsemess);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("getting-teaching/{Id}")]
        public async Task<IActionResult> GettingTeaching([FromRoute] Guid Id)
        {
            var res = await _teachingScheduleService.GetTeachingScheduleById(Id);
            return Ok(res);
        }
    }
}
