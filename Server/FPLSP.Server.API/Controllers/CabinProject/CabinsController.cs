using FPLSP.Server.Data.FPLSPDbContext;
using FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.GroupCabin;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin;
using Microsoft.AspNetCore.Mvc;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject;
using DocumentFormat.OpenXml.Office2016.Excel;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject.SignalRServices;
using Microsoft.AspNetCore.SignalR;
using FPLSP.Server.Infrastructure.Services.Implements.Cabin;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;

namespace FPLSP.Server.API.Controllers.CabinProject
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabinsController : ControllerBase
    {
        private readonly ICabinServices _CabinServices;
        private readonly IHubContext<SignalRHubBookingServices> _hubContext;
        private ApplicationDbContext _ApplicationDbContext;
        public CabinsController(ICabinServices CabinServices, IHubContext<SignalRHubBookingServices> hubContext)
        {
            _CabinServices = CabinServices ?? throw new ArgumentNullException(nameof(CabinServices));
            _hubContext = hubContext ?? throw new ArgumentNullException(nameof(hubContext));
            _ApplicationDbContext = new ApplicationDbContext();
        }


        [HttpGet]
        public async Task<IActionResult> GetListCabinList([FromQuery] CabinSearchViewModel search)
        {
            var objCollection = await _CabinServices.GetCabinListSearch(search);

            var result = objCollection.Items.Select(c => new CabinViewModel
            {
                Id = c.Id,
                CabinName = c.CabinName,
                IndexOfCabin = c.IndexOfCabin,
                CreateTime = c.CreateTime,
                BuildingName = c.BuildingName,
                IdTrainingFacility = c.IdTrainingFacility,
                Status = c.Status,
            }).ToList();
            return Ok(new PageList<CabinViewModel>(result, objCollection.MetaData.TotalCount, objCollection.MetaData.CurrentPage, objCollection.MetaData.PageSize));
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllCabin()
        {
            var objCollection = await _CabinServices.GetAllCabinAsync();

            return Ok(objCollection);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetCabinListById(Guid Id)
        {
            var lecturerModel = await _CabinServices.GetCabinListById(Id);
            return Ok(lecturerModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCabin([FromBody] CabinCreateViewModel request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            var result = await _CabinServices.CreateCabin(request);           
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("SignalRCabins", responsemess);
            
            return Ok(result);
        }

        [HttpPut]
        [Route("{Id}")]
        public async Task<IActionResult> UpdateCabin(Guid Id, [FromBody] CabinUpdateViewModel request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            var result = await _CabinServices.UpdateCabin(Id, request);
            var responsemess = "Done";
            await _hubContext.Clients.All.SendAsync("SignalRCabins", responsemess);

            return Ok(result);
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> DeleteGroupCabin([FromRoute] Guid Id)
        {
            var objDelete = await _CabinServices.GetCabinListById(Id);
            if (objDelete == null)
            {
                return NotFound();
            }

            objDelete.Status = 1;
            var x = await _CabinServices.UpdateCabin(Id, new CabinUpdateViewModel()
            {
                CabinName = objDelete.CabinName,
                BuildingName = objDelete.BuildingName,
                IndexOfCabin = objDelete.IndexOfCabin,
                Status = objDelete.Status,
            });
            return Ok();
        }
    }
}