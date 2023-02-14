using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.GroupCabin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject
{
    public interface IGroupCabinServices
    {
        Task<GroupCabinViewModel> CreateGroupCabin(GroupCabinCreateViewModel request);
        Task<bool> UpdateGroupCabin(Guid IdSpec, Guid IdCabin, GroupCabinUpdateViewModel request);
        Task<bool> DeleteGroupCabin(Guid IdSpec, Guid IdCabin);
        Task<bool> ChangeStatus(Guid IdSpec, Guid IdCabin);
        Task<List<GroupCabinViewModel>> GetAllGroupCabinAsync();
        Task<GroupCabinViewModel> GetGroupCabinListById(Guid IdSpec, Guid IdCabin);
        public Task<PageList<GroupCabinViewModel>> GetGroupCabinListSearch(GroupCabinSearchViewModel search);

        Task<bool> RemoveListGroupCabin(List<(Guid, Guid)> listIdSpecCabin);
    }
}
