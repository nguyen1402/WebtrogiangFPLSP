using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.ResourceLinkUP;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{

    //api​/ResourceLinkUPs​
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceLinkUPsController : ControllerBase
    {
        private readonly IResourceLinkUPServices _resourceLinkUPServices;

        public ResourceLinkUPsController(IResourceLinkUPServices resourceLinkUPServices, ILogger<ResourceLinkUPsController> logger)
        {
            _resourceLinkUPServices = resourceLinkUPServices ?? throw new ArgumentNullException(nameof(resourceLinkUPServices));
        }

        //api​/ResourceLinkUPs​
        [HttpGet]
        public async Task<IActionResult> GetResourceLinkUPs([FromQuery] ResourceLinkUPListSearch search)
        {
            var pageList = await _resourceLinkUPServices.GetResourceLinkUPs(search);

            var data = pageList.Items.Select(c => new ResourceLinkUPDto()
            {
                Id = c.Id,
                ResourcesTitle = c.ResourcesTitle,
                Path = c.Path,
                Descriptions = c.Descriptions,
                Status = c.Status
            });

            return Ok(
                    new PageList<ResourceLinkUPDto>(data.ToList(),
                        pageList.MetaData.TotalCount,
                        pageList.MetaData.CurrentPage,
                        pageList.MetaData.PageSize));
        }

        //api​/ResourceLinkUPs​/all
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var resourceLinkUPs = await _resourceLinkUPServices.GetAll();

            return Ok(resourceLinkUPs);
        }

        //api​/ResourceLinkUPs​/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _resourceLinkUPServices.GetById(id);
            if (result == null)
            {
                return BadRequest($"Cannot find a ResourceLinkUP with id: {id}");
            }
            return Ok(result);
        }

        //api​/ResourceLinkUPs​
        [HttpPost("create")]
        public async Task<IActionResult> Create(ResourceLinkUPCreateRequest request)
        {
            var result = await _resourceLinkUPServices.Create(request);
            if (result == null)
            {
                return BadRequest("Can not create a ResourceLinkUP. Please try again later!");
            }
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        //api​/ResourceLinkUPs​/{id}
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] ResourceLinkUPViewModel request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var affectedResult = await _resourceLinkUPServices.Update(id, request);
            if (affectedResult == 0)
            {
                return BadRequest($"Cannot find a ResourceLinkUP with id: {id}");
            }
            return Ok("Updated successfully");
        }

        //api​/ResourceLinkUPs​/{id}
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var affectedResult = await _resourceLinkUPServices.Delete(id);
            if (affectedResult == 0)
            {
                return BadRequest($"Cannot find a ResourceLinkUP with id: {id}");
            }
            return Ok("Deleted successfully");
        }
        [HttpPost("{method}")]
        public async Task<IActionResult> DeleteListReport(int method, [FromBody] List<Guid> listIdReport)
        {
            var report = _resourceLinkUPServices.DeleteList(listIdReport, method);
            if (report.Result)
            {
                return Ok("Xóa thành công");
            }
            return BadRequest("Xóa thất bại");
        }
    }
}