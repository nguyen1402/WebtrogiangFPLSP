using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UsesParts;

namespace FPLSP.Server.Domain.Entities.FPLExam
{
    public class SubjectTeacher
    {
        public Guid IdTeacher { get; set; }
        public Guid IdSubject { get; set; }
        public DateTime AddingTime { get; set; }
        public int Status { get; set; }
        public virtual LecturersCP LecturersCP { get; set; }
        public virtual SubjectUP SubjectUP { get; set; }
    }
}
