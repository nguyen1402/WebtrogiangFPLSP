using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubmitHomeworkForStudentsController : ControllerBase
    {
        private readonly ISubmitHomeworkForStudentServices _submitForStuServices;
        public SubmitHomeworkForStudentsController(ISubmitHomeworkForStudentServices submitForStuServices)
        {
            _submitForStuServices = submitForStuServices;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllSubmit()
        {
            var submits = await _submitForStuServices.Student_GetAllAsync();

            return Ok(submits);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetSubmitById(Guid id)
        {
            var submit = await _submitForStuServices.Student_GetSubmitByIdAsync(id);
            return Ok(submit);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateLecturer(Guid id, [FromBody] SubmitHomeWorkForStudentUpdateVm summitUpdate)
        {
            var summit = await _submitForStuServices.Student_GetSubmitByIdAsync(id);
            if (summit == null)
            {
                return NotFound();
            }
            await _submitForStuServices.Student_Update(id, summitUpdate);
            return Ok();
        }

    }
}
