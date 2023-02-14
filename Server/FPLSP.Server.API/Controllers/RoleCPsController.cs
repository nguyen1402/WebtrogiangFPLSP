using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.RoleCPVm;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleCPsController : ControllerBase
    {
        private readonly IRoleCPServices _roleCPServices;
        public RoleCPsController(IRoleCPServices roleCPServices)
        {
            _roleCPServices = roleCPServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetRoleList([FromQuery] RoleCPListSearch search)
        {
            var roles = await _roleCPServices.GetRoleList(search);

            var roleCP = roles.Items.Select(c => new RoleCPViewModel
            {
                Id = c.Id,
                RoleCode = c.RoleCode,
                RoleName = c.RoleName,
                Status = c.Status,
            }).ToList();
            return Ok(new PageList<RoleCPViewModel>(roleCP, roles.MetaData.TotalCount, roles.MetaData.CurrentPage, roles.MetaData.PageSize));
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetRoleById(Guid id)
        {
            var RoleModel = await _roleCPServices.GetRoleListById(id);
            return Ok(RoleModel);
        }
        [HttpGet("maxCode")]
        public async Task<IActionResult> GetMaxCodeRole()
        {
            var maxCodeRole = await _roleCPServices.GetRoleMaxCode();

            return Ok(maxCodeRole);
        }
        [HttpGet("all")]
        public async Task<IActionResult> GetAllRole()
        {
            var role = await _roleCPServices.GetAllRoleAsync();

            return Ok(role);
        }

        [HttpPost]
        public async Task<IActionResult> AddRole([FromBody] RoleCPRequest RoleCP)
        {
            await _roleCPServices.CreateRole(RoleCP);
            return Ok(RoleCP);
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateRole(Guid id, [FromBody] RoleCPRequest RoleCP)
        {
            var RoleUpdate = await _roleCPServices.GetRoleListById(id);
            if (RoleUpdate == null)
            {
                return NotFound();
            }
            await _roleCPServices.UpdateRole(id, RoleCP);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteRole([FromRoute] Guid id)
        {
            var RoleDelete = await _roleCPServices.GetRoleListById(id);
            if (RoleDelete == null)
            {
                return NotFound();
            }

            var x = await _roleCPServices.DeleteRole(id);
            return Ok();
        }

        [HttpPost("deletelist")]
        public async Task<IActionResult> DeleteListRole([FromBody] List<Guid> listIdRole)
        {
            var report = _roleCPServices.RemoveListRoleCP(listIdRole);
            if (report.Result)
            {
                return Ok("Xóa thành công");
            }
            return BadRequest("Xóa thất bại");
        }

    }
}
