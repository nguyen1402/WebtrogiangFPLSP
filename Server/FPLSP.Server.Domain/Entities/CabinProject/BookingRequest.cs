using FPLSP.Server.Domain.Entities.EntitiesBase;
using FPLSP.Server.Domain.Entities.UserParts;

namespace FPLSP.Server.Domain.Entities.CabinProject
{
    public class BookingRequest : EntityBase<Guid>
    {

        public int IndexOfBookingRequest { get; set; }
        public int Status { get; set; }
        public DateTime SendingTime { get; set; }
        public string ContenOfFeedBack { get; set; }
        public string ContentOfRequest { get; set; }
        public DateTime FeedBackTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Guid IdLectuter { get; set; }
        public Guid SubjectId { get; set; }
        public Guid ClassId { get; set; }

        //
        public virtual SubjectClassUP SubjectClassUP { get; set; }



    }
}
