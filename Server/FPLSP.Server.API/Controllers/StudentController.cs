using AutoMapper;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Dtos.StudentUPDtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop;
using FPLSP.Server.Infrastructure.ViewModels.StudentStatistics;
using FPLSP.Server.Infrastructure.ViewModels.StudentsUPVm;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentUpServices _studentServices;
        private readonly IMapper _mapper;

        public StudentController(IStudentUpServices studentServices, IMapper mapper)
        {
            _studentServices = studentServices;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] StudentUPListSearchVm student)
        {
            var pagelist = await _studentServices.GetStudentList(student);

            var MonhocDTOs = pagelist.Items.Select(c => new StudentUpDto()
            {
                Id = c.Id,
                StudentCode = c.StudentCode,
                StudentName = c.StudentName,
                Gender = Convert.ToBoolean(c.Gender),
                DateOfBirth = Convert.ToDateTime(c.DateOfBirth),
                Email = c.Email,
                Password = c.Password,
                Address = c.Address,
                PhoneNumber = c.PhoneNumber,
                IdentityCardNumber = c.IdentityCardNumber,
                IssuedOn = Convert.ToDateTime(c.IssuedOn),
                ImageUrl = c.ImageUrl,
                Description = c.Description,
                FathersName = c.FathersName,
                MotherName = c.MotherName,
                HomeTown = c.HomeTown,
                Status = Convert.ToInt32(c.Status)
            });
            return Ok(new PageList<StudentUpDto>(MonhocDTOs.ToList(),
                pagelist.MetaData.TotalCount,
                pagelist.MetaData.CurrentPage,
                pagelist.MetaData.PageSize));
        }
        [HttpGet("get/thongtin/lop/{idc}/{idsubject}")]
        public async Task<IActionResult> GetThongTinLop(Guid idc, Guid idsubject)
        {
            var _thongtinlop = await _studentServices.Thongtinlop(idc, idsubject);
            return Ok(_thongtinlop);
        }
        [HttpGet("getall/{idclass}/{idsubject}")]
        public async Task<IActionResult> GetlsStudentStatisticsDtos(Guid idclass, Guid idsubject, [FromQuery] StudentStatisticListSearch studentParameters)
        {
            var pagelist = await _studentServices.StudentStatisticsDtos(idsubject, idclass, studentParameters);

            var MonhocDTOs = pagelist.Items.Select(x => new StudentStatisticsDtos()
            {
                IdStudent = x.IdStudent,
                StudentCode = x.StudentCode,
                StudentName = x.StudentName,
                Gender = x.Gender,
                DateOfBirth = x.DateOfBirth,
                CountDonSubmit = x.CountDonSubmit,
                CountSubmit = x.CountSubmit,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                Address = x.Address,
                ImageUrl = x.ImageUrl,
                Link = x.Link,
                Quiz = x.Quiz,
                Baitap = x.Baitap,
                CountSV = x.CountSV,
                Listidlesson = x.Listidlesson,
                ListidQuiz = x.ListidQuiz,
            });
            return Ok(new PageList<StudentStatisticsDtos>(MonhocDTOs.ToList(),
                pagelist.MetaData.TotalCount,
                pagelist.MetaData.CurrentPage,
                pagelist.MetaData.PageSize));
        }

        [HttpGet("getall/quiz/{idclass}/{idsubject}")]
        public async Task<IActionResult> GetlsQuizStatisticsDtos(Guid idclass, Guid idsubject, [FromQuery] StudentStatisticListSearch studentParameters)
        {
            var pagelist = await _studentServices.QuizStatisticsDtos(idsubject, idclass, studentParameters);

            var MonhocDTOs = pagelist.Items.Select(x => new StudentStatisticsDtos()
            {
                IdStudent = x.IdStudent,
                StudentCode = x.StudentCode,
                StudentName = x.StudentName,
                Gender = x.Gender,
                DateOfBirth = x.DateOfBirth,
                CountDonSubmit = x.CountDonSubmit,
                CountSubmit = x.CountSubmit,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                Address = x.Address,
                ImageUrl = x.ImageUrl,
                Link = x.Link,
                Quiz = x.Quiz,
                Baitap = x.Baitap,
                CountSV = x.CountSV,
                Listidlesson = x.Listidlesson,
                ListidQuiz = x.ListidQuiz,
                Diemtrungbinh = x.Diemtrungbinh,
            });
            return Ok(new PageList<StudentStatisticsDtos>(MonhocDTOs.ToList(),
                pagelist.MetaData.TotalCount,
                pagelist.MetaData.CurrentPage,
                pagelist.MetaData.PageSize));
        }

        [HttpGet("getall/list/{idclass}")]
        public async Task<IActionResult> GetlsIdquiz(Guid idclass)
        {
            var list = await _studentServices.GetListIdStudents(idclass);

            return Ok(list);
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var student = await _studentServices.GetAllStudentUPAsync();
            return Ok(student);
        }
        [HttpGet("allStudentDto")]
        public async Task<IActionResult> GetAllStudentDto()
        {
            var student = await _studentServices.GetStudentsAsync();
            return Ok(student);
        }

        [HttpGet("maxId")]
        public async Task<IActionResult> GetMaxId()
        {
            var maxId = await _studentServices.GetStudentUPMaxId();

            return Ok(maxId);
        }



        [HttpPost]
        public async Task<IActionResult> CreateStudent([FromBody] StudentUPCreateVm student)
        {
            if (student == null)
                return BadRequest();

            var newstudent = await _studentServices.CreateStudentUP(student);

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
            var student = await _studentServices.GetStudentUPbyId(id);
            if (student == null) return NotFound($"{id} is not found");
            return Ok(student);

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudentCP(Guid id, [FromBody] StudentUpdateVM students)
        {

            if (students == null)
                return BadRequest();

            var kq = await _studentServices.UpdateStudentUP(id, students);
            if (kq != 1)
            {
                return BadRequest(kq);
            }
            return Ok(kq);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var delete = await _studentServices.Delete(id);
            return Ok(delete);

        }
        [HttpPost("RemoveRange")]
        public async Task<IActionResult> Delete(StudentRemovRangeVM viewModel)
        {
            var delete = await _studentServices.DeleteRange(viewModel.ListGuisId);
            return Ok(delete);

        }
    }
}
