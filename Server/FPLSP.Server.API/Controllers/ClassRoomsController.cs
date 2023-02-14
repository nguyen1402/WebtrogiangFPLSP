using FPLSP.Server.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomsController : ControllerBase
    {

        private readonly IClassRoomServices _classRoomServices;

        public ClassRoomsController(IClassRoomServices classRoomServices)
        {
            this._classRoomServices = classRoomServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudentsAsync()
        {
            var result = await _classRoomServices.GetClassAsync();
            return Ok(result);
        }
    }
}
