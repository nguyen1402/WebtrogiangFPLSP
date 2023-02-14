using FPLSP.Server.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CopySubjectInClassesController : ControllerBase
    {
        private readonly ICopySubjectInClass _repo;

        public CopySubjectInClassesController(ICopySubjectInClass repo)
        {
            _repo = repo;
        }

        [HttpGet("CreateAllSubject/{idsubject}")]
        public async Task<IActionResult> CreateAllSubject(Guid idsubject)
        {
            var Copy = await _repo.Copy(idsubject);

            return Ok(Copy);
        }
        //[HttpGet("allLessonCP")]
        //public async Task<IActionResult> GetAllLessonCP()
        //{
        //    var LessonCP = await _repo.GetAllLessonCP();

        //    return Ok(LessonCP);
        //}
        //[HttpGet("allLessonContentCP")]
        //public async Task<IActionResult> GetAllLessonContentCP()
        //{
        //    var LessonContentCP = await _repo.GetAllLessonContentCP();

        //    return Ok(LessonContentCP);
        //}
        //[HttpGet("allResourceLink")]
        //public async Task<IActionResult> GetAllResourceLink()
        //{
        //    var ResourceLink = await _repo.GetAllResourceLinkCP();

        //    return Ok(ResourceLink);
        //}
        //[HttpGet("allSubjectCP")]
        //public async Task<IActionResult> GetAllSubjectCP()
        //{
        //    var SubjectCP = await _repo.GetAllSubjectCP();

        //    return Ok(SubjectCP);
        //}
        //[HttpGet("allQuizCP")]
        //public async Task<IActionResult> GetAllQuizCP()
        //{
        //    var QuizCP = await _repo.GetAllQuizCP();

        //    return Ok(QuizCP);
        //}
        //[HttpGet("allQuizQuestionCP")]
        //public async Task<IActionResult> GetAllQuizQuestionCP()
        //{
        //    var QuizQuestionCP = await _repo.GetAllQuizQuestionCP();

        //    return Ok(QuizQuestionCP);
        //}
        //[HttpGet("allQuizQuestionQuizCP")]
        //public async Task<IActionResult> GetAllQuizQuestionQuizCP()
        //{
        //    var QuizQuestionQuizCP = await _repo.GetAllQuizQuestionQuizCP();

        //    return Ok(QuizQuestionQuizCP);
        //}
        //[HttpGet("allQuizAnswerCP")]
        //public async Task<IActionResult> GetAllQuizAnswerCP()
        //{
        //    var QuizAnswerCP = await _repo.GetAllQuizAnswerCP();

        //    return Ok(QuizAnswerCP);
        //}
        //[HttpGet("allQuestionType")]
        //public async Task<IActionResult> GetAllQuestionType()
        //{
        //    var QuestionType = await _repo.GetAllQuestionType();

        //    return Ok(QuestionType);
        //}
        //[HttpGet("allLessonUP")]
        //public async Task<IActionResult> GetAllLessonUP()
        //{
        //    var LessonUP = await _repo.GetAllLessonUP();

        //    return Ok(LessonUP);
        //}

        //[HttpGet("allLessonContentUP")]
        //public async Task<IActionResult> GetAllLessonContentUP()
        //{
        //    var LessonContentUP = await _repo.GetAllLessonContentUP();

        //    return Ok(LessonContentUP);
        //}

        //[HttpGet("allResourceLinkUP")]
        //public async Task<IActionResult> GetAllResourceLinkUP()
        //{
        //    var ResourceLinkUP = await _repo.GetAllResourceLinkUP();

        //    return Ok(ResourceLinkUP);
        //}

        //[HttpGet("allSubjectUP")]
        //public async Task<IActionResult> GetAllSubjectUP()
        //{
        //    var SubjectUP = await _repo.GetAllSubjectUP();

        //    return Ok(SubjectUP);
        //}

        //[HttpGet("allQuizUP")]
        //public async Task<IActionResult> GetAllQuizUP()
        //{
        //    var QuizUP = await _repo.GetAllQuizUP();

        //    return Ok(QuizUP);
        //}

        //[HttpGet("allQuizQuestionUP")]
        //public async Task<IActionResult> GetAllQuizQuestionUP()
        //{
        //    var QuizQuestionUP = await _repo.GetAllQuizQuestionUP();

        //    return Ok(QuizQuestionUP);
        //}

        //[HttpGet("allQuizQuestionQuizUP")]
        //public async Task<IActionResult> GetAllQuizQuestionQuizUP()
        //{
        //    var QuizQuestionQuizUP = await _repo.GetAllQuizQuestionQuizUP();

        //    return Ok(QuizQuestionQuizUP);
        //}

        //[HttpGet("allAnswerUP")]
        //public async Task<IActionResult> GetAllAnswerUP()
        //{
        //    var AnswerUP = await _repo.GetAllAnswerUP();

        //    return Ok(AnswerUP);
        //}




    }
}
