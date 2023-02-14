using FPLSP.Server.Data.FPLSPDbContext;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.VideoHistoryVm;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    //api​/VideoHistories​
    [Route("api/[controller]")]
    [ApiController]
    public class VideoHistoriesController : ControllerBase
    {
        private readonly IVideoHistoryServices _VideoHistorieservices;
        private ApplicationDbContext _applicationDbContext;

        public VideoHistoriesController(IVideoHistoryServices VideoHistorieservices, ApplicationDbContext applicationDbContext, ILogger<VideoHistoriesController> logger)
        {
            _VideoHistorieservices = VideoHistorieservices ?? throw new ArgumentNullException(nameof(VideoHistorieservices));
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }


        [HttpGet("VideoHistoryDto/{IdStudent}/{IdLesson}")]
        public async Task<IActionResult> GetVideoHistories(Guid IdStudent, Guid IdLesson, [FromQuery] VideoHistoryListSearch search)// còn lỗi 
        {
            var result = await _VideoHistorieservices.ListGetVideo(IdStudent, IdLesson, search);
            return Ok(result);

        }

        //api​/ResourceLinkUPs​/all
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var VideoHistories = await _VideoHistorieservices.GetAll();

            return Ok(VideoHistories);
        }

        //api​/VideoHistories​/{sId}/{lcId}
        [HttpGet("{sId}/{lcId}")]
        public async Task<IActionResult> GetById(Guid sId, Guid lcId)
        {
            var result = await _VideoHistorieservices.GetById(sId, lcId);
            if (result == null)
            {
                return BadRequest($"Cannot find a VideoHistory");
            }
            return Ok(result);
        }

        //api​/VideoHistories​
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] VideoHistoryCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var student = _applicationDbContext.StudentUPs.FirstOrDefault(x => x.Id == request.IdStudent);
            if (student == null)
            {
                return BadRequest("Can not create" +
                    " a VideoHistory. StudentID is not valid!");
            }
            var lessonContent = _applicationDbContext.LessonContentUPs.FirstOrDefault(x => x.Id == request.IdLessonContent);
            if (lessonContent == null)
            {
                return BadRequest("Can not create a VideoHistory. LessonContentID is not valid!");
            }
            if (_applicationDbContext.VideoHistories.FirstOrDefault(x => x.IdStudent == request.IdStudent && x.IdLessonContent == request.IdLessonContent) != null)
            {
                return Ok();
            }

            var result = await _VideoHistorieservices.Create(request);
            return Ok(result);
        }

        //api​/VideoHistories​/{sId}/{lcId}
        [HttpPut]
        [Route("{sId}/{lcId}")]
        public async Task<IActionResult> Update(Guid sId, Guid lcId, [FromBody] VideoHistoryUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var affectedResult = await _VideoHistorieservices.Update(sId, lcId, request);
            if (affectedResult == 0)
            {
                return BadRequest($"Cannot find a VideoHistory");
            }
            return Ok("Updated successfully");
        }
        [HttpPut("uploatList")]
        public async Task<IActionResult> UpdateListVideo([FromBody] List<VideoHistoryDto> request)
        {
            var resutl = await _VideoHistorieservices.UpdateListVideo(request);
            return Ok(resutl);
        }

        //api​/VideoHistories​/{sId}/{lcId}
        [HttpDelete]
        [Route("{sId}/{lcId}")]
        public async Task<IActionResult> Delete(Guid sId, Guid lcId)
        {
            var affectedResult = await _VideoHistorieservices.Delete(sId, lcId);
            if (affectedResult == 0)
            {
                return BadRequest($"Cannot find a VideoHistory");
            }
            return Ok("Deleted successfully");
        }

    }
}
