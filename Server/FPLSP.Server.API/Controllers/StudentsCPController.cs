using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.StudentCPDtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.StudentCP;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsCPController : ControllerBase
    {
        private readonly IStudentCPServices _studentCPServices;
        private readonly ILogger<StudentsCPController> _logger;

        public StudentsCPController(IStudentCPServices studentCPServices, ILogger<StudentsCPController> logger)
        {
            _studentCPServices = studentCPServices ?? throw new ArgumentNullException(nameof(studentCPServices)); ;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] StudentCPListSearch student)
        {
            var pagelist = await _studentCPServices.GetStudentList(student);

            var MonhocDTOs = pagelist.Items.Select(c => new StudentCPDtos()
            {
                Id = c.Id,
                StudentCode = c.StudentCode,
                StudentName = c.StudentName,
                Gender = c.Gender,
                DateOfBirth = c.DateOfBirth,
                Email = c.Email,
                Password = c.Password,
                Address = c.Address,
                PhoneNumber = c.PhoneNumber,
                IdentityCardNumber = c.IdentityCardNumber,
                IssuedOn = c.IssuedOn,
                ImageUrl = c.ImageUrl,
                Description = c.Description,
                FathersName = c.FathersName,
                MotherName = c.MotherName,
                HomeTown = c.HomeTown,
                Status = c.Status
            });
            return Ok(new PageList<StudentCPDtos>(MonhocDTOs.ToList(),
                pagelist.MetaData.TotalCount,
                pagelist.MetaData.CurrentPage,
                pagelist.MetaData.PageSize));
        }


        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var student = await _studentCPServices.GetAllStudentCPAsync();

            return Ok(student);
        }

        [HttpGet("maxId")]
        public async Task<IActionResult> GetMaxId()
        {
            var maxId = await _studentCPServices.GetStudentCPMaxId();

            return Ok(maxId);
        }



        [HttpPost]
        public async Task<IActionResult> CreateStudent([FromBody] CreateStudentCPVm student)
        {
            if (student == null)
                return BadRequest();

            var newstudent = await _studentCPServices.CreateStudentCP(student);

            if (newstudent != 1)
            {
                return BadRequest(newstudent);
            }
            return Ok(newstudent);
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetStudentById([FromRoute] Guid id)
        {
            var student = await _studentCPServices.GetStudentCPbyId(id);
            if (student == null) return NotFound($"{id} is not found");
            return Ok(student);

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudentCP(Guid id, [FromBody] UpdateStudentCPVm subject)
        {

            if (subject == null)
                return BadRequest();

            var kq = await _studentCPServices.UpdateStudentCP(id, subject);
            if (kq != 1)
            {
                return BadRequest(kq);
            }
            return Ok(kq);
        }
    }
}
