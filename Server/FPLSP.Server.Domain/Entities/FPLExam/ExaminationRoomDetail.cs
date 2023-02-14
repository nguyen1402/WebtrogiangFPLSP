using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.UsesParts;

namespace FPLSP.Server.Domain.Entities.FPLExam
{
    public class ExaminationRoomDetail
    {

        public Guid IdExaminationRoom { get; set; }
        public string SecretKey { get; set; }
        //hết các khóa chính
        public int IndexOfExaminationRoomDetail { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
        //
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Guid IdSubject { get; set; }
        public Guid IdBlock { get; set; }
        public int TotalTimeOfExam { get; set; }
        public Guid IdSemester { get; set; }
        public Guid IdExamFile { get; set; }
        public virtual SemesterBlock SemesterBlock { get; set; }
        public virtual ExaminationRoom ExaminationRoom { get; set; }
        public virtual SubjectUP SubjectUP { get; set; }
        public virtual ExamStorage ExamStorage { get; set; }

        public ICollection<SupervisorExamRoom> SupervisorExamRooms { get; set; }
        public ICollection<OnlineExamRoom> onlineExamRooms { get; set; }

    }
}
