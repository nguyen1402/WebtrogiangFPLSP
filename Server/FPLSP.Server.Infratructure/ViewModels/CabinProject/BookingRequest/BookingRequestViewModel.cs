using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingRequest
{
    public class BookingRequestViewModel
    {
        public Guid Id { get; set; }
        public int IndexOfBookingRequest { get; set; }
        public int Status { get; set; }
        public DateTime SendingTime { get; set; }
        public string ContentOfRequest { get; set; }
        public string ContenOfFeedBack { get; set; }
        public Guid IdLectuter { get; set; }
        public Guid SubjectId { get; set; }
        public Guid ClassId { get; set; }
        public Guid? IdCabin { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime FeedBackTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}
