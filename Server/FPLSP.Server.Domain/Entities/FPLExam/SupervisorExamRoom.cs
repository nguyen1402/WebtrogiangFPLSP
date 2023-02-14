using FPLSP.Server.Domain.Entities.CoresParts;

namespace FPLSP.Server.Domain.Entities.FPLExam
{
    public class SupervisorExamRoom
    {
        public Guid IdLecturter { get; set; }
        public string SecretKey { get; set; }
        public Guid IdExaminationRoom { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        //
        public int Status { get; set; }
        public bool IsMainSupervisor { get; set; }
        public string? Note { get; set; }
        //
        public virtual LecturersCP LecturersCP { get; set; }
        public virtual ExaminationRoomDetail ExaminationRoomDetail { get; set; }

    }
}
