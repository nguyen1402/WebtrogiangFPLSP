using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.GroupCabin;

namespace FPLSP.Repositories.Interfaces.CabinProject
{
    public interface IGroupCabinRepo
    {
        Task<bool> CreateGroupCabin(GroupCabinCreateViewModel request);
        Task<bool> UpdateGroupCabin(Guid IdSpec, Guid IdCabin, GroupCabinUpdateViewModel request);
        Task<bool> DeleteGroupCabin(Guid IdSpec, Guid IdCabin);
        Task<bool> ChangeStatus(string IdSpec, string IdCabin);

        Task<List<GroupCabinViewModel>> GetAllGroupCabinAsync();
        Task<PageList<GroupCabinViewModel>> GetGroupCabinListSearch(GroupCabinSearchViewModel search);
        Task<GroupCabinViewModel> GetGroupCabinListById(string IdSpec, string IdCabin);

        Task<bool> RemoveListGroupCabin(List<(Guid, Guid)> listIdSpecCabin);
    }
}
