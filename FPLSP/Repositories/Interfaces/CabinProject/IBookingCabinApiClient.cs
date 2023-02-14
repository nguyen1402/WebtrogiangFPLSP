using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingCabin;

namespace FPLSP.Repositories.Interfaces.CabinProject
{
    public interface IBookingCabinApiClient
    {
        Task<List<BookingCabinVM>> GetAll();
        Task<BookingCabinVM> GetById(Guid Id, Guid IdCabin, Guid SubjectId, Guid ClassId, Guid IdShift);
        Task<bool> Add(BookingCabinCreateVM bookingCabinVM);
        Task<bool> Delete(Guid Id, Guid IdCabin, Guid SubjectId, Guid ClassId, Guid IdShift);
        Task<bool> Update(Guid Id, Guid IdCabin, Guid SubjectId, Guid ClassId, Guid IdShift, BookingCabinUpdateVM bookingCabinVM);
        Task<PageList<BookingCabinVM>> GetForSearch(BookingCabinSearch search);
        Task<List<BookingCabinVM>> GetListById(Guid SubjectId, Guid ClassId, Guid IdShift);
        Task<bool> UndoDelete(Guid Id);
    }
}
