using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class LessonCP : FullEntityBase<Guid>
    {

        public Guid SubjectId { get; set; }
        public string LessonName { get; set; }
        public string LessonCode { get; set; }
        public int IndexOfLesson { get; set; }
        public string Descriptions { get; set; }
        public int Status { get; set; }

        public virtual SubjectCP SubjectCP { get; set; }
        public virtual ICollection<LessonContentCP> LessonContentCPs { get; set; }
    }
}
