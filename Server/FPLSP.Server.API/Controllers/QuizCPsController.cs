using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.QuizCPDtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.QuizCPVm;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizCPsController : ControllerBase
    {
        private readonly IQuizCPServices _quizCPServices;
        private readonly ILogger<QuizCPsController> _logger;

        public QuizCPsController(IQuizCPServices quizCPServices, ILogger<QuizCPsController> logger)
        {
            _quizCPServices = quizCPServices ?? throw new ArgumentNullException(nameof(quizCPServices));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpPost("{idsubject}")]
        public async Task<IActionResult> CreateQuizCP(Guid idsubject, [FromBody] QuizCPVm quiz)
        {
            if (quiz == null)
                return BadRequest();

            var newsquiz = await _quizCPServices.CreateQuizCP(idsubject, quiz);
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

        [HttpGet("all/{idsubject}")]
        public async Task<IActionResult> Get(Guid idsubject, [FromQuery] ListQuizSearch quiz)
        {
            var pagelist = await _quizCPServices.GetQuizList(idsubject, quiz);

            var MonhocDTOs = pagelist.Items.Select(c => new SubjectQuizCPDtos()
            {
                Id = c.Id,
                QuizName = c.QuizName,
                Descriptions = c.Descriptions,
                Point = c.Point,
                EndDay = c.EndDay,
                StartDay = c.StartDay,
                Status = c.Status,
                MaxTurn = c.MaxTurn,

            });
            return Ok(new PageList<SubjectQuizCPDtos>(MonhocDTOs.ToList(),
                pagelist.MetaData.TotalCount,
                pagelist.MetaData.CurrentPage,
                pagelist.MetaData.PageSize));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateQuizCP(Guid id, [FromBody] UpdateQuizCPVm quiz)
        {

            if (quiz == null)
                return BadRequest();

            var kq = await _quizCPServices.UpdateQuizCP(id, quiz);
            if (kq != 1)
            {
                return BadRequest(kq);
            }
            return Ok(kq);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetQuizById([FromRoute] Guid id)
        {
            var student = await _quizCPServices.GetQuizCPbyId(id);
            if (student == null) return NotFound($"{id} is not found");
            return Ok(student);

        }

        [HttpGet]
        [Route("allquizbyid/{id}")]
        public async Task<IActionResult> GetAllQuizById([FromRoute] Guid id)
        {
            var quiz = await _quizCPServices.GetAllQuizCPbyIdSubject(id);
            if (quiz == null) return NotFound($"{id} is not found");
            return Ok(quiz);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuizCP(Guid id)
        {
            if (id == null)
                return BadRequest();

            var result = await _quizCPServices.DeleteQuizCP(id);
            if (result != 1)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost("deletelist")]
        public async Task<IActionResult> DeleteListQuiz([FromBody] List<Guid> listIdQuiz)
        {
            var report = _quizCPServices.RemoveListQuizCP(listIdQuiz);
            if (report.Result)
            {
                return Ok("Xóa thành công");
            }
            return BadRequest("Xóa thất bại");
        } 
        
        [HttpPost("createExcelQuizQuestion")]
        public async Task<IActionResult> CreateExcelQuizQuestion([FromBody] List<ExcelQuizQuestion> lstexcelQuizQuestions)
        {
            
            if (lstexcelQuizQuestions == null)
                return BadRequest();

            var kq = await _quizCPServices.CreateExcelQuizQuestion(lstexcelQuizQuestions);
            if (kq != 1)
            {
                return BadRequest(kq);
            }
            return Ok(kq);
        }
    }
}
