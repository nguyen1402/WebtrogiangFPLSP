using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class LessonContentCP : FullEntityBase<Guid>
    {
        public string Content { get; set; }
        public string Descriptions { get; set; }
        public string LessonContentCode { get; set; }
        public string LessonContentName { get; set; }
        public int Status { get; set; }
        public int IndexOfLessonContent { get; set; }
        public Guid? IdLesson { get; set; }
        public virtual LessonCP LessonCP { get; set; }
        public Guid? ResourceLinkId { get; set; }
        public ResourceLink ResourceLinks { get; set; }
    }
}
