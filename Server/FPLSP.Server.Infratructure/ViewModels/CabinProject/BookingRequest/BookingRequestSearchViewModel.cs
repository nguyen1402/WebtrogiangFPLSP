using FPLSP.Server.Data.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingRequest
{
    public class BookingRequestSearchViewModel : PagingParameters
    {
        public int? Status { get; set; }
        public string? stringSearch { get; set; }
        public int? IndexOfBookingRequest { get; set; }
        public string? ContentOfRequest { get; set; }
    }
}