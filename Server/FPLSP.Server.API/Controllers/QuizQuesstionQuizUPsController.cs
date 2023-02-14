using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuesstionQuizUP;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizQuesstionQuizUPsController : ControllerBase
    {
        private readonly IQuizQuesstionQuizUPServices _repo;
        public QuizQuesstionQuizUPsController(IQuizQuesstionQuizUPServices repo)
        {
            _repo = repo;
        }

        [HttpGet("getall/{quizId}")]
        public async Task<IActionResult> Get(Guid quizId, [FromQuery] QuizQuesstionQuizUPListSearch parameters)
        {
            var pagel = await _repo.GetPagingParamets(quizId, parameters);
            var data = pagel.Items.Select(x => new QuizQuesstionQuizUPDto()
            {
                QuestionTypeName = x.QuestionTypeName,
                QuestionForm = x.QuestionForm,
                QuestionName = x.QuestionName,
                QuestionCode = x.QuestionCode,
                QuestionTypeId = x.QuestionTypeId,
                StatusQuizQuestion = x.StatusQuizQuestion,
                StatusQuizQuiz = x.StatusQuizQuiz,
                QuizQuestionId = x.QuizQuestionId,
                QuizId = x.QuizId
            });
            return Ok(new PageList<QuizQuesstionQuizUPDto>(data.ToList(),
                pagel.MetaData.TotalPages,
                pagel.MetaData.CurrentPage,
                pagel.MetaData.PageSize));

        }
        [HttpGet("{quizquesstionId}")]
        public async Task<IActionResult> Get(Guid quizquesstionId)
        {
            if (string.IsNullOrEmpty(quizquesstionId.ToString())) return BadRequest();
            var result = await _repo.GetbyId(quizquesstionId);
            if (result == null)
                return BadRequest();
            return Ok(result);

        }
        [HttpGet("getallcauhoi/{idsubject}")]
        public async Task<IActionResult> GetAllCauhoi(Guid idsubject)
        {
            if (string.IsNullOrEmpty(idsubject.ToString())) return BadRequest();
            var result = await _repo.GetAllCauHoi(idsubject);
            if (result == null)
                return BadRequest();
            return Ok(result);

        }

        [HttpPost("{quizId}")]
        public async Task<IActionResult> Add(Guid quizId, [FromBody] QuizQuesstionQuizUPCreateVM lesson)
        {
            if (lesson == null) return BadRequest();
            var result = await _repo.Create(quizId, lesson);
            if (result != 1)
                return BadRequest();
            return Ok();
        }

        [HttpPut("{QuizQuestionId}")]
        public Task<bool> Update(Guid QuizQuestionId, [FromBody] QuizQuesstionQuizUPUpdateVM lesson)
        {
            if (lesson == null) return Task.FromResult(false);
            var result = _repo.Update(QuizQuestionId, lesson);
            if (result != Task.FromResult(1))
                return Task.FromResult(false);
            return Task.FromResult(true);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuizQuestionQuizCP(Guid id)
        {
            if (id == null)
                return BadRequest();
            var result = await _repo.Delete(id);
            if (result != 1)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost("deletelist")]
        public async Task<IActionResult> DeleteListQuizQuestionQuiz([FromBody] List<Guid> listIdQuizQuestionQuiz)
        {
            var result = _repo.DeleteListQuestionQuizUP(listIdQuizQuestionQuiz);
            if (result.Result == true)
            {
                return Ok("Xóa thành công");
            }
            return BadRequest("Xóa thất bại");
        }
    }
}
