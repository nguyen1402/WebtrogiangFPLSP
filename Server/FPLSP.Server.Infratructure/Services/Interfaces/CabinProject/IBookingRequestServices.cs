using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject
{
    public interface IBookingRequestServices
    {
        Task<BookingRequestViewModel> CreateBookingRequest(BookingRequestCreateViewModel request);
        Task<bool> UpdateBookingRequest(Guid Id, BookingRequestUpdateViewModel request);
        Task<bool> DeleteBookingRequest(Guid Id);

        Task<List<BookingRequestViewModel>> GetAllBookingRequestAsync();
        Task<BookingRequestViewModel> GetBookingRequestListById(Guid Id);
        public Task<PageList<BookingRequestViewModel>> GetBookingRequestListSearch(BookingRequestSearchViewModel search);

        Task<bool> RemoveListBookingRequest(List<Guid> listIdSpecCabin);
    }
}
