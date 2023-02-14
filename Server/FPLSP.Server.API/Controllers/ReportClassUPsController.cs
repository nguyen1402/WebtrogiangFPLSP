using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.ReportClassUP;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportClassUPsController : ControllerBase
    {
        private readonly IReportClassUPServices _reportClassUPServices;
        public ReportClassUPsController(IReportClassUPServices reportClassUPServices)
        {
            _reportClassUPServices = reportClassUPServices ?? throw new ArgumentNullException(nameof(reportClassUPServices));
        }

        [HttpGet("all")]
        public Task<IQueryable<ReportUPDto>> GetListReport()
        {
            return _reportClassUPServices.GetListReportClassUP();
        }
        [HttpGet("getall/{classUPId}")]
        public async Task<IActionResult> GetListPagingReport(Guid classUPId, [FromQuery] ReportClassUpSearch reportParameters)
        {
            var pagelist = await _reportClassUPServices.GetPagingReportUPDto(classUPId, reportParameters);
            var reportDtos = pagelist.Items.Select(a => new ReportUPDto()
            {
                Id = a.Id,
                ReportAmount = a.ReportAmount,
                ReportDate = a.ReportDate,
                ReportLevel = a.ReportLevel,
                Question = a.Question,
                Answer = a.Answer,
                Describe = a.Describe,
                Note = a.Note,
                ClassCode = a.ClassCode,
                IsDeleted = a.IsDeleted,
                Status = a.Status
            });
            return Ok(new PageList<ReportUPDto>(reportDtos.ToList(),
                pagelist.MetaData.TotalCount,
                pagelist.MetaData.CurrentPage,
                pagelist.MetaData.PageSize));
        }
        [HttpGet("{id}")]
        public Task<ReportUPViewModel> GetByIdReport(Guid id)
        {
            var result = _reportClassUPServices.GetByIdReport(id);
            return result;
        }

        [HttpPost]
        public async Task<IActionResult> CreateReport(ReportUPViewModel reportClassUP)
        {
            var report = _reportClassUPServices.CreateReportClassUP(reportClassUP);
            if (report.Result)
            {
                return Ok("Tạo mới thành công");
            }
            return BadRequest("Tạo mới thất bại");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateReport(ReportUPViewModel reportClassUP)
        {
            var report = _reportClassUPServices.UpdateReportClassUP(reportClassUP);
            if (report.Result)
            {
                return Ok("Cập nhật thành công");
            }
            return BadRequest("Cập nhật thất bại");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReport(Guid id)
        {
            var report = _reportClassUPServices.RemoveReportClassUP(id);
            if (report.Result)
            {
                return Ok("Xóa thành công");
            }
            return BadRequest("Xóa thất bại");
        }
        [HttpPost("deletelist")]
        public async Task<IActionResult> DeleteListReport([FromBody] List<Guid> listIdReport)
        {
            var report = _reportClassUPServices.RemoveListReportClassUP(listIdReport);
            if (report.Result)
            {
                return Ok("Xóa thành công");
            }
            return BadRequest("Xóa thất bại");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Restore(Guid id)
        {
            var report = _reportClassUPServices.RestoreReportClassUP(id);
            if (report.Result)
            {
                return Ok("Khôi phục thành công");
            }
            return BadRequest("Khôi phục thất bại");
        }
    }
}
