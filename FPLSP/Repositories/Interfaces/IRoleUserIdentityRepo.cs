using Microsoft.AspNetCore.Identity;

namespace FPLSP.Repositories.Interfaces
{
    public interface IRoleUserIdentityRepo
    {
        Task<List<IdentityRole>> GetAllRolesAsync();
        Task<bool> AddRole(IdentityRole identityRole);
        Task<bool> RemoveRoles(string Id);
        Task<bool> UpdateRoles(IdentityRole identityRole);
        Task<IdentityRole> GetRoleById(string Id);
    }
}
