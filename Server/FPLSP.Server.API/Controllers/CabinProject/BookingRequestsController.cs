using FPLSP.Server.Data.FPLSPDbContext;
using FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.GroupCabin;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingRequest;
using Microsoft.AspNetCore.Mvc;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject;
using FPLSP.Server.Domain.Entities.CabinProject;
using DocumentFormat.OpenXml.Office2016.Excel;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject.SignalRServices;
using Microsoft.AspNetCore.SignalR;

namespace FPLSP.Server.API.Controllers.BookingRequestProject
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingRequestsController : ControllerBase
    {
        private readonly IHubContext<SignalRHubBookingServices> _hubContext;
        private readonly IBookingRequestServices _BookingRequestServices;
        private ApplicationDbContext _ApplicationDbContext;
        public BookingRequestsController(IBookingRequestServices BookingRequestServices, IHubContext<SignalRHubBookingServices> hubContext)
        {
            _BookingRequestServices = BookingRequestServices ?? throw new ArgumentNullException(nameof(BookingRequestServices));
            _hubContext = hubContext ?? throw new ArgumentNullException(nameof(hubContext));
            _ApplicationDbContext = new ApplicationDbContext();

        }


        [HttpGet]
        public async Task<IActionResult> GetListBookingRequestList([FromQuery] BookingRequestSearchViewModel search)
        {
            var objCollection = await _BookingRequestServices.GetBookingRequestListSearch(search);

            var result = objCollection.Items.Select(c => new BookingRequestViewModel
            {
                Id = c.Id,
                IndexOfBookingRequest = c.IndexOfBookingRequest,
                ContentOfRequest = c.ContentOfRequest,
                SendingTime = c.SendingTime,
                IdLectuter = c.IdLectuter,
                SubjectId = c.SubjectId,
                ClassId = c.ClassId,
                IdCabin = c.IdCabin,
                Status = c.Status,
                StartTime = c.StartTime,
                FeedBackTime = c.FeedBackTime,
                EndTime = c.EndTime
            }).ToList();
            return Ok(new PageList<BookingRequestViewModel>(result, objCollection.MetaData.TotalCount, objCollection.MetaData.CurrentPage, objCollection.MetaData.PageSize));
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllBookingRequest()
        {
            var objCollection = await _BookingRequestServices.GetAllBookingRequestAsync();

            return Ok(objCollection);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetBookingRequestListById(Guid Id)
        {
            var lecturerModel = await _BookingRequestServices.GetBookingRequestListById(Id);
            return Ok(lecturerModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBookingRequest([FromBody] BookingRequestCreateViewModel request)
        {
            if (request == null)
                return BadRequest();

            var newRole = await _BookingRequestServices.CreateBookingRequest(request);

            var responsemess = "Done";
            await _hubContext.Clients.All.SendAsync("SignalRBookingRequests", responsemess);
            return Ok(newRole);
        }

        [HttpPut]
        [Route("{Id}")]
        public async Task<IActionResult> UpdateBookingRequest(Guid Id, [FromBody] BookingRequestUpdateViewModel request)
        {
            var result = await _BookingRequestServices.UpdateBookingRequest(Id, request);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRBookingRequests", responsemess);
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpDelete("undo/{Id}")]
        public async Task<IActionResult> DeleteBookingRequest(Guid Id)
        {
            var result = await _BookingRequestServices.DeleteBookingRequest(Id);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRBookingRequests", responsemess);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> DeleteGroupCabin([FromRoute] Guid Id)
        {
            var objDelete = await _BookingRequestServices.GetBookingRequestListById(Id);
            if (objDelete == null)
            {
                return NotFound();
            }

            objDelete.Status = 1;
            var x = await _BookingRequestServices.UpdateBookingRequest(Id, new BookingRequestUpdateViewModel()
            {
                IndexOfBookingRequest = objDelete.IndexOfBookingRequest,
                ContentOfRequest = objDelete.ContentOfRequest,
                SendingTime = DateTime.Now,
                IdLectuter = objDelete.IdLectuter,
                SubjectId = objDelete.SubjectId,
                ClassId = objDelete.ClassId,
                Status = objDelete.Status,
            });
            return Ok();
        }
    }
}