using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.ContentOfExamsCP;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentOfExamCPsController : ControllerBase
    {
        private IContentOfExamCPServices _coeServices;

        public ContentOfExamCPsController(IContentOfExamCPServices coeServices)
        {
            _coeServices = coeServices;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
        {
            var result = await _coeServices.GetCoeCPById(id);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetCOEAllList()
        {
            var a = await _coeServices.GetCoeCpListAll();
            return Ok(a);
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] CoeListSearchVm searchVm)
        {
            var result = await _coeServices.GetCoeCpList(searchVm);


            var Dto = result.Items.Select(c => new ContentOfExamCPDto()
            {
                EndDate = c.EndDate,
                CoeCode = c.CoeCode,
                DateStarted = c.DateStarted,
                Level = c.Level,
                Status = c.Status,
                Content = c.Content,
                ExamId = c.ExamId,
                TotalOfQuestions = c.TotalOfQuestions,
                QuestionType = c.QuestionType,
                DateCreated = c.DateCreated,
                Id = c.Id,
                IsDeleted = c.IsDeleted
            });

            return Ok(new PageList<ContentOfExamCPDto>(Dto.ToList(),
            result.MetaData.TotalCount, result.MetaData.CurrentPage, result.MetaData.PageSize));

        }

        [HttpPost]

        public async Task<IActionResult> Create(CoeCreateVm createVm)
        {
            var examLink = await _coeServices.CreateCoeCp(new ContentOfExamCP()
            {
                Id = Guid.NewGuid(),
                DateCreated = DateTimeOffset.UtcNow,
                EndDate = createVm.EndDate >= DateTimeOffset.Now ? createVm.EndDate : DateTimeOffset.Now,
                CoeCode = createVm.CoeCode,
                DateStarted = createVm.DateStarted >= DateTimeOffset.Now ? createVm.DateStarted : DateTimeOffset.Now,
                Level = createVm.Level,
                Status = createVm.Status,
                Content = createVm.Content,
                ExamId = createVm.ExamId,
                TotalOfQuestions = createVm.TotalOfQuestions,
                QuestionType = createVm.QuestionType

            });
            return Ok(examLink);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(Guid id, CoeUpdateVm UpdateVm)
        {
            var update = await _coeServices.UpdateCoeCp(id, UpdateVm);
            return Ok(update);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var delete = await _coeServices.DeleteCoeCp(id);
            return Ok(delete);

        }
    }
}
