using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.LectuterSpecializedCP;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectuterSpecializedUPsController : ControllerBase
    {
        private readonly ILectuterSpecializedUPServices _repo;
        public LectuterSpecializedUPsController(ILectuterSpecializedUPServices repo)
        {
            _repo = repo;
        }

        [HttpGet("getall/{specializedId}")]
        public async Task<IActionResult> Get(Guid specializedId, [FromQuery] LectuterSpecializedCPListSearch parameters)
        {
            var pagel = await _repo.GetPagingParamets(specializedId, parameters);
            var data = pagel.Items.Select(x => new LectuterSpecializedCPDto()
            {
                Idspecialized = x.Idspecialized,
                Idlecturers = x.Idlecturers,
                Email = x.Email,
                Dob = x.Dob,
                Gender = x.Gender,
                PhoneNumber = x.PhoneNumber,
                Address = x.Address,
                Ethnic = x.Ethnic,
                ImageUrl = x.ImageUrl,
                Status = x.Status,
                SpecializationName = x.SpecializationName,
                SpecializedCode = x.SpecializedCode,
            });
            return Ok(new PageList<LectuterSpecializedCPDto>(data.ToList(),
                pagel.MetaData.TotalPages,
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
        public async Task<IActionResult> Add(Guid specializedId, [FromBody] LectuterSpecializedCPCreateVM lesson)
        {
            if (lesson == null) return BadRequest();
            var result = await _repo.Create(specializedId, lesson);
            if (result != 1)
                return BadRequest();
            return Ok();
        }

        [HttpPut("{specializedId}/{lecturerid}")]
        public async Task<IActionResult> Update(Guid specializedId, Guid lecturerid, [FromBody] LectuterSpecializedCPUpdateVM lesson_update)
        {
            if (lesson_update == null || string.IsNullOrEmpty(specializedId.ToString())) return BadRequest();

            var result = await _repo.Update(specializedId, lecturerid, lesson_update);
            if (result != 1)
                return BadRequest();
            return Ok();
        }

        [HttpDelete("{specializedId}/{lecturerid}")]
        public async Task<IActionResult> Delete(Guid specializedId, Guid lecturerid)
        {
            if (string.IsNullOrEmpty(specializedId.ToString())) return BadRequest();

            var result = await _repo.Delete(specializedId, lecturerid);
            if (result != 1)
                return BadRequest();
            return Ok();
        }
    }
}
