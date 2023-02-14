using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.Specialized;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecializedCPsController : ControllerBase
    {
        private readonly ISpecializedCPServices _res;
        public SpecializedCPsController(ISpecializedCPServices res)
        {
            _res = res;
        }
        [HttpGet("all/{idBo}")]
        public async Task<IActionResult> Get(Guid idBo, [FromQuery] SpecializedListSearch parameters)
        {
            var pagels = await _res.GetSpecializeds(idBo, parameters);

            var data = pagels.Items.Select(x => new SpecializedDto()
            {
                SpecializedCode = x.SpecializedCode,
                SpecializationName = x.SpecializationName,
                Status = x.Status,
                Id = x.Id,
                Image = x.Image,
                IdSpeciality = x.IdSpeciality,
            });
            return Ok(new PageList<SpecializedDto>(data.ToList(),
                pagels.MetaData.TotalCount,
                pagels.MetaData.CurrentPage,
                pagels.MetaData.PageSize));
        }

        [HttpGet("allpaging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] SpecializedListSearch parameters)
        {
            var pagels = await _res.GetAllSpecializeds(parameters);

            var data = pagels.Items.Select(x => new SpecializedDto()
            {
                SpecializedCode = x.SpecializedCode,
                SpecializationName = x.SpecializationName,
                Status = x.Status,
                Id = x.Id,
                Image = x.Image,
                IdSpeciality = x.IdSpeciality,
            });
            return Ok(new PageList<SpecializedDto>(data.ToList(),
                pagels.MetaData.TotalCount,
                pagels.MetaData.CurrentPage,
                pagels.MetaData.PageSize));
        }

        [HttpGet("tatca/{idspec}")]
        public async Task<IActionResult> GetAll(Guid idspec)
        {
            var data = await _res.GetAllAsync(idspec);
            return Ok(data);
        }

        [HttpGet("loc/tatcalever/{lever}")]
        public async Task<IActionResult> Loc(int lever)
        {
            var data = await _res.LoctheoLever(lever);
            return Ok(data);
        }

        [HttpGet("getall/tatca")]
        public async Task<IActionResult> GetAllAsync()
        {
            var data = await _res.GetAll();
            return Ok(data);
        }



        [HttpGet("{idBo}/{id}")]
        public async Task<IActionResult> GetbyId(Guid idBo, Guid id)
        {
            if (string.IsNullOrEmpty(id.ToString())) return BadRequest();
            var data = await _res.GetbyId(idBo, id);
            return Ok(data);
        }
        [HttpPost("{idBo}")]
        public async Task<IActionResult> CreatesSecialized(Guid idBo, [FromBody] SpecializedVM specializedcr)
        {
            if (specializedcr == null)
                return BadRequest();

            var kq = await _res.CreateSpecialized(idBo, specializedcr);
            if (kq != 1)
            {
                return BadRequest(kq);
            }
            return Ok(kq);
        }

        [HttpPut("{idBo}/{id}")]
        public async Task<IActionResult> UpdateSecialized(Guid idBo, Guid id, [FromBody] SpecializedVM specializedud)
        {

            if (specializedud == null)
                return BadRequest();

            var kq = await _res.UpdateSpecialized(idBo, id, specializedud);
            if (kq != 1)
            {
                return BadRequest(kq);
            }
            return Ok(kq);
        }
        [HttpDelete("{idBo}/{id}")]
        public async Task<IActionResult> DeleteSecialized(Guid idBo, Guid id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
                return BadRequest();

            var result = await _res.DeleteSpecialized(idBo, id);
            if (result != 1)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
