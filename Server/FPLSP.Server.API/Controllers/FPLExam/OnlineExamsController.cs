using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.Services.Implements;
using FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace FPLSP.Server.API.Controllers.FPLExam
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnlineExamsController : ControllerBase
    {
        private readonly IOnlineExamRoomServices _onlineExamRoomServices;
        private readonly IHubContext<NotificationHub> _hubContext;
        private readonly UserManager<UserSignIn> _userManager;
        public OnlineExamsController(IOnlineExamRoomServices onlineExamRoomServices, IHubContext<NotificationHub> hubContext, UserManager<UserSignIn> userManager)
        {
            _onlineExamRoomServices = onlineExamRoomServices;
            _hubContext = hubContext;
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOnlineExam()
        {

            var res = await _onlineExamRoomServices.GetAllOnlineExamRoom();
            return Ok(res);
        }
        [HttpPost]
        [Route("onlineexam-adding")]
        public async Task<IActionResult> AddingOnlineExam([FromBody] OnlineExamViewModel onlineExamRoom)
        {

            var res = await _onlineExamRoomServices.AddOnlineExamRoom(onlineExamRoom);


            return Ok(res);
        }
        [HttpGet]
        [Route("{secret}")]
        public async Task<IActionResult> GetAllOnlineExam(string secret)
        {
            var res = await _onlineExamRoomServices.GetOnlineExamRoomById(secret);
            return Ok(res);
        }
        [HttpGet]
        [Route("getturnuser/{screatekey}/{iduser}")]
        public async Task<IActionResult> GetTurn(string screatekey, string iduser)
        {
            var res = await _onlineExamRoomServices.getTurnById(screatekey, iduser);
            return Ok(res);
        }
        [HttpPut]
        [Route("fastupdateturn/{screatekey}")]
        public async Task<IActionResult> FastUpdating([FromRoute] string screatekey, [FromBody] string iduser)
        {
            var res = await _onlineExamRoomServices.FastUpdateTurn(screatekey, iduser);
            if (res)
            {
                var getEmailUser = _userManager.Users.FirstOrDefault(c => c.Id == iduser).Email;
                var responsemess = getEmailUser;
                await _hubContext.Clients.All.SendAsync("OnlineExams", responsemess);
            }
            return Ok(res);
        }



        [HttpPost]
        [Route("onlineexam-addingrange")]
        public async Task<IActionResult> AddingRangeOnlineExam([FromBody] List<OnlineExamRoom> onlineExamRoom)
        {

            var res = await _onlineExamRoomServices.AddRangeOnlineExamRoom(onlineExamRoom);
            return Ok(res);
        }
        [HttpPut]
        [Route("onlineexam-updating")]
        public async Task<IActionResult> UpdatingOnlineExam([FromBody] OnlineExamViewModel onlineExamRoom)
        {

            var res = await _onlineExamRoomServices.UpdateOnlineExamRoom(onlineExamRoom);
            return Ok(res);
        }

        [HttpPut]
        [Route("onlineexam-delete/{ScreateKey}")]
        public async Task<IActionResult> DeleteExamStorageExamroomDetail([FromRoute] string ScreateKey, [FromBody] string IdUser)
        {

            var res = await _onlineExamRoomServices.DeleteOnlineExamRoom(ScreateKey, IdUser);
            return Ok(res);
        }


        [HttpGet]
        [Route("getsectekeylastest/{IdUser}")]
        public async Task<IActionResult> GetSecretKeyForUser([FromRoute] string IdUser)
        {

            var res = await _onlineExamRoomServices.getScretKeyLastestForUser(IdUser);
            return Ok(res);
        }
        [HttpPut]
        [Route("fastchangingstatus/{secretkey}")]
        public async Task<IActionResult> FastChanging([FromRoute] string secretkey, [FromBody] string IdUser)
        {

            var res = await _onlineExamRoomServices.FastChangingStatus(secretkey, IdUser);
            return Ok(res);
        }
        //
        [HttpGet]
        [Route("fastgettingstatus/{secretkey}/{IdUser}")]
        public async Task<IActionResult> GetSecretKeyForUser([FromRoute] string secretkey, [FromRoute] string IdUser)
        {

            var res = await _onlineExamRoomServices.FastGettingStatus(secretkey, IdUser);
            return Ok(res);
        }
        //
        [HttpGet]
        [Route("handlerListrequest/{secretkey}")]
        public async Task<IActionResult> HandlerRequest([FromRoute] string secretkey)
        {

            var res = await _onlineExamRoomServices.HandlerRequestComeIn(secretkey);
            return Ok(res);
        }
        [HttpGet]
        [Route("getallexamnination-byidstudent/{IdStudent}")]
        public async Task<IActionResult> GetAllbyIdStudent([FromRoute] string IdStudent)
        {

            var res = await _onlineExamRoomServices.GetAllOfExamByIdStudent(IdStudent);
            return Ok(res);
        }
        [HttpPut]
        [Route("handlereuqestcomeout/{secretkey}")]
        public async Task<IActionResult> HandlerRequestComeOut([FromRoute] string secretkey, [FromBody] string IdUser)
        {

            var res = await _onlineExamRoomServices.FastUpdateHanlerWhenOut(secretkey, IdUser);
            if (res)
            {
                var getEmailUser = _userManager.Users.FirstOrDefault(c => c.Id == IdUser).Email;
                var responsemess = getEmailUser;
                await _hubContext.Clients.All.SendAsync("OnlineExamsComeOut", responsemess);
            }
            return Ok(res);
        }
        [HttpPost]
        [Route("showexam")]
        public async Task<IActionResult> ShowExamFileForUser([FromBody] string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                await _hubContext.Clients.All.SendAsync("ShowExamFile", message);
            }

            return Ok(true);
        }
        //
        [HttpPut]
        [Route("handlereuqestonetime/{secretkey}")]
        public async Task<IActionResult> HandlerOneTime([FromRoute] string secretkey, [FromBody] string IdUser)
        {

            var res = await _onlineExamRoomServices.FastUpdateHanlerOneTime(secretkey, IdUser);
            return Ok(res);
        }
        //
        [HttpPut]
        [Route("reopenexamfile/{secretkey}")]
        public async Task<IActionResult> ReopenSecretfile([FromRoute] string secretkey, [FromBody] string IdUser)
        {

            var res = await _onlineExamRoomServices.ReOpenExamFileForUser(secretkey, IdUser);
            return Ok(res);
        }
    }
}
