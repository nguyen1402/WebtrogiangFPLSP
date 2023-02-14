using DocumentFormat.OpenXml.Wordprocessing;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.Specialized;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboard;

        public DashboardController(IDashboardService dashboard)
        {
            _dashboard = dashboard ?? throw new ArgumentNullException(nameof(dashboard));
        }

        [HttpGet("GetDashboard")]
        public async Task<IActionResult> GetDashboardAsync()
        {
            var result = await _dashboard.GetAllDashBoard();
            return Ok(result);
        } 
        [HttpGet("GetAllSpec")]
        public async Task<IActionResult> GetAllSpec()
        {
            var result = await _dashboard.GetAllSpec();
            return Ok(result);
        } 
        [HttpGet("GetAllStudentUPNotUser")]
        public async Task<IActionResult> GetAllStudentUPNotUser()
        {
            var result = await _dashboard.GetAllStudentUPNotUser();
            return Ok(result);
        }
        [HttpGet("GetAllLectureNotUser/{idTran}")]
        public async Task<IActionResult> GetAllLectureNotUser(Guid idTran)
        {
            var result = await _dashboard.GetAllLectureNotUser(idTran);
            return Ok(result);
        }  
        [HttpGet("GetAllSpecByIdTran/{idTran}")]
        public async Task<IActionResult> GetAllSpecByIdTran(Guid idTran, [FromQuery] SpecializedListSearch parameters)
        {
            var pagels = await _dashboard.GetAllSpecByIdTran(idTran, parameters);
            var data = pagels.Items.Select(x => new SpecializedDto()
            {
                SpecializedCode = x.SpecializedCode,
                SpecializationName = x.SpecializationName,
                Status = x.Status,
                Id = x.Id,
                Image = x.Image,
                IdSpeciality = x.IdSpeciality,
            });
            return Ok(new PageList<SpecializedDto>(data.ToList(),
                pagels.MetaData.TotalCount,
                pagels.MetaData.CurrentPage,
                pagels.MetaData.PageSize));
        }
    }
}
