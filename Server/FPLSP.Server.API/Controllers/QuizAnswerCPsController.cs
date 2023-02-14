using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.QuizAnswerCPDtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.QuizAnswerCPVm;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizAnswerCPsController : ControllerBase
    {
        private readonly IQuizAnswerCPServices _quizanswerCPServices;
        private readonly ILogger<QuizAnswerCPsController> _logger;

        public QuizAnswerCPsController(IQuizAnswerCPServices quizanswerCPServices, ILogger<QuizAnswerCPsController> logger)
        {
            _quizanswerCPServices = quizanswerCPServices ?? throw new ArgumentNullException(nameof(quizanswerCPServices)); ;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuizAnswerCP([FromBody] CreateQuizAnswerCPVm quizansweer)
        {
            if (quizansweer == null)
                return BadRequest();

            var newsquiz = await _quizanswerCPServices.CreateQuizAnswerCP(quizansweer);
            if (newsquiz != 1)
            {
                return BadRequest(newsquiz);
            }
            return Ok(newsquiz);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateQuizAnswerCP(Guid id, [FromBody] QuizAnswerCPVm quizanswer)
        {

            if (quizanswer == null)
                return BadRequest();

            var kq = await _quizanswerCPServices.UpdateQuizAnswerCP(id, quizanswer);
            if (kq != 1)
            {
                return BadRequest(kq);
            }
            return Ok(kq);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetQuizAnswerById([FromRoute] Guid id)
        {
            var quizAnswer = await _quizanswerCPServices.GetQuizAnswerCPbyId(id);
            if (quizAnswer == null) return NotFound($"{id} is not found");
            return Ok(quizAnswer);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuizQuestionCP(Guid id)
        {
            if (id == null)
                return BadRequest();

            var result = await _quizanswerCPServices.DeleteQuizAnswerCP(id);
            if (result != 1)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] ListSearchQuizAnswerCP quizanswer)
        {
            var pagelist = await _quizanswerCPServices.GetQuizAnswerList(quizanswer);

            var quiz = pagelist.Items.Select(c => new QuizAnswerCPDtos()
            {
                Id = c.Id,
                QuestionCode = c.QuestionCode,
                Answer = c.Answer,
                IdQuizQuestion = c.IdQuizQuestion,
            });
            return Ok(new PageList<QuizAnswerCPDtos>(quiz.ToList(),
                pagelist.MetaData.TotalCount,
                pagelist.MetaData.CurrentPage,
                pagelist.MetaData.PageSize));
        }
    }
}
