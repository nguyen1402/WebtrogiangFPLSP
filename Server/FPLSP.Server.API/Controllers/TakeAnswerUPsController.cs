using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.TakeAnswerViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TakeAnswerUPsController : ControllerBase
    {
        private readonly ITakeAnswerUPServices _takeAnswer;

        public TakeAnswerUPsController(ITakeAnswerUPServices takeAnswer)
        {
            _takeAnswer = takeAnswer ?? throw new ArgumentNullException(nameof(takeAnswer));
        }

        [HttpGet("GetData")]
        public async Task<IActionResult> GetDataTakeAnswerAsync()
        {
            var result = await _takeAnswer.GetTakeAnSwerAsync();
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateAsync(TakeAnswerWm viewModel)
        {
            var result = await _takeAnswer.CreateTakeAnswerAsync(viewModel);
            if (result == null) return BadRequest();
            else return Ok();
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAsync(Guid Id, TakeAnswerWm viewModeWm)
        {
            var result = await _takeAnswer.UpdateTakeAnswerAsync(Id, viewModeWm);
            if (result == null) return BadRequest();
            else return Ok();
        }

        [HttpDelete("Remove")]
        public async Task<IActionResult> RemoveAsync(Guid Id)
        {
            var result = await _takeAnswer.DeleteTakeAnswerAsync(Id);
            if (result == null) return BadRequest();
            else return Ok();
        }
    }
}
