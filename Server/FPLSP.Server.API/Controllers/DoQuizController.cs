using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.DoQuizsVM;
using Microsoft.AspNetCore.Mvc;


namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoQuizController : ControllerBase
    {
        private readonly IDoQuizService _service;

        public DoQuizController(IDoQuizService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpGet("GetQuestion")]
        public async Task<IActionResult> GetQuestionAsync([FromQuery] GetQuestionCollectionVm viewModel)
        {
            var result = await _service.GetQuestionCollection(viewModel);
            return Ok(result);
        }

        [HttpPost("Submit/{id}")]
        public async Task<IActionResult> SubmitAsync([FromRoute] Guid id, [FromBody] DoQuizViewModel viewModel)
        {
            var result = await _service.SubmitQuizAsync(id, viewModel);
            return Ok(result);
        }

        [HttpGet("GetTakeAnswerOfStudent")]
        public async Task<IActionResult> GetTakeAnswerOfStudentAsync([FromQuery] GetTakeAnswerOfStudentVM viewModel)
        {
            var result = await _service.GetTakeAnswersOfQuizAsync(viewModel);
            return Ok(result);
        }

    }
}
