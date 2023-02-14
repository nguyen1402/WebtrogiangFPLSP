using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.Services.Implements.Cabin;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject.SignalRServices;
using FPLSP.Server.Infrastructure.Services.Interfaces.Cabin;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace FPLSP.Server.API.Controllers.CabinProject
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemestersController : ControllerBase
    {
        private readonly IHubContext<SignalRHubBookingServices> _hubContext;
        private readonly ISemesterServices _ISemesterServices;
        public SemestersController(ISemesterServices ISemesterServices, IHubContext<SignalRHubBookingServices> hubContext)
        {
            _ISemesterServices = ISemesterServices ?? throw new ArgumentNullException(nameof(ISemesterServices));
            _hubContext = hubContext ?? throw new ArgumentNullException(nameof(hubContext));
        }
        [HttpGet]
        public async Task<IQueryable<SemesterDto>> GettAll()
        {
            return await _ISemesterServices.GetAll();
        }
        [HttpGet]
        [Route("{Id}")]
        public async Task<SemesterVM> GetById([FromRoute] Guid Id)
        {
            return await _ISemesterServices.GetById(Id);
        }
        [HttpPost]
        public async Task<bool> CreateSemester([FromBody] SemesterVM semesterVM)
        {
            var result = await _ISemesterServices.CreateSemester(semesterVM);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRSemesters", responsemess);
            }
            return result;
        }
        [HttpPut]
        public async Task<bool> UpdateSemester(SemesterVM semesterVM)
        {
            var result = await _ISemesterServices.UpdateSemester(semesterVM);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRSemesters", responsemess);
            }
            return result;
        }
        [HttpDelete]
        [Route("{Id}")]
        public async Task<bool> DeleteSemester([FromRoute] Guid Id)
        {
            var result = await _ISemesterServices.DeleteSemester(Id);
            if (result)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRSemesters", responsemess);
            }
            return result;
        }
    }
}
