using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingCabin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject
{
    public interface IBookingCabinServices
    {
        Task<List<BookingCabinVM>> GetAll();
        Task<BookingCabinVM> GetById(Guid Id, Guid IdCabin,Guid SubjectId, Guid ClassId, Guid IdShift);
        Task<bool> Add(BookingCabinCreateVM bookingCabinVM);

        Task<bool> Delete(Guid Id, Guid IdCabin, Guid SubjectId, Guid ClassId, Guid IdShift);
        Task<bool> Update(Guid Id, Guid IdCabin, Guid SubjectId, Guid ClassId, Guid IdShift, BookingCabinUpdateVM bookingCabinVM);
        Task<PageList<BookingCabinVM>> GetForSearch(BookingCabinSearch search);

        Task<bool> UndoDelete(Guid Id);
    }
}
