using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.ImagesCP;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageCPsController : ControllerBase
    {
        private IImageCPServices _imageCPServices;

        public ImageCPsController(IImageCPServices imageCPServices)
        {
            _imageCPServices = imageCPServices;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
        {
            var result = await _imageCPServices.GetImageCPById(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] ImageCPListSearchVm searchVm)
        {
            var result = await _imageCPServices.GetImageCPList(searchVm);


            var Dto = result.Items.Select(c => new ImageCPDto()
            {
                CoeId = c.CoeId,
                Descriptions = c.Descriptions,
                Path = c.Path,
                Status = c.Status,
                Id = c.Id,
            });

            return Ok(new PageList<ImageCPDto>(Dto.ToList(),
            result.MetaData.TotalCount, result.MetaData.CurrentPage, result.MetaData.PageSize));

        }

        [HttpPost]

        public async Task<IActionResult> Create(ImageCPCreateVm createVm)
        {
            var create = await _imageCPServices.CreateImageCP(new ImageCP()
            {
                Id = Guid.NewGuid(),
                CoeId = createVm.CoeId,
                Descriptions = createVm.Descriptions,
                Path = createVm.Path,
                Status = createVm.Status,
            });
            return Ok(create);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(Guid id, ImageCPUpdateVm UpdateVm)
        {
            var update = await _imageCPServices.UpdateImageCP(id, UpdateVm);
            return Ok(update);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var delete = await _imageCPServices.DeleteImageCP(id);
            return Ok(delete);

        }
    }
}
