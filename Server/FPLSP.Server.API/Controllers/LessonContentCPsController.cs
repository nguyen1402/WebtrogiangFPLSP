using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.LessonContentCP;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonContentCPsController : ControllerBase
    {
        private readonly ILessonContentCPServices _repo;
        public LessonContentCPsController(ILessonContentCPServices repo)
        {
            _repo = repo;
        }

        [HttpPost("{lessonId}")]
        public async Task<IActionResult> Add(Guid lessonId, [FromBody] LessonContentCreateVM lesson)
        {
            if (lesson == null) return BadRequest();
            var result = await _repo.Create(lessonId, lesson);
            if (result != 1)
                return BadRequest();
            return Ok();
        }

        [HttpGet("getall/{lessonId}")]
        public async Task<IActionResult> Get(Guid lessonId, [FromQuery] LessonContentListSearch parameters)
        {
            var pagel = await _repo.GetPagingParamets(lessonId, parameters);
            var data = pagel.Items.Select(x => new LessonContentDto()
            {
                Id = x.Id,

                IdLesson = x.IdLesson,

                ResourceLinkId = x.ResourceLinkId,
                LessonContentCode = x.LessonContentCode,
                LessonContentName = x.LessonContentName,
                Content = x.Content,
                Descriptions = x.Descriptions,
                Pathclone = x.Pathclone,
                Path = x.Path,
                TitleLink = x.TitleLink,
                Status = x.Status,
                Index=x.Index,
            });
            return Ok(new PageList<LessonContentDto>(data.ToList(),
                pagel.MetaData.TotalCount,
                pagel.MetaData.CurrentPage,
                pagel.MetaData.PageSize));

        }


        [HttpGet("lesson/{lessonId}")]
        public async Task<IActionResult> GetAll(Guid lessonId)
        {
            var pagel = await _repo.GetAllAsync(lessonId);

            return Ok(pagel);

        }
        [HttpGet("allLessonContent")]
        public async Task<IActionResult> GetAllLessonContent()
        {
            var pagel = await _repo.GetAllLessonContent();

            return Ok(pagel);

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



        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] LessonContentUpdateVM lesson_update)
        {
            if (lesson_update == null || string.IsNullOrEmpty(id.ToString())) return BadRequest();

            var result = await _repo.Update(id, lesson_update);
            if (result != 1)
                return BadRequest();
            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (string.IsNullOrEmpty(id.ToString())) return BadRequest();

            var result = await _repo.Delete(id);
            if (result != 1)
                return BadRequest();
            return Ok();
        }

        [HttpPost("deletelist")]
        public async Task<IActionResult> DeleteListLesson([FromBody] List<Guid> listIdlessoncontent)
        {
            var report = _repo.RemoveListLessonContentCP(listIdlessoncontent);
            if (report.Result)
            {
                return Ok("Xóa thành công");
            }
            return BadRequest("Xóa thất bại");
        }
    }
}
