using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.Lesson;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonCPsController : ControllerBase
    {
        private readonly ILessonCPServices _repo;
        public LessonCPsController(ILessonCPServices repo)
        {
            _repo = repo;
        }

        [HttpGet("getall/{subjectId}")]
        public async Task<IActionResult> Get(Guid subjectId, [FromQuery] LessonListSearch parameters)
        {
            var pagel = await _repo.GetLessons(subjectId, parameters);

            var data = pagel.Items.Select(c => new LessonDto()
            {
                Id = c.Id,
                SubjectId = c.SubjectId,
                LessonName = c.LessonName,
                LessonCode = c.LessonCode,
                Descriptions = c.Descriptions,
                SubjectCode = c.SubjectCode,
                SubjectName = c.SubjectName,
                TotalOfSub = c.TotalOfSub,
                Status = c.Status,
                Index=c.Index
            });
            return Ok(new PageList<LessonDto>(data.ToList(),
                pagel.MetaData.TotalCount,
                pagel.MetaData.CurrentPage,
                pagel.MetaData.PageSize));

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            if (string.IsNullOrEmpty(id.ToString())) return BadRequest();
            var result = await _repo.GetbyId(id);
            if (result == null)
                return BadRequest();
            return Ok(result);

        }

        [HttpPost("{subjectId}")]
        public async Task<IActionResult> Add(Guid subjectId, [FromBody] LessonCreateVM lessonnew)
        {
            if (lessonnew == null) return BadRequest();
            var result = await _repo.CreateLesson(subjectId, lessonnew);
            if (result != 1)
                return BadRequest();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] LessonUpdateVM lessonnud)
        {
            if (lessonnud == null || string.IsNullOrEmpty(id.ToString())) return BadRequest();

            var result = await _repo.UpdateLesson(id, lessonnud);
            if (result != 1)
                return BadRequest();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (string.IsNullOrEmpty(id.ToString())) return BadRequest();

            var result = await _repo.DeleteLesson(id);
            if (result != 1)
                return BadRequest();
            return Ok();
        }

        [HttpPost("deletelist")]
        public async Task<IActionResult> DeleteListLesson([FromBody] List<Guid> listIdSubject)
        {
            var report = _repo.RemoveListLessonCP(listIdSubject);
            if (report.Result)
            {
                return Ok("Xóa thành công");
            }
            return BadRequest("Xóa thất bại");
        }

        [HttpGet("alllessonbyid/{lessonId}")]
        public async Task<IActionResult> GetAll(Guid lessonId)
        {
            var pagel = await _repo.GetAllAsync(lessonId);

            return Ok(pagel);

        }  
        [HttpGet("GetAllLesson")]
        public async Task<IActionResult> GetAllLesson(Guid lessonId)
        {
            var pagel = await _repo.GetAllLesson();

            return Ok(pagel);

        }
    }
}
