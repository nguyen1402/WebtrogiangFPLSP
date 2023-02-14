using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class SubjectCP : FullEntityBase<Guid>
    {

        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public DateTime CreatedDay { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public int TotalOfSub { get; set; }
        public int Status { get; set; }
        public bool IsDemo { get; set; }
        public string Image { get; set; }
        public virtual ICollection<SpecializedSubjectCP> SpecializedSubjectCPs { get; set; }
        public virtual ICollection<ExamCP> ExamCPs { get; set; }
        public virtual ICollection<QuizCP> QuizCps { get; set; }
        public virtual ICollection<LessonCP> LessonCPs { get; set; }
    }
}
