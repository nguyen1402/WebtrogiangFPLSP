using FPLSP.Server.Domain.Entities.UserParts;

namespace FPLSP.Server.Domain.Entities.CabinProject
{
    public class BookingCabin
    {
        public Guid Id { get; set; }
        public Guid SubjectId { get; set; }
        public Guid ClassId { get; set; }
        public Guid IdCabin { get; set; }
        public Guid IdShift { get; set; }
        public DateTime DateCreated { get; set; }
        //xong hết các quan hệ
        public byte[]? CheckinImage { get; set; }
        public DateTime CheckinTime { get; set; }
        public DateTime CheckoutTime { get; set; }
        public int IndexOfBookingCabin { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public Guid IdLectuter { get; set; }
        //quan hệ với các bảng
        public virtual SubjectClassUP SubjectClassUP { get; set; }
        public virtual Cabin Cabin { get; set; }
        public virtual Shift Shift { get; set; }



    }
}
