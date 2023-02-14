using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject
{
    public interface ICabinServices
    {
        Task<CabinViewModel> CreateCabin(CabinCreateViewModel request);
        Task<bool> UpdateCabin(Guid Id, CabinUpdateViewModel request);
        Task<bool> DeleteCabin(Guid Id);
        Task<bool> ChangeStatus(Guid Id);

		Task<List<CabinViewModel>> GetAllCabinAsync();
        Task<CabinViewModel> GetCabinListById(Guid Id);
        public Task<PageList<CabinViewModel>> GetCabinListSearch(CabinSearchViewModel search);

        Task<bool> RemoveListCabin(List<Guid> listId);
    }
}
