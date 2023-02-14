using FPLSP.Server.Data.FPLSPDbContext;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.LessonContentUP;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{

    //api​/LessonContentUPs​
    [Route("api/[controller]")]
    [ApiController]
    public class LessonContentUPsController : ControllerBase
    {
        private readonly ILessonContentUPServices _LessonContentUPservices;
        private ApplicationDbContext _applicationDbContext;

        public LessonContentUPsController(ILessonContentUPServices LessonContentUPservices, ApplicationDbContext applicationDbContext, ILogger<LessonContentUPsController> logger)
        {
            _LessonContentUPservices = LessonContentUPservices ?? throw new ArgumentNullException(nameof(LessonContentUPservices));
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }

        //api​/LessonContentUPs​
        [HttpGet]
        public async Task<IActionResult> GetLessonContentUPs([FromQuery] LessonContentUPListSearch search)
        {
            var pageList = await _LessonContentUPservices.GetLessonContentUPs(search);

            var data = pageList.Items.Select(c => new LessonContentUPViewModel()
            {
                Id = c.Id,
                Content = c.Content,
                Descriptions = c.Descriptions,
                LessonContentCode = c.LessonContentCode,
                LessonContentName = c.LessonContentName,
                Status = c.Status,
                LessonId = c.LessonId,
                ResuorceLinkId = c.ResuorceLinkId
            });

            return Ok(
                    new PageList<LessonContentUPViewModel>(data.ToList(),
                        pageList.MetaData.TotalCount,
                        pageList.MetaData.CurrentPage,
                        pageList.MetaData.PageSize));
        }

        //api​/ResourceLinkUPs​/all
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var LessonContentUPs = await _LessonContentUPservices.GetAll();

            return Ok(LessonContentUPs);
        }

        //api​/LessonContentUPs​/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _LessonContentUPservices.GetById(id);
            if (result == null)
            {
                return BadRequest($"Cannot find a LessonContentUP with id: {id}");
            }
            return Ok(result);
        }
        [HttpPost("deletelist")]
        public async Task<IActionResult> RemoveAll([FromBody] List<Guid> listIdSubject)
        {
            var report = _LessonContentUPservices.RemoveAll(listIdSubject);
            if (report.Result)
            {
                return Ok("Xóa thành công");
            }
            return BadRequest("Xóa thất bại");
        }
        //api​/LessonContentUPs​
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] LessonContentUPCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (request.LessonId != null)
            {
                var subject = _applicationDbContext.LessonUPs.FirstOrDefault(x => x.Id == request.LessonId);
                if (subject == null)
                {
                    return BadRequest("Can not create a LessonContentUP. LessonId is not valid!");
                }
            }
            if (request.ResuorceLinkId != null)
            {
                var subject = _applicationDbContext.ResourceLinkUPs.FirstOrDefault(x => x.Id == request.ResuorceLinkId);
                if (subject == null)
                {
                    return BadRequest("Can not create a LessonContentUP. ResuorceLinkId is not valid!");
                }
            }

            var result = await _LessonContentUPservices.Create(request);
            if (result == null)
            {
                return BadRequest("Can not create a LessonContentUP. Please try again later!");
            }
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        //api​/LessonContentUPs​/{id}
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] LessonContentUPUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (request.LessonId != null)
            {
                var subject = _applicationDbContext.LessonUPs.FirstOrDefault(x => x.Id == request.LessonId);
                if (subject == null)
                {
                    return BadRequest("Can not update a LessonContentUP. LessonId is not valid!");
                }
            }
            if (request.ResuorceLinkId != null)
            {
                var subject = _applicationDbContext.ResourceLinkUPs.FirstOrDefault(x => x.Id == request.ResuorceLinkId);
                if (subject == null)
                {
                    return BadRequest("Can not update a LessonContentUP. ResuorceLinkId is not valid!");
                }
            }

            var affectedResult = await _LessonContentUPservices.Update(id, request);
            if (affectedResult == 0)
            {
                return BadRequest($"Cannot find a LessonContentUP with id: {id}");
            }
            return Ok("Updated successfully");
        }

        //api​/LessonContentUPs​/{id}
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var affectedResult = await _LessonContentUPservices.Delete(id);
            if (affectedResult == 0)
            {
                return BadRequest($"Cannot find a LessonContentUP with id: {id}");
            }
            return Ok("Deleted successfully");
        }
    }
}
