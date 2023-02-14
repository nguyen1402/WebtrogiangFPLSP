using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.UsesParts;

public class ResourceLinkUP : EntityBase<Guid>
{
    // ResourcesTitle  : Tiêu đề tài nguyên 
    public string ResourcesTitle { get; set; }

    // ResourcesUrl : đường dẫn tài nguyên
    public Guid IdSubject { get; set; }
    public int IndexOfVideo { get; set; }
    public DateTime DateCreated { get; set; }
    public string Path { get; set; }
    public string Descriptions { get; set; }
    public int Status { get; set; }
    public virtual ICollection<LessonContentUP> LessonContentUP { get; set; }

}