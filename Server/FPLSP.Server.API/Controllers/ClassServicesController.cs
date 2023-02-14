using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassServicesController : ControllerBase
    {
        private readonly IClassSubjectServices _repo;
        public ClassServicesController(IClassSubjectServices repo)
        {
            _repo = repo;
        }

        [HttpGet("getall/{subjectId}/{lecuId}/{specializedId}")]
        public async Task<IActionResult> Get(Guid subjectId, Guid lecuId, Guid specializedId, [FromQuery] SubjectServicesCPListSearch parameters)
        {
            var pagel = await _repo.GetPagingParamets(subjectId, lecuId, specializedId, parameters);
            var data = pagel.Items.Select(x => new ClassSubjectUPDto()
            {
                LectuterId = x.LectuterId,
                SpecializedId = x.SpecializedId,
                SubjectId = x.SubjectId,
                ClassId = x.ClassId,
                JoinCode = x.JoinCode,
                ClassroomName = x.ClassroomName,
                CreatedDayClass = x.CreatedDayClass,
                ClassroomCode = x.ClassroomCode,
                Building = x.Building,
                StudentAmount = x.StudentAmount,
                StatusClass = x.StatusClass,
                StatusSubjectClass = x.StatusSubjectClass,
                SubjectName = x.SubjectName,
                Sinhvienthucte = x.Sinhvienthucte,
            });
            return Ok(new PageList<ClassSubjectUPDto>(data.ToList(),
                pagel.MetaData.TotalCount,
                pagel.MetaData.CurrentPage,
                pagel.MetaData.PageSize));
        }
        [HttpGet("getlistidquiz/{subjectId}")]
        public async Task<IActionResult> GetlsIdquiz(Guid subjectId)
        {
            var list = await _repo.GetListIdQuiz(subjectId);

            return Ok(list);
        }

        [HttpGet("getAllSubjectClass")]
        public async Task<IActionResult> getAllSubClass()
        {
            var list = await _repo.GetAllSubjectClass();
            return Ok(list);
        }


        [HttpGet("getClassUPByIdClass/{idClass}")]
        public async Task<IActionResult> getAllSubClass(Guid idClass)
        {
            var classUP = await _repo.GetClassUPbyId(idClass);
            return Ok(classUP);
        }

        [HttpGet("getlistClassUP/{subjectId}")]
        public async Task<IActionResult> GetlstClassUP(Guid subjectId)
        {
            var list = await _repo.GetClassUPBySubjectID(subjectId);

            return Ok(list);
        }

        [HttpDelete("{idclass}")]
        public async Task<IActionResult> Delete(Guid idclass)
        {
            if (idclass.ToString() == null) return BadRequest();
            var result = await _repo.Delete(idclass);
            if (result != 1)
                return BadRequest();
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] SubjectClassVM classUp)
        {
            if (classUp == null) return BadRequest();
            var result = await _repo.Create(classUp);
            if (result != 1)
                return BadRequest();
            return Ok();
        }
    }
}
