using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.SubjectsSpecializedVM;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsSpecializedCPsController : ControllerBase
    {
        private readonly ISubjectsSpecializedCPServices _repo;
        public SubjectsSpecializedCPsController(ISubjectsSpecializedCPServices repo)
        {
            _repo = repo;
        }

        [HttpGet("getall/{specializedId}")]
        public async Task<IActionResult> Get(Guid specializedId, [FromQuery] SubjectsSpecializedCPListSearch parameters)
        {
            var pagel = await _repo.GetPagingParamets(specializedId, parameters);
            var data = pagel.Items.Select(x => new SubjectsSpecializedDtos()
            {
                SpecializedId = x.SpecializedId,
                SubjectId = x.SubjectId,
                SubjectName = x.SubjectName,
                SpecializationName = x.SpecializationName,
                StatusSpecialized = x.StatusSpecialized,
                StartDay = x.StartDay,
                EndDay = x.EndDay,
                TotalOfSub = x.TotalOfSub,
                Image = x.Image,
                StatusSubject = x.StatusSubject,
            });
            return Ok(new PageList<SubjectsSpecializedDtos>(data.ToList(),
                pagel.MetaData.TotalCount,
                pagel.MetaData.CurrentPage,
                pagel.MetaData.PageSize));
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _repo.GetAllAsync();
            return Ok(data);

        }
        [HttpGet("{specializedId}/{lecturerid}")]
        public async Task<IActionResult> Get(Guid specializedId, Guid lecturerid)
        {
            if (string.IsNullOrEmpty(specializedId.ToString())) return BadRequest();
            var result = await _repo.GetbyId(specializedId, lecturerid);
            if (result == null)
                return BadRequest();
            return Ok(result);
        }
        [HttpPost("{specializedId}")]
        public async Task<IActionResult> Add(Guid specializedId, [FromBody] SubjectsSpecializedCreateVM lesson)
        {
            if (lesson == null) return BadRequest();
            var result = await _repo.Create(specializedId, lesson);
            if (result != 1)
                return BadRequest();
            return Ok();
        }
    }
}
