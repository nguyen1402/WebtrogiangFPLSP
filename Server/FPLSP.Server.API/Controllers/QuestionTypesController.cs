using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.QuestionType;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.QuestionType;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionTypesController : ControllerBase
    {
        private readonly IQuestionTypeServices _questionTypeServices;
        public QuestionTypesController(IQuestionTypeServices questionTypeServices)
        {
            _questionTypeServices = questionTypeServices ?? throw new ArgumentNullException(nameof(questionTypeServices));
        }
        [HttpGet]
        public async Task<IQueryable<QuestionTypeDto>> GetAll()
        {
            return await _questionTypeServices.GetAll();
        }
        [HttpPost]
        public async Task<bool> Add([FromBody] QuestionTypeVm questionTypeVm)
        {
            return await _questionTypeServices.Add(questionTypeVm);
        }
        [HttpPut]
        [Route("{Id}")]
        public async Task<bool> Update([FromRoute] Guid Id, QuestionTypeVm questionTypeVm)
        {
            return await _questionTypeServices.Update(Id, questionTypeVm);
        }
        [HttpGet]
        [Route("{Id}")]
        public async Task<QuestionTypeVm> Get([FromRoute] Guid Id)
        {
            return await _questionTypeServices.Get(Id);
        }
        [HttpGet("page")]
        public async Task<IActionResult> Get([FromQuery] QuestionTypeSearch questionTypeSearch)
        {
            var pagelist = await _questionTypeServices.GetPageList(questionTypeSearch);

            var questionTypeDtos = pagelist.Items.Select(c => new QuestionTypeDto()
            {
                Id = c.Id,
                QuestionTypeName = c.QuestionTypeName,
                QuestionForm = c.QuestionForm
            });
            return Ok(new PageList<QuestionTypeDto>(questionTypeDtos.ToList(),
                pagelist.MetaData.TotalCount,
                pagelist.MetaData.CurrentPage,
                pagelist.MetaData.PageSize));
        }
    }
}
