using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.QuizQuestionCPDtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuestionCPVm;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizQuestionCPsController : ControllerBase
    {
        private readonly IQuizQuestionCPServices _quizquestionCPServices;
        private readonly ILogger<QuizQuestionCPsController> _logger;

        public QuizQuestionCPsController(IQuizQuestionCPServices quizquestionCPServices, ILogger<QuizQuestionCPsController> logger)
        {
            _quizquestionCPServices = quizquestionCPServices ?? throw new ArgumentNullException(nameof(quizquestionCPServices));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuizQuestionCP([FromBody] CreateQuizQuestionCPVm quizquestion)
        {
            if (quizquestion == null)
                return BadRequest();

            var newsquiz = await _quizquestionCPServices.CreateQuizQuestionCP(quizquestion);
            if (newsquiz == 2)
            {
                return BadRequest(newsquiz);
            }

            if (newsquiz != 1)
            {
                return BadRequest(newsquiz);
            }
            return Ok(newsquiz);
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] ListQuizQuestionSearch quizquestion)
        {
            var pagelist = await _quizquestionCPServices.GetQuizQuestionList(quizquestion);

            var MonhocDTOs = pagelist.Items.Select(c => new QuizQuestionCPDtos()
            {
                Id = c.Id,
                KindoOfQuestionId = c.KindoOfQuestionId,
                QuestionCode = c.QuestionCode,
                QuestionName = c.QuestionName,
                QuizQuestionForm = c.QuizQuestionForm,
                Status = c.Status,
                QuestionTypeName = c.QuestionTypeName,
            });
            return Ok(new PageList<QuizQuestionCPDtos>(MonhocDTOs.ToList(),
                pagelist.MetaData.TotalCount,
                pagelist.MetaData.CurrentPage,
                pagelist.MetaData.PageSize));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateQuizQuestionCP(Guid id, [FromBody] QuizQuestionCPVm quizquestion)
        {

            if (quizquestion == null)
                return BadRequest();

            var kq = await _quizquestionCPServices.UpdateQuizQuestionCP(id, quizquestion);
            if (kq != 1)
            {
                return BadRequest(kq);
            }
            return Ok(kq);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetQuizQuestionById([FromRoute] Guid id)
        {
            var quizQuestion = await _quizquestionCPServices.GetQuizQuestionCPbyId(id);
            if (quizQuestion == null) return NotFound($"{id} is not found");
            return Ok(quizQuestion);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuizQuestionCP(Guid id)
        {
            if (id == null)
                return BadRequest();

            var result = await _quizquestionCPServices.DeleteQuizQuestionCP(id);
            if (result != 1)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
