using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin;

namespace FPLSP.Repositories.Interfaces.CabinProject
{
    public interface ICabinRepo
    {
        Task<bool> CreateCabin(CabinCreateViewModel request);
        Task<bool> UpdateCabin(Guid Id, CabinUpdateViewModel request);
        Task<bool> DeleteCabin(Guid Id);
        Task<bool> ChangeStatus(string Id);

		Task<List<CabinViewModel>> GetAllCabinAsync();
        Task<PageList<CabinViewModel>> GetCabinListSearch(CabinSearchViewModel searchRequest);
        Task<CabinViewModel> GetCabinListById(string Id);

        Task<bool> RemoveListCabin(List<Guid> listId);
    }
}
