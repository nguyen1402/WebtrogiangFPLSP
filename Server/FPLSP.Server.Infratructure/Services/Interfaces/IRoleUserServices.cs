using Microsoft.AspNetCore.Identity;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IRoleUserServices
    {
        Task<List<IdentityRole>> GetAllRolesAsync();
        Task<IdentityRole> GetRoleById(string Id);
        Task<bool> AddRole(IdentityRole identityRole);
        Task<bool> RemoveRoles(string Id);
        Task<bool> UpdateRoles(IdentityRole identityRole);
    }
}
