using FPLSP.Server.Domain.Entities.UsesParts;

namespace FPLSP.Server.Domain.Entities.UserParts
{
    public class SubmitHomeWork
    {

        public Guid Id { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime? SubmitTime { get; set; }
        public string? SubmitLink { get; set; }
        public string? Titile { get; set; }
        public int Status { get; set; }
        public Guid IdClass { get; set; }
        public Guid IdSubject { get; set; }
        public Guid IdStudent { get; set; }
        public Guid IdLesson { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual SubjectClassUP SubjectClassUP { get; set; }
        public virtual StudentUP StudentUP { get; set; }
        public virtual LessonUP LessonUP { get; set; }
    }
}
