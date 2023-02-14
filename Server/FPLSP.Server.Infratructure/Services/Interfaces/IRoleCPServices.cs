using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.RoleCPVm;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IRoleCPServices
    {
        public Task<RoleCPViewModel> CreateRole(RoleCPRequest RoleCPViewModel);
        public Task<bool> UpdateRole(Guid Id, RoleCPRequest RoleCPViewModel);
        public Task<bool> DeleteRole(Guid Id);

        public Task<IQueryable<RoleCP>> GetAllRoleAsync();

        public Task<PageList<RoleCPViewModel>> GetRoleList(RoleCPListSearch search);

        public Task<RoleCPViewModel> GetRoleListById(Guid Id);

        public Task<IQueryable<RoleCPViewModel>> GetRoleMapper();
        public Task<RoleCP> GetRoleMaxCode();
        Task<bool> RemoveListRoleCP(List<Guid> listId);
    }
}
