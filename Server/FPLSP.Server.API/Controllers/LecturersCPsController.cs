using FPLSP.Server.Data.FPLSPDbContext;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.LecturerCPVm;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LecturersCPsController : ControllerBase
    {
        private readonly ILecturersCPServices _lecturersCPServices;
        private ApplicationDbContext _ApplicationDbContext;
        public LecturersCPsController(ILecturersCPServices lecturersCPServices)
        {
            _lecturersCPServices = lecturersCPServices;
            _ApplicationDbContext = new ApplicationDbContext();
        }

        [HttpGet]
        public async Task<IActionResult> GetLecturerList([FromQuery] LecturersCPListSearch search)
        {
            var Lecturers = await _lecturersCPServices.GetLecturerListSearch(search);

            var LecturersCP = Lecturers.Items.Select(c => new LecturersCPViewModel
            {
                Id = c.Id,
                LecturersCode = c.LecturersCode,
                LecturersName = c.LecturersName,
                Gender = c.Gender,
                Dob = c.Dob,
                Email = c.Email,
                PhoneNumber = c.PhoneNumber,
                Address = c.Address,
                IdentityCard = c.IdentityCard,
                IssuedOn = c.IssuedOn,
                Ethnic = c.Ethnic,
                ImageUrl = c.ImageUrl,
                YearsOfExperience = c.YearsOfExperience,
                HomeTown = c.HomeTown,
                Description = c.Description,
                Status = c.Status,
                RoleId = c.RoleId,
                TrainingFacilitiesId = c.TrainingFacilitiesId,
                idspec = c.idspec,
                namechuyennganh = c.namechuyennganh,
            }).ToList();
            return Ok(new PageList<LecturersCPViewModel>(LecturersCP, Lecturers.MetaData.TotalCount, Lecturers.MetaData.CurrentPage, Lecturers.MetaData.PageSize));
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllLecturers()
        {
            var Lecturers = await _lecturersCPServices.GetAllLecturerAsync();

            return Ok(Lecturers);
        }

        [HttpGet("maxCode")]
        public async Task<IActionResult> GetMaxCodeRole()
        {
            var maxCodeRole = await _lecturersCPServices.GetLecturerMaxCode();

            return Ok(maxCodeRole);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetLecturerById(Guid id)
        {
            var lecturerModel = await _lecturersCPServices.GetLecturerListById(id);
            return Ok(lecturerModel);
        }

        [HttpPost]
        [Route("createLecture")]
        public async Task<IActionResult> AddLecturer([FromBody] LecturersCPRequest LecturerCPViewModel)
        {
            if (LecturerCPViewModel == null)
                return BadRequest();

            var newRole = await _lecturersCPServices.CreateLecturer(LecturerCPViewModel);

            return Ok(newRole);
        }
        [HttpPost("train")]
        public async Task<IActionResult> CreateLecturerForTrain([FromBody] CreateleatureForTrainVm lecturersCPVM)
        {
            var newRole = await _lecturersCPServices.CreateLecturerForTrain(lecturersCPVM);

            return Ok(newRole);
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateLecturer(Guid id, [FromBody] LecturersCPRequest lecturerCP)
        {
            var lecturerUpdate = await _lecturersCPServices.GetLecturerListById(id);
            if (lecturerUpdate == null)
            {
                return NotFound();
            }
            await _lecturersCPServices.UpdateLecturer(id, lecturerCP);
            return Ok();
        } 
        [HttpPut]
        [Route("UpdateLectureCP")]
        public async Task<IActionResult> UpdateLectureCP([FromBody] LecturersCP lecturerCP)
        {
            if (lecturerCP == null)
            {
                return NotFound();
            }
            await _lecturersCPServices.UpdateLectureCP(lecturerCP);
            return Ok();
        }
        [HttpPut]
        [Route("train/{id}")]
        public async Task<IActionResult> UpdateLecturerTrain(Guid id, [FromBody] CreateleatureForTrainVm lecturerCP)
        {
            var lecturerUpdate = await _lecturersCPServices.UpdateLecturerTrain(id, lecturerCP);        
            return Ok(lecturerUpdate);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteLecturer([FromRoute] Guid id)
        {
            var lecturerDelete = await _lecturersCPServices.GetLecturerListById(id);
            if (lecturerDelete == null)
            {
                return NotFound();
            }

            var x = await _lecturersCPServices.DeleteLecturer(id);
            return Ok();
        }


        [HttpPost("deletelist/list")]
        public async Task<IActionResult> DeleteListLecturer([FromBody] List<Guid> listId)
        {
            var report = _lecturersCPServices.RemoveListLecturersCP(listId);
            if (report.Result)
            {
                return Ok("Xóa thành công");
            }
            return BadRequest("Xóa thất bại");
        }
    }
}
