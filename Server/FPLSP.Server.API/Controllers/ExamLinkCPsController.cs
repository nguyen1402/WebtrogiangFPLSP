using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.ExamLinks;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamLinkCPsController : ControllerBase
    {
        private IExamLinkCPServices _examLinkCPServices;

        public ExamLinkCPsController(IExamLinkCPServices examLinkCPServices)
        {
            _examLinkCPServices = examLinkCPServices;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetExamsByIdAsync([FromRoute] Guid id)
        {
            var result = await _examLinkCPServices.GetExamLinkCPById(id);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetExamsAll()
        {
            var result = await _examLinkCPServices.GetExamLinkCPAll();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetExamsAsync([FromQuery] ExamLinkListSearchVm examLinkListSearch)
        {
            var result = await _examLinkCPServices.GetExamLinkCPList(examLinkListSearch);


            var examDto = result.Items.Select(c => new ExamLinkDto()
            {
                Id = c.Id,
                ExamId = c.ExamId,
                ExamLinkCode = c.ExamLinkCode,
                ExpirationDate = c.ExpirationDate >= DateTime.Now ? c.ExpirationDate : DateTime.Now,
                CreatedDay = DateTime.Now,
                Path = c.Path,
                Status = c.Status


            });
            return Ok(new PageList<ExamLinkDto>(examDto.ToList(),
            result.MetaData.TotalCount, result.MetaData.CurrentPage, result.MetaData.PageSize));

        }

        [HttpPost]

        public async Task<IActionResult> CreateExams(ExamLinkCreateVm createVm)
        {
            var examLink = await _examLinkCPServices.CreateExamLinkCP(new ExamLinkCP()
            {
                Id = Guid.NewGuid(),
                ExamId = createVm.ExamId,
                ExpirationDate = createVm.ExpirationDate,
                ExamLinkCode = createVm.ExamLinkCode,
                CreatedDay = DateTime.Now,
                Path = createVm.Path,
                Status = createVm.Status
            });
            return Ok(examLink);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateExams(Guid id, ExamLinkUpdateVm examLinkUpdateVm)
        {
            var examLink = await _examLinkCPServices.UpdateExamLinkCP(id, examLinkUpdateVm);
            return Ok(examLink);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteExams(Guid id)
        {
            var examLink = await _examLinkCPServices.DeleteExamLinkCP(id);
            return Ok(examLink);

        }
    }
}
