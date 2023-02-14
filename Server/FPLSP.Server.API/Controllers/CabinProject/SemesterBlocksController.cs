using DocumentFormat.OpenXml.Office2016.Excel;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject.SignalRServices;
using FPLSP.Server.Infrastructure.Services.Interfaces.Cabin;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace FPLSP.Server.API.Controllers.CabinProject
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemesterBlocksController : ControllerBase
    {
        private readonly IHubContext<SignalRHubBookingServices> _hubContext;
        private readonly ISemesterBlockServices _ISemesterBlockServices;
        public SemesterBlocksController(ISemesterBlockServices ISemesterBlockServices, IHubContext<SignalRHubBookingServices> hubContext)
        {
            _ISemesterBlockServices = ISemesterBlockServices ?? throw new ArgumentNullException(nameof(ISemesterServices));
            _hubContext = hubContext ?? throw new ArgumentNullException(nameof(hubContext));
        }
        [HttpGet]
        public async Task<IQueryable<SemesterBlockDto>> GettAll()
        {
            return await _ISemesterBlockServices.GetAll();
        }
        [HttpGet]
        [Route("{IdBlock}/{IdSemester}")]
        public async Task<SemesterBlockVM> GetById([FromRoute] Guid IdBlock, Guid IdSemester)
        {
            return await _ISemesterBlockServices.GetById(IdBlock, IdSemester);
        }
        [HttpPost]
        public async Task<bool> CreateSemesterBlock([FromBody] SemesterBlockVM semesterVM)
        {
            var result = await _ISemesterBlockServices.CreateSemesterBlock(semesterVM);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRSemesterBlocks", responsemess);               
            }
            return result;
        }
        [HttpPut]
        public async Task<bool> UpdateSemesterBlock([FromBody] SemesterBlockVM semesterVM)
        {
            var result = await _ISemesterBlockServices.UpdateSemesterBlock(semesterVM);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRSemesterBlocks", responsemess);
            }
            return result;
        }
        [HttpDelete]
        [Route("{IdBlock}/{IdSemester}")]
        public async Task<bool> DeleteSemesterBlock([FromRoute] Guid IdBlock, Guid IdSemester)
        {
            var result = await _ISemesterBlockServices.DeleteSemesterBlock(IdBlock, IdSemester);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRSemesterBlocks", responsemess);
            }
            return result;
        }
        [HttpGet("page")]
        public async Task<IActionResult> GetPage([FromQuery] SemesterBlockSearch semesterBlockSearch)
        {
            var pagelist = await _ISemesterBlockServices.GetPageList(semesterBlockSearch);

            var semesterBlockDtos = pagelist.Items.Select(a => new SemesterBlockDto()
            {
                IdBlock = a.IdBlock,
                IdSemester = a.IdSemester,
                IndexOfSemesterBlock = a.IndexOfSemesterBlock,
                Status = a.Status,
                StartTime = a.StartTime,
                EndTime = a.EndTime,
            });
            return Ok(new PageList<SemesterBlockDto>(semesterBlockDtos.ToList(),
                pagelist.MetaData.TotalCount,
                pagelist.MetaData.CurrentPage,
                pagelist.MetaData.PageSize));
        }
    }
}
