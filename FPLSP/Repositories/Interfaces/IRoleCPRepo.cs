using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.RoleCPVm;

namespace FPLSP.Repositories.Interfaces
{
    public interface IRoleCPRepo
    {
        public Task<bool> CreateRole(RoleCPRequest roleCPViewModel);
        public Task<bool> UpdateRole(Guid Id, RoleCPRequest roleCPViewModel);
        public Task<bool> DeleteRole(Guid Id);

        public Task<List<RoleCP>> GetAllRoleAsync();

        public Task<PageList<RoleCPViewModel>> GetRoleListAsync(RoleCPListSearch search);

        public Task<RoleCPViewModel> GetRoleListById(Guid Id);

        public Task<IQueryable<RoleCPViewModel>> GetRoleMapper();
        public Task<RoleCP> GetMaxCodeRole();

        Task<bool> RemoveListRole(List<Guid> listIdRole);
    }
}
