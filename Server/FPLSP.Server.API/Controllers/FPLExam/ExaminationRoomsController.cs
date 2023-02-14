using FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers.FPLExam
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExaminationRoomsController : ControllerBase
    {
        private readonly IExaminationRoomServices _examinationRoomServices;
        public ExaminationRoomsController(IExaminationRoomServices examinationRoomServices)
        {
            _examinationRoomServices = examinationRoomServices;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllExamRoom()
        {

            var res = await _examinationRoomServices.GetAllExamRoom();
            return Ok(res);
        }

        [HttpGet]
        [Route("examroom-paging")]
        public async Task<IActionResult> GetAllExamRoomPaging([FromQuery] ExaminationRoomSearch examinationRoomSearch)
        {


            var res = await _examinationRoomServices.GetExamRoomForPaging(examinationRoomSearch);
            return Ok(res);
        }

        [HttpPost]
        [Route("examroom-adding")]
        public async Task<IActionResult> AddingExamRoom([FromBody] ExaminationRoomDetailView examinationRoomViewModel)
        {

            var res = await _examinationRoomServices.AddExaminationRoom(examinationRoomViewModel);
            return Ok(res);
        }
        [HttpPut]
        [Route("examroom-updating")]
        public async Task<IActionResult> UpdatingExamRoom([FromBody] ExaminationRoomDetailView examinationRoomViewModel)
        {

            var res = await _examinationRoomServices.UpdateExamRoom(examinationRoomViewModel);
            return Ok(res);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteExamRoom([FromRoute] Guid id)
        {

            var res = await _examinationRoomServices.DeleteExamRoom(id);
            return Ok(res);
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetExamRoomById([FromRoute] Guid id)
        {

            var res = await _examinationRoomServices.GetExamRoomById(id);
            return Ok(res);
        }

    }
}
