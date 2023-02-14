using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.ResourceLink;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceLinksController : ControllerBase
    {
        private readonly IResourceLinkServices _repo;
        public ResourceLinksController(IResourceLinkServices repo)
        {
            _repo = repo;
        }


        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] ResourceLinkListSearch parameters)
        {
            var pagelist = await _repo.Gets(parameters);

            var lslink = pagelist.Items.Select(c => new ResourceLinkDto()
            {
                Id = c.Id,
                Path = c.Path,
                Descriptions = c.Descriptions,
                Status = c.Status,
                ResourcesTitle = c.ResourcesTitle,
            });

            return Ok(new PageList<ResourceLinkDto>(lslink.ToList(),
                pagelist.MetaData.TotalCount,
                pagelist.MetaData.CurrentPage,
                pagelist.MetaData.PageSize));
        }


        [HttpGet("all")]
        public async Task<IActionResult> Getall()
        {
            var linkrs = await _repo.GetAllAsync();
            return Ok(linkrs);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetbyId(Guid id)
        {
            var linkrs = await _repo.GetbyId(id);
            return Ok(linkrs);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ResourceLinkCreateVM modelcreate)
        {
            if (modelcreate == null)
                return BadRequest();

            var kq = await _repo.Create(modelcreate);
            if (kq != 1)
            {
                return BadRequest(kq);
            }
            return Ok(kq);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] ResourceLinkUpdateVM modelupdate)
        {
            //var subjectdb = await _repo.GetSubjectbyId(id);

            if (modelupdate == null)
                return BadRequest();

            var kq = await _repo.Update(id, modelupdate);
            if (kq != 1)
            {
                return BadRequest(kq);
            }
            return Ok(kq);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {

            if (string.IsNullOrEmpty(id.ToString()))
                return BadRequest();

            var result = await _repo.Delete(id);
            if (result != 1)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPost("deletelist")]
        public async Task<IActionResult> DeleteListResourceLink([FromBody] List<Guid> listIdlessoncontent)
        {
            var report = _repo.RemoveListResourceLink(listIdlessoncontent);
            if (report.Result)
            {
                return Ok("Xóa thành công");
            }
            return BadRequest("Xóa thất bại");
        }

    }
}
