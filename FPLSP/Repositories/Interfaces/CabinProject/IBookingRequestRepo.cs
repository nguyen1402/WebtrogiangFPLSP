using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingRequest;

namespace FPLSP.Repositories.Interfaces.CabinProject
{
    public interface IBookingRequestRepo
    {
        Task<bool> CreateBookingRequest(BookingRequestCreateViewModel request);
        Task<bool> UpdateBookingRequest(Guid Id, BookingRequestUpdateViewModel request);
        Task<bool> DeleteBookingRequest(Guid Id);

        Task<List<BookingRequestViewModel>> GetAllBookingRequestAsync();
        Task<PageList<BookingRequestViewModel>> GetBookingRequestListSearch(BookingRequestSearchViewModel searchRequest);
        Task<BookingRequestViewModel> GetBookingRequestListById(Guid Id);

        Task<bool> RemoveListBookingRequest(List<Guid> listId);
    }
}
