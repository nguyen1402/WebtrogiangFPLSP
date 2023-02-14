using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.Subject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers.FPLExam
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectTeachersController : ControllerBase
    {
        private readonly ISubjectTeacherService _repo;

        public SubjectTeachersController(ISubjectTeacherService repo)
        {
            _repo = repo;
        }
        /// <summary>
        /// Tìm kiếm
        /// </summary>
        /// <param name="IdTeacher">Id của giảng viên</param>
        /// <param name="IdSubject">Id của môn học</param>
        /// <returns></returns>
        [HttpGet("{IdTeacher}/{IdSubject}")]
        public async Task<IActionResult> Search(Guid IdTeacher, Guid IdSubject)
        {
            var resual = await _repo.SearchSubjectTeacher(IdTeacher, IdSubject);

            return Ok(resual);
        }
        /// <summary>
        /// Tạo mới
        /// </summary>
        /// <param name="createnew"> đội tượng lấy dữ liệu</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SubjectTeacherViewModel createnew)
        {
            if (createnew == null)
                return BadRequest();

            var resual = await _repo.AddingSubjectTeacher(createnew);
            if (resual != true)
            {
                return BadRequest(resual);
            }
            return Ok(resual);
        }

        /// <summary>
        /// Cập nhật
        /// </summary>
        /// <param name="update">đối tượng lấy dữ liệu</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] SubjectTeacherViewModel update)
        {

            if (update == null)
                return BadRequest();

            var result = await _repo.UpdateSubjectTeacher(update);
            if (result != true)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }


        [HttpDelete("{IdTeacher}/{IdSubject}")]
        public async Task<IActionResult> Delete(Guid IdTeacher, Guid IdSubject)
        {

            if (IdTeacher == Guid.Empty || IdSubject == Guid.Empty)
                return BadRequest();

            var result = await _repo.DeleteSubjectTeacher(IdTeacher, IdSubject);
            if (result != true)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
