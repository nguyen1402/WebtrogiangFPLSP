using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.ShiftOfCabin;

namespace FPLSP.Repositories.Interfaces.CabinProject
{
    public interface IShiftOfCabinApiClient
    {
        Task<List<ShiftOfCabinVM>> GetAll();
        Task<ShiftOfCabinVM> GetById(Guid Id);
        Task<bool> Add(ShiftOfCabinCreateVM shiftOfCabinVM);

        Task<bool> Delete(Guid Id);
        Task<bool> Update(Guid Id, ShiftOfCabinUpdateVM shiftOfCabinVM);
        Task<PageList<ShiftOfCabinVM>> GetForSearch(ShiftOfCabinSearch search);
        Task<List<ShiftOfCabinFullVM>> GetAllInformationOfShiftOfCabin();
        Task<List<ShiftOfCabinFullVM>> GetAllInformationOfShiftOfCabinIsNotDeleted();
    }
}
