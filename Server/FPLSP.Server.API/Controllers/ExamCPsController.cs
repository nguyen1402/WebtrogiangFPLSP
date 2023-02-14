using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.Exams;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamCPsController : ControllerBase
    {
        private readonly IExamCPServices _examServices;

        public ExamCPsController(IExamCPServices examServices)
        {
            _examServices = examServices;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetExamsByIdAsync([FromRoute] Guid id)
        {
            var result = await _examServices.GetExamCPById(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetExamsAsync([FromQuery] ExamListSearchVm ExamListSearchVm)
        {
            var result = await _examServices.GetExamCPList(ExamListSearchVm);
            var examDto = result.Items.Select(c => new ExamCPDto()
            {
                ExamCode = c.ExamCode,
                ExamName = c.ExamName,
                Status = c.Status,
                Id = c.Id

            });
            return Ok(new PageList<ExamCPDto>(examDto.ToList(),
            result.MetaData.TotalCount, result.MetaData.CurrentPage, result.MetaData.PageSize));

        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllExamAsync()
        {
            var reuslt = await _examServices.GetAllExamCPList();
            return Ok(reuslt);
        }

        [HttpPost]
        public async Task<IActionResult> CreateExamsAsync([FromBody] ExamCreateVm createVm)
        {
            var exam = await _examServices.CreateExamCP(new ExamCP()
            {
                ExamCode = createVm.ExamCode,
                ExamName = createVm.ExamName,
                Status = createVm.Status,
                SubjectId = createVm.SubjectId,
                Id = Guid.NewGuid()
            });
            return Ok(exam);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateExams(Guid id, ExamUpdateVm ExamUpdateVm)
        {
            var exam = await _examServices.UpdateExamCP(id, ExamUpdateVm);
            return Ok(exam);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteExams(Guid id)
        {
            var exam = await _examServices.DeleteExamCP(id);
            return Ok(exam);

        }
    }
}
