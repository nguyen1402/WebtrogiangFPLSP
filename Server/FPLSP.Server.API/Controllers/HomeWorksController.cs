using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.HomeWork;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeWorksController : ControllerBase
    {
        private readonly IHomeWorkServices _repo;

        public HomeWorksController(IHomeWorkServices repo)
        {
            _repo = repo;
        }
        [HttpGet("all/{idclass}/{idsubject}/{idlesson}")]
        public async Task<IActionResult> Get(Guid idclass, Guid idsubject, Guid idlesson, [FromQuery] HomeWorkSeachList SearchVm)
        {
            var pagelist = await _repo.GetCPList(idclass, idsubject, idlesson, SearchVm);

            var MonhocDTOs = pagelist.Items;
            return Ok(new PageList<HomeWork>(MonhocDTOs.ToList(),
                pagelist.MetaData.TotalCount,
                pagelist.MetaData.CurrentPage,
                pagelist.MetaData.PageSize));
        }
        [HttpGet("getby/{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            if (id.ToString() == null)
                return BadRequest();

            var kq = await _repo.Getbyid(id);

            return Ok(kq);
        }
        [HttpPost]
        public async Task<IActionResult> CreateSubject([FromBody] HomeWorkCreatVM subject)
        {
            if (subject == null)
                return BadRequest();

            var kq = await _repo.CreateCP(subject);
            if (kq != 1)
            {
                return BadRequest(kq);
            }
            return Ok(kq);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] HomeWorkUpdateVM subject)
        {
            if (subject == null)
                return BadRequest();

            var kq = await _repo.UpdateCP(id, subject);
            if (kq != 1)
            {
                return BadRequest(kq);
            }
            return Ok(kq);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id.ToString() == null)
                return BadRequest();

            var kq = await _repo.DeleteCP(id);
            if (kq != 1)
            {
                return BadRequest(kq);
            }
            return Ok(kq);
        }
    }
}
