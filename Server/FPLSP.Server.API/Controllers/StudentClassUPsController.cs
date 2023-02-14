using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.StudentClassUPDtos;
using FPLSP.Server.Domain.Dtos.StudentUPDtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.StudentClassUPVm;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentClassUPsController : ControllerBase
    {
        private IStudentClassUPServices _Services;

        public StudentClassUPsController(IStudentClassUPServices services)
        {
            _Services = services;
        }

        [HttpGet("{idClass}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
        {
            var result = await _Services.GetStudentClassUPById(id);
            return Ok(result);
        }


        [HttpPost("createStudentInClass")]
        public async Task<IActionResult> CreateStudentByEmail(StudentUpDto studentInClassCreate)
        {
            var StudentMapp = new StudentUP()
            {
                Email = studentInClassCreate.Email,
                Ethnic = studentInClassCreate.Ethnic,
                Address = studentInClassCreate.Address,
                DateOfBirth = studentInClassCreate.DateOfBirth,
                Description = studentInClassCreate.Description,
                FathersName = studentInClassCreate.FathersName,
                Gender = studentInClassCreate.Gender,
                HomeTown = studentInClassCreate.HomeTown,
                Id = studentInClassCreate.Id,
                IdentityCardNumber = studentInClassCreate.IdentityCardNumber,
                ImageUrl = studentInClassCreate.ImageUrl,
                IssuedOn = studentInClassCreate.IssuedOn,
                MotherName = studentInClassCreate.MotherName,
                Password = studentInClassCreate.Password,
                PhoneNumber = studentInClassCreate.PhoneNumber,
                Status = studentInClassCreate.Status,
                StudentCode = studentInClassCreate.StudentCode,
                StudentName = studentInClassCreate.StudentName
            };
            var result = await _Services.CreateStudentbyEmail(StudentMapp);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] StudentClassUPSearch searchVm)
        {
            var result = await _Services.GetStudentClassUPList(searchVm);


            var Dto = result.Items.Select(c => new StudentClassUPDtos()
            {
                ClassId = c.ClassId,
                JoinCodeAsign = c.JoinCodeAsign,
                Status = c.Status,
                StudentId = c.StudentId,
                StatusOfStudent = c.StatusOfStudent

            });

            return Ok(new PageList<StudentClassUPDtos>(Dto.ToList(),
            result.MetaData.TotalCount, result.MetaData.CurrentPage, result.MetaData.PageSize));

        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var student = await _Services.GetAllStudentUPAsync();

            return Ok(student);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(StudentClassUPCreateVm createVm)
        {
            var create = await _Services.CreateStudentClassUP(new StudentClassUP()
            {
                ClassId = createVm.ClassId,
                Status = createVm.Status,
                JoinCodeAsign = createVm.JoinCodeAsign,
                StudentId = createVm.StudentId,
                StatusOfStudent = createVm.StatusOfStudent
            });
            return Ok(create);
        }

        [HttpPut]
        [Route("{idClass}/{idStudent}")]
        public async Task<IActionResult> Update(Guid idClass, Guid idStudent, StudentClassUPUpdateVm StudentClassUPUpdateVm)
        {
            var update = await _Services.UpdateStudentClassUP(idClass, idStudent, StudentClassUPUpdateVm);
            return Ok(update);
        }

        [HttpDelete]
        [Route("{joicode}/{idStudent}")]
        public async Task<IActionResult> Delete(string joicode, Guid idStudent)
        {
            var delete = await _Services.DeleteStudentClassUP(joicode, idStudent);
            return Ok(delete);

        }
    }
}
