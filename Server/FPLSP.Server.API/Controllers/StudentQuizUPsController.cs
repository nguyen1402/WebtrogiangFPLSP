using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.StudentQuizUPVm;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentQuizUPsController : ControllerBase
    {
        private readonly IStudentQuizUPServices _repo;
        public StudentQuizUPsController(IStudentQuizUPServices repo)
        {
            _repo = repo;
        }


        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _repo.GetAllAsync();
            return Ok(data);

        }
        [HttpGet("{specializedId}/{lecturerid}")]
        public async Task<IActionResult> Get(Guid specializedId, Guid lecturerid)
        {
            if (string.IsNullOrEmpty(specializedId.ToString())) return BadRequest();
            var result = await _repo.GetbyId(specializedId, lecturerid);
            if (result == null)
                return BadRequest();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] StudentQuizCreateUPVM create)
        {
            if (create == null)
            {
                return BadRequest();
            }

            var result = await _repo.Create(create);
            if (result != 1)
                return BadRequest();
            return Ok();
        }

        [HttpPut("{studenId}/{quizId}")]
        public async Task<IActionResult> Update(Guid studenId, Guid quizId, [FromBody] StudentQuizUpdateUPVM studenquiz_update)
        {
            if (studenquiz_update == null || string.IsNullOrEmpty(quizId.ToString())) return BadRequest();

            var result = await _repo.Update(studenId, quizId, studenquiz_update);
            if (result != 1)
                return BadRequest();
            return Ok();
        }

        [HttpDelete("{studenId}/{quizId}")]
        public async Task<IActionResult> Delete(Guid studenId, Guid quizId)
        {
            if (string.IsNullOrEmpty(studenId.ToString())) return BadRequest();

            var result = await _repo.Delete(studenId, quizId);
            if (result != 1)
                return BadRequest();
            return Ok();
        }
    }
}
