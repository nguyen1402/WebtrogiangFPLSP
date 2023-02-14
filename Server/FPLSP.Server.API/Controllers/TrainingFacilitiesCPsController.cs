using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.TrainingFacilitiesCPVm;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingFacilitiesCPsController : ControllerBase
    {
        private readonly ITrainingFacilitiesCPServices _trainingFacilitiesCPServices;
        public TrainingFacilitiesCPsController(ITrainingFacilitiesCPServices trainingFacilitiesCPServices)
        {
            _trainingFacilitiesCPServices = trainingFacilitiesCPServices;
        }

        /// <summary>
        /// Lấy danh sách cơ sở đào tạo theo trang
        /// </summary>
        /// <param name="pagingParameters"></param> 
        /// <returns>Danh sách cơ sở đào tạo theo trang</returns>
        [HttpGet]
        public async Task<IActionResult> GetTrainingFacilityList([FromQuery] TrainingFacilitiesCPListSearch pagingParameters)
        {
            var trainingFacilities = await _trainingFacilitiesCPServices.GetTrainingFacilityList(pagingParameters);

            var trainingFacilitiesCP = trainingFacilities.Items.Select(c => new TrainingFacilitiesCPViewModel
            {
                ID = c.ID,
                TrainingFacilitiesCode = c.TrainingFacilitiesCode,
                TrainingInstitutionName = c.TrainingInstitutionName,
                ImageUrl = c.ImageUrl,
                TrainingInstitution = c.TrainingInstitution,
                Status = c.Status
            }).ToList();
            return Ok(new PageList<TrainingFacilitiesCPViewModel>(trainingFacilitiesCP, trainingFacilities.MetaData.TotalCount, trainingFacilities.MetaData.CurrentPage, trainingFacilities.MetaData.PageSize));
        }

        /// <summary>
        /// Lấy toàn bộ danh sách Cơ sở đào tạo CP
        /// </summary>
        /// <returns></returns>
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var trainingFacilitiesCP = await _trainingFacilitiesCPServices.GetTrainingFacilitiesAsync();

            return Ok(trainingFacilitiesCP);
        }

        /// <summary>
        /// Lấy ra đối tượng Cơ sở đào tạo có mã lớn nhất
        /// </summary>
        /// <returns></returns>
        [HttpGet("maxCode")]
        public async Task<IActionResult> GetMaxCodeTrainingFacility()
        {
            var maxCodeTrainingFacility = await _trainingFacilitiesCPServices.GetTrainingFacilityMaxCode();

            return Ok(maxCodeTrainingFacility);
        }

        /// <summary>
        /// Tìm kiếm cơ sở đào tạo dựa vào ID
        /// </summary>
        /// <param name="id"></param> ID của TrainingFacilitiesCP
        /// <returns> Cơ sở đào tạo có ID trùng khớp </returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetTrainingFacilityById(Guid id)
        {
            var trainingFacilityModel = await _trainingFacilitiesCPServices.GetTrainingFacilityListById(id);
            return Ok(trainingFacilityModel);
        }

        /// <summary>
        /// Tạo Cơ sở đào tạo
        /// </summary>
        /// <param name="trainingFacilitiesCPViewModel"></param>
        /// <returns> Cơ sở đào tạo vừa tạo </returns>
        [HttpPost]
        public async Task<IActionResult> AddTrainingFacility([FromBody] TrainingFacilitiesCPRequest trainingFacilitiesCPRequest)
        {
            if (trainingFacilitiesCPRequest == null)
                return BadRequest();

            var newTrainingFacility = await _trainingFacilitiesCPServices.CreateTrainingFacility(trainingFacilitiesCPRequest);

            return Ok(newTrainingFacility);
        }
        /// <summary>
        /// Cập nhật Cơ sở đào tạo
        /// </summary>
        /// <param name="id"></param> ID của Cơ sở đào tạo
        /// <param name="trainingFacilitiesCPRequest"></param> Yêu cầu cập nhật Cơ sở đào tạo
        /// <returns> Ok: xóa thành công, Notfound: không tìm thấy ID trùng khớp</returns>
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateTrainingFacility(Guid id, [FromBody] TrainingFacilitiesCPRequest trainingFacilitiesCPRequest)
        {
            var trainingFacilityUpdate = await _trainingFacilitiesCPServices.GetTrainingFacilityListById(id);
            if (trainingFacilityUpdate == null)
            {
                return NotFound();
            }
            await _trainingFacilitiesCPServices.UpdateTrainingFacility(id, trainingFacilitiesCPRequest);
            return Ok();
        }
        /// <summary>
        /// Xóa Cơ sở đào tạo
        /// </summary>
        /// <param name="id"></param> ID của Cơ sở đào tạo
        /// <returns> Ok: xóa thành công, Notfound: không tìm thấy ID trùng khớp</returns>
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteTrainingFacility([FromRoute] Guid id)
        {
            var TrainingFacilityDelete = await _trainingFacilitiesCPServices.GetTrainingFacilityListById(id);
            if (TrainingFacilityDelete == null)
            {
                return NotFound();
            }

            var x = await _trainingFacilitiesCPServices.DeleteTrainingFacility(id);
            return Ok();
        }


        [HttpPost("deletelist")]
        public async Task<IActionResult> DeleteListRole([FromBody] List<Guid> listIdTF)
        {
            var report = _trainingFacilitiesCPServices.RemoveListTF(listIdTF);
            if (report.Result)
            {
                return Ok("Xóa thành công");
            }
            return BadRequest("Xóa thất bại");
        }
    }
}
