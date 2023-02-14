using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CabinProject
{
    public class Shift : EntityBase<Guid>
    {


        public string ShiftName { get; set; }
        public int IndexOfShift { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public int Status { get; set; }
        //
        public virtual ICollection<BookingCabin> BookingCabins { get; set; }
        public virtual ICollection<TeachingSchedule> TeachingSchedules { get; set; }

    }
}
