using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UsersController : ControllerBase
    {

        private readonly IUseridentityServices _useridentityServices;
        public UsersController(IUseridentityServices useridentityServices)
        {
            _useridentityServices = useridentityServices;
        }

        [HttpGet("getPageList")]

        public async Task<PageList<UserInListRoles>> GetAllUsers([FromQuery] UserRoleSearch userRoleSearch)
        {
            return await _useridentityServices.GetAllUser(userRoleSearch);
        }   
        
        [HttpGet("GetAllListUser")]

        public async Task<List<UserInListRoles>> GetAllListUser()
        {
            return await _useridentityServices.GetAllListUser();
        }
        
        [HttpGet("GetAllUserNotRole")]

        public async Task<PageList<UserInListRoles>> GetAllUserNotRole([FromQuery] UserRoleSearch userRoleSearch)
        {
            return await _useridentityServices.GetAllUserNotRole(userRoleSearch);
        }
        [HttpPost]
        public async Task<bool> UpdateRoles([FromBody] UserUpdateRoles userUpdateRoles)
        {
            return await _useridentityServices.AddRolesToUser(userUpdateRoles);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<UserInListRoles> GetUserById(string id)
        {
            return await _useridentityServices.GetUserRoleById(id);
        }

        [HttpGet("role/{email}")]
        public async Task<UserInListRoles> GetRoleTrain(string email)
        {
            return await _useridentityServices.GetRoleUser(email);
        }
         
        [HttpDelete("CheckUserChageIdTrain/{idUser}/{idTrain}")]
        public async Task<bool> CheckUserChageIdTrain(string idUser, Guid idTrain)
        {
            return await _useridentityServices.CheckUserChageIdTrain(idUser,idTrain);
        }
        [HttpDelete("DeleteUserNorRole/{idUser}")]
        public async Task<bool> DeleteUserNorRole(string idUser)
        {
            return await _useridentityServices.DeleteUserNorRole(idUser);
        }
    }
}
