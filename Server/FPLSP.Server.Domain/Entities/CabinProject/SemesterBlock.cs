using FPLSP.Server.Domain.Entities.FPLExam;

namespace FPLSP.Server.Domain.Entities.CabinProject
{
    public class SemesterBlock
    {

        public Guid IdBlock { get; set; }
        public Guid IdSemester { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int IndexOfSemesterBlock { get; set; }
        public int Status { get; set; }
        //
        public virtual Semester Semester { get; set; }
        public virtual Block Block { get; set; }
        public virtual ICollection<TeachingSchedule> TeachingSchedules { get; set; }
        public virtual ICollection<ExaminationRoomDetail> ExaminationRoomDetails { get; set; }

    }
}
