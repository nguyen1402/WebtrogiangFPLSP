using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class ResourceLink : EntityBase<Guid>
    {
        public string ResourcesTitle { get; set; }
        public int IndexOfVideo { get; set; }
        public string Path { get; set; }
        public Guid IdSubject { get; set; }
        public string Descriptions { get; set; }
        public DateTime DateCreated { get; set; }

        public int Status { get; set; }
        public virtual ICollection<LessonContentCP> LessonContentCPs { get; set; }
    }
}
