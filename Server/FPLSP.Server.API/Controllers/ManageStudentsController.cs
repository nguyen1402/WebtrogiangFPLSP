using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageStudentsController : ControllerBase
    {

        private readonly IManageStudentUpServices _manageStudentUpServices;

        public ManageStudentsController(IManageStudentUpServices manageStudentUpServices)
        {
            _manageStudentUpServices = manageStudentUpServices;
        }

        [HttpGet("{id}")]

        public async Task<List<ManageStudentUpDto>> GetStudentsAsync(Guid id)
        {
            var result = await _manageStudentUpServices.GetListStudentsInClass(id);
            return result;
        }


        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateStudent(CreateStudentInClassDto createStudentInClassDto)
        {
            var result = await _manageStudentUpServices.AddStudentToClass(createStudentInClassDto);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteStudent(Guid id)
        {
            await _manageStudentUpServices.RemoveStudentFromClass(id);
            return Ok();

        }
    }
}
