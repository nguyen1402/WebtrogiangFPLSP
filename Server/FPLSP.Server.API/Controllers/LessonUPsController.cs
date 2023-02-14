using FPLSP.Server.Data.FPLSPDbContext;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.LessonUP;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{

    //api​/LessonUPs​
    [Route("api/[controller]")]
    [ApiController]
    public class LessonUPsController : ControllerBase
    {
        private readonly ILessonUPServices _LessonUPservices;
        private ApplicationDbContext _applicationDbContext;

        public LessonUPsController(ILessonUPServices LessonUPservices, ApplicationDbContext applicationDbContext, ILogger<LessonUPsController> logger)
        {
            _LessonUPservices = LessonUPservices ?? throw new ArgumentNullException(nameof(LessonUPservices));
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }

        //api​/LessonUPs​
        [HttpGet]
        public async Task<IActionResult> GetLessonUPs([FromQuery] LessonUPListSearch search)
        {
            var pageList = await _LessonUPservices.GetLessonUPs(search);

            var data = pageList.Items.Select(c => new LessonUPViewModel()
            {
                Id = c.Id,
                LessonName = c.LessonName,
                LessonCode = c.LessonCode,
                Descriptions = c.Descriptions,
                IsCompleted = c.IsCompleted,
                Status = c.Status,
                SubjectId = c.SubjectId
            });

            return Ok(
                    new PageList<LessonUPViewModel>(data.ToList(),
                        pageList.MetaData.TotalCount,
                        pageList.MetaData.CurrentPage,
                        pageList.MetaData.PageSize));
        }

        //api​/ResourceLinkUPs​/all
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var LessonUPs = await _LessonUPservices.GetAll();

            return Ok(LessonUPs);
        }
        [HttpGet("allLessonContentCP")]
        public async Task<IActionResult> GetAllSubject()
        {
            var SubjectCP = await _LessonUPservices.GetAllLessonContentCP();

            return Ok(SubjectCP);
        }

        [HttpGet("allLessonCP")]
        public async Task<IActionResult> GetAllLessonCP()
        {
            var LessonCP = await _LessonUPservices.GetAllLessonCP();

            return Ok(LessonCP);
        }
        [HttpGet("allResourceLinkCP")]
        public async Task<IActionResult> GetAllResourceLinkCP()
        {
            var ResourceLinkCP = await _LessonUPservices.GetAllResourceLinkCP();

            return Ok(ResourceLinkCP);
        }

        //api​/LessonUPs​/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _LessonUPservices.GetById(id);
            if (result == null)
            {
                return BadRequest($"Cannot find a LessonUP with id: {id}");
            }
            return Ok(result);
        }

        //api​/LessonUPs​
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] LessonUPCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (request.SubjectId != null)
            {
                var subject = _applicationDbContext.SubjectUPs.FirstOrDefault(x => x.Id == request.SubjectId);
                if (subject == null)
                {
                    return BadRequest("Can not create a LessonUP. SubjectId is not valid!");
                }
            }

            var result = await _LessonUPservices.Create(request);
            if (result == null)
            {
                return BadRequest("Can not create a LessonUP. Please try again later!");
            }
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        //api​/LessonUPs​/{id}
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] LessonUPUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (request.SubjectId != null)
            {
                var subject = _applicationDbContext.SubjectUPs.FirstOrDefault(x => x.Id == request.SubjectId);
                if (subject == null)
                {
                    return BadRequest("Can not update a LessonUP. SubjectId is not valid!");
                }
            }

            var affectedResult = await _LessonUPservices.Update(id, request);
            if (affectedResult == 0)
            {
                return BadRequest($"Cannot find a LessonUP with id: {id}");
            }
            return Ok("Updated successfully");
        }

        //api​/LessonUPs​/{id}
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var affectedResult = await _LessonUPservices.Delete(id);
            if (affectedResult == 0)
            {
                return BadRequest($"Cannot find a LessonUP with id: {id}");
            }
            return Ok("Deleted successfully");
        }
        [HttpPost("deletelist")]
        public async Task<IActionResult> DeleteListLesson([FromBody] List<Guid> listIdSubject)
        {
            var report = _LessonUPservices.RemoveListLessonUP(listIdSubject);
            if (report.Result)
            {
                return Ok("Xóa thành công");
            }
            return BadRequest("Xóa thất bại");
        }
    }
}
