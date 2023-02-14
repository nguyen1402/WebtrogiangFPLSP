using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers.FPLExam
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupervisorExamRoomsController : ControllerBase
    {

        private readonly ISupervisorExamRoomServices _supervisorExamRoomServices;
        public SupervisorExamRoomsController(ISupervisorExamRoomServices supervisorExamRoomServices)
        {
            _supervisorExamRoomServices = supervisorExamRoomServices;

        }
        [HttpGet]
        public async Task<IActionResult> GetAllSupervisorExamRoom()
        {

            var res = await _supervisorExamRoomServices.GetAllSupervisorExamRoom();
            return Ok(res);
        }
        [HttpGet]
        [Route("getting-sercret/{iduser}")]
        public async Task<IActionResult> GetAllSupervisorExamRoom([FromRoute] string iduser)
        {

            var res = await _supervisorExamRoomServices.GetCrurrntTimeForSupervisor(iduser);
            return Ok(res);
        }
        [HttpGet]
        [Route("getting-listuer/{iduser}")]
        public async Task<IActionResult> GetListUserByIdUser([FromRoute] string iduser)
        {

            var res = await _supervisorExamRoomServices.GetSupervisorById(iduser);
            return Ok(res);
        }
        [HttpPost]
        [Route("supervisorexamroom-adding")]
        public async Task<IActionResult> AddingSupervisorExamRoom([FromBody] SupervisorExamRoom supervisorExamRoom)
        {

            var res = await _supervisorExamRoomServices.AddingSupervisorExamRoom(supervisorExamRoom);
            return Ok(res);
        }


        [HttpPost]
        [Route("supervisorexamroom-addingrange")]
        public async Task<IActionResult> AddingRangeSupervisorExamRoom([FromBody] List<ExamRoomSupervisorViewModel> supervisorExamRoom)
        {

            var res = await _supervisorExamRoomServices.AddingRangeSupervisorExamRoom(supervisorExamRoom);
            return Ok(res);
        }
        [HttpPut]
        [Route("onlineexam-updating")]
        public async Task<IActionResult> UpdatingSupervisorExamRoom([FromBody] SupervisorExamRoom supervisorExamRoom)
        {

            var res = await _supervisorExamRoomServices.UpdatingSupervisorExamRoom(supervisorExamRoom);
            return Ok(res);
        }

        [HttpPut]
        [Route("onlineexam-delete")]
        public async Task<IActionResult> DeleteSupervisorExamRoom(SupervisorExamRoom supervisorExamRoom)
        {

            var res = await _supervisorExamRoomServices.DeletingSupervisorExamRoom(supervisorExamRoom);
            return Ok(res);
        }
    }
}
