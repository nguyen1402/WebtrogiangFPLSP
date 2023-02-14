using FPLSP.Server.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class RoleUserServices : IRoleUserServices
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private List<IdentityRole> _lstRole;
        public RoleUserServices(RoleManager<IdentityRole> roleManager)
        {
            _lstRole = new List<IdentityRole>();
            _roleManager = roleManager;
            _lstRole = _roleManager.Roles.ToList();
        }

        public async Task<bool> AddRole(IdentityRole identityRole)
        {


            if (_lstRole.Any(c => c.Name == identityRole.Name))
            {
                // CẬP NHẬT

                var result = await _roleManager.FindByIdAsync(identityRole.Id);
                if (result != null)
                {
                    result.Name = identityRole.Name;
                    // Cập nhật tên Role
                    var roleUpdateRs = await _roleManager.UpdateAsync(result);
                    if (roleUpdateRs.Succeeded)
                    {
                        return true;
                    }

                }
                else
                {
                    return false;
                }

            }
            else
            {
                // TẠO MỚI

                // Thực hiện tạo Role mới
                var rsNewRole = await _roleManager.CreateAsync(identityRole);
                if (rsNewRole.Succeeded)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            return true;
        }

        public async Task<List<IdentityRole>> GetAllRolesAsync()
        {

            _lstRole = await _roleManager.Roles.ToListAsync();
            return _lstRole;
        }

        public async Task<IdentityRole> GetRoleById(string Id)
        {
            return _roleManager.Roles.First(c => c.Id == Id);
        }

        public async Task<bool> RemoveRoles(string Id)
        {
            if (Id == null)
            {
                return false;
            }

            var role = await _roleManager.FindByIdAsync(Id);
            if (role == null)
            {
                return false;
            }

            await _roleManager.DeleteAsync(role);

            return true;
        }

        public async Task<bool> UpdateRoles(IdentityRole identityRole)
        {
            if (_lstRole.Any(c => c.Id == identityRole.Id))
            {
                // CẬP NHẬT

                var result = await _roleManager.FindByIdAsync(identityRole.Id);
                if (result != null)
                {
                    result.Name = identityRole.Name;
                    // Cập nhật tên Role
                    var roleUpdateRs = await _roleManager.UpdateAsync(result);
                    if (roleUpdateRs.Succeeded)
                    {
                        return true;
                    }

                }


            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
