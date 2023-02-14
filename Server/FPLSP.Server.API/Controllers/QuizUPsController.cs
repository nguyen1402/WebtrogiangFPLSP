using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.QuizUp.ViewModels;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.QuizUp;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizUPsController : ControllerBase
    {
        private readonly IQuizUPServices _quizUpServices;
        public QuizUPsController(IQuizUPServices quizUpServices)
        {

            _quizUpServices = quizUpServices ?? throw new ArgumentNullException(nameof(quizUpServices)); ;
        }
        [HttpPost("AddQuizUp/{idsubject}")]
        public Task<bool> Add([FromBody] QuizUpVm quizUpvm, Guid idsubject)
        {
            return _quizUpServices.Add(quizUpvm, idsubject);
        }
        [HttpGet("QuizUp")]
        public async Task<List<QuizUpDto>> Get()
        {
            return await _quizUpServices.Get();
        }
        [HttpGet]
        [Route("{Id}")]
        public Task<QuizUpEditVm> GetById([FromRoute] Guid Id)
        {
            return _quizUpServices.GetById(Id);
        }
        [HttpDelete]
        [Route("{Id}")]
        public Task<bool> Delete([FromRoute] Guid Id)
        {
            return _quizUpServices.Delete(Id);
        }
        [HttpPost("deleteAll")]
        public Task<bool> DeleteAll([FromBody] List<Guid> lstId)
        {
            return _quizUpServices.DeleteAll(lstId);
        }
        [HttpPut]
        [Route("{Id}")]
        public Task<bool> Update([FromRoute] Guid Id, QuizUpEditVm quizUpvm)
        {
            return _quizUpServices.Update(Id, quizUpvm);
        }
        [HttpGet("page/{idsubject}")]
        public async Task<IActionResult> GetPage([FromQuery] ListQuizUpSearch listQuizSearch, Guid idsubject)
        {
            var pagelist = await _quizUpServices.GetPageList(listQuizSearch, idsubject);

            var quizUp = pagelist.Items.Select(a => new QuizUpDto()
            {
                Id = a.Id,
                QuizTitle = a.QuizTitle,
                QuizName = a.QuizName,
                Descriptions = a.Descriptions,
                EndDay = a.EndDay,
                StartDay = a.StartDay,
                Status = a.Status,
                MaxTurn = a.MaxTurn,
                SubjectId = a.SubjectId
            });
            return Ok(new PageList<QuizUpDto>(quizUp.ToList(),
                pagelist.MetaData.TotalCount,
                pagelist.MetaData.CurrentPage,
                pagelist.MetaData.PageSize));
        }
    }
}
