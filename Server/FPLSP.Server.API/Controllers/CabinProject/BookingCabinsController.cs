using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject.SignalRServices;
using FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingCabin;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace FPLSP.Server.API.Controllers.CabinProject
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingCabinsController : ControllerBase
    {
        private readonly IHubContext<SignalRHubBookingServices> _hubContext;
        private IBookingCabinServices _bookingCabinServices;

        public BookingCabinsController(IBookingCabinServices bookingCabinServices, IHubContext<SignalRHubBookingServices> hubContext)
        {
            _bookingCabinServices = bookingCabinServices ?? throw new ArgumentNullException(nameof(bookingCabinServices));
            _hubContext = hubContext ?? throw new ArgumentNullException(nameof(hubContext));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] BookingCabinCreateVM bookingCabinVM)
        {
            var result = await _bookingCabinServices.Add(bookingCabinVM);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRBookingCabins", responsemess);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("{Id}/{IdCabin}/{SubjectId}/{ClassId}/{IdShift}")]
        public async Task<IActionResult> Update([FromRoute] Guid Id, Guid IdCabin, Guid SubjectId, Guid ClassId, Guid IdShift, [FromBody] BookingCabinUpdateVM bookingCabinVM)
        {
            var result = await _bookingCabinServices.Update(Id, IdCabin, SubjectId, ClassId, IdShift, bookingCabinVM);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRBookingCabins", responsemess);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{Id}/{IdCabin}/{SubjectId}/{ClassId}/{IdShift}")]
        public async Task<IActionResult> Delete([FromRoute] Guid Id, Guid IdCabin, Guid SubjectId, Guid ClassId, Guid IdShift)
        {
            var result = await _bookingCabinServices.Delete(Id, IdCabin, SubjectId, ClassId, IdShift);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRBookingCabins", responsemess);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _bookingCabinServices.GetAll());
        }

        [HttpGet]
        [Route("{Id}/{IdCabin}/{SubjectId}/{ClassId}/{IdShift}")]
        public async Task<IActionResult> GetById([FromRoute] Guid Id, Guid IdCabin, Guid SubjectId, Guid ClassId, Guid IdShift)
        {
            return Ok(await _bookingCabinServices.GetById(Id, IdCabin, SubjectId, ClassId, IdShift));
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetForSearch([FromQuery] BookingCabinSearch bookingCabinSearch)
        {
            return Ok(await _bookingCabinServices.GetForSearch(bookingCabinSearch));
        }
        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> UndoDelete([FromRoute] Guid Id)
        {
            var result = await _bookingCabinServices.UndoDelete(Id);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRBookingCabins", responsemess);
                return Ok(result);
            }
            return BadRequest();            
        }


    }
}
