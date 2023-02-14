using FPLSP.Server.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleIdentitysController : ControllerBase
    {
        private readonly IRoleUserServices _roleUserServices;
        public RoleIdentitysController(IRoleUserServices roleUserServices)
        {
            _roleUserServices = roleUserServices;
        }

        [HttpGet]

        public async Task<List<IdentityRole>> GetRolesAsync()
        {
            return await _roleUserServices.GetAllRolesAsync();
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IdentityRole> GetRolesAsyncById(string id)
        {
            return await _roleUserServices.GetRoleById(id);
        }
        [HttpPost]
        [Route("add-role")]
        public async Task<bool> AddRoleAsync([FromBody] IdentityRole identityRole)
        {
            return await _roleUserServices.AddRole(identityRole);
        }
        [HttpPut]
        public async Task<bool> UpdateRoles([FromBody] IdentityRole identityRole)
        {
            return await _roleUserServices.UpdateRoles(identityRole);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<bool> DelteRoles(string id)
        {
            return await _roleUserServices.RemoveRoles(id);
        }
    }
}
