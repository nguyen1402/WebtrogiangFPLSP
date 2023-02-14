using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.Subject;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjectServices _repo;

        public SubjectsController(ISubjectServices repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Lấy ra danh sách môn học của chuyên ngành được chọn theo keyword 
        /// </summary>
        /// <param name="idspec"> id chuyên ngành</param>
        /// <param name="monhocParameters"> keyword để search </param>
        /// <returns> trả về danh sách môn học của chuyên ngành được chọn theo keyword </returns>
        [HttpGet("all/{idspec}")]
        public async Task<IActionResult> Get(Guid idspec, [FromQuery] SubjectCPSearch monhocParameters)
        {
            var pagelist = await _repo.GetSubjects(idspec, monhocParameters);

            var MonhocDTOs = pagelist.Items.Select(c => new SubjectDto()
            {
                Id = c.Id,
                SubjectCode = c.SubjectCode,
                SubjectName = c.SubjectName,
                CreatedDay = c.CreatedDay,
                StartDay = c.StartDay,
                EndDay = c.EndDay,
                Image = c.Image,
                TotalOfSub = c.TotalOfSub,
                Status = c.Status,
                countLesson = c.countLesson,
                countQuiz = c.countQuiz,
                IsDemo = c.IsDemo,
            });
            return Ok(new PageList<SubjectDto>(MonhocDTOs.ToList(),
                pagelist.MetaData.TotalCount,
                pagelist.MetaData.CurrentPage,
                pagelist.MetaData.PageSize));
        }

        /// <summary>
        /// Lấy ra tất môn học
        /// </summary>
        /// <returns>danh sách môn học</returns>
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var Monhocs = await _repo.GetAllSubjectAsync();

            return Ok(Monhocs);
        }

        [HttpGet("allsubjectbyidspecialzed/{idspecialzed}")]
        public async Task<IActionResult> GetAllSubjectByIdSpecialzed(Guid idspecialzed)
        {
            var Monhocs = await _repo.GetAllSubjectByIdSpecialzed(idspecialzed);

            return Ok(Monhocs);
        }

        /// <summary>
        /// Lấy ra môn học có id được truyền vào
        /// </summary>
        /// <param name="id"> id môn học</param>
        /// <returns> trả về môn học có id được truyền vào </returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetbyId(Guid id)
        {
            var subject = await _repo.GetSubjectbyId(id);
            return Ok(subject);
        }

        [HttpGet("GetUpdateSubjectbyId/{idupdate}")]
        public async Task<IActionResult> GetUpdateSubjectbyId(Guid idupdate)
        {
            var subjectupdate = await _repo.GetUpdateSubjectbyId(idupdate);
            return Ok(subjectupdate);
        }

        /// <summary>
        /// thêm mới môn học
        /// </summary>
        /// <param name="subject"> nơi chứa thông tin đối tượng muốn thêm </param>
        /// <returns> trả về BadRequest nếu đối tượng đó rỗng hoặc sai hoặc thiếu thông tin.
        /// trả về đối tượng nếu đối tượng đó hợp lệ </returns>
        [HttpPost]
        public async Task<IActionResult> CreateSubject([FromBody] SubjectCreateVM subject)
        {
            if (subject == null)
                return BadRequest();

            var kq = await _repo.CreateSubject(subject);
            if (kq != 1)
            {
                return BadRequest(kq);
            }
            return Ok(kq);
        }

        /// <summary>
        /// cập nhật đối tượng có id bằng với được truyền vào bằng các thông tin đối tượng được truyền vào là subject
        /// </summary>
        /// <param name="id"> id môn học</param>
        /// <param name="subject"> thông tin đối tượng được truyền vào</param>
        /// <returns> trả về BadRequest nếu không tìm thấy id hoặc đối tượng truyền vào bị null
        /// trả về đối tượng có id được truyền vào bằng các thông tin đối tượng được truyền vào cùng là subject </returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSubject(Guid id, [FromBody] SubjectUpdateVM subject)
        {
            //var subjectdb = await _repo.GetSubjectbyId(id);

            if (subject == null)
                return BadRequest();

            var kq = await _repo.UpdateSubject(id, subject);
            if (kq != 1)
            {
                return BadRequest(kq);
            }
            return Ok(kq);
        }

        /// <summary>
        /// Xóa đối tượng có id bằng với id được truyền vào
        /// </summary>
        /// <param name="id"> id môn học</param>
        /// <returns>trả về đối tượng đã được xóa</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubject(Guid id)
        {
            //var subjectdb = await _repo.GetSubjectbyId(id);
            if (id == null)
                return BadRequest();

            var result = await _repo.DeleteSubject(id);
            if (result != 1)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPost("deletelist")]
        public async Task<IActionResult> DeleteListSubject([FromBody] List<Guid> listIdSubject)
        {
            var report = _repo.RemoveListSubjectCP(listIdSubject);
            if (report.Result)
            {
                return Ok("Xóa thành công");
            }
            return BadRequest("Xóa thất bại");
        }
    }
}
