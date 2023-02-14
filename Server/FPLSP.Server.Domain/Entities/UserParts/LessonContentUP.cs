using FPLSP.Server.Domain.Entities.EntitiesBase;
using FPLSP.Server.Domain.Entities.UserParts;

namespace FPLSP.Server.Domain.Entities.UsesParts;

public class LessonContentUP : FullEntityBase<Guid>
{
    // LessonContentName :Tên nội dung bài học 
    public string Content { get; set; }
    public string Descriptions { get; set; }
    public string LessonContentCode { get; set; }
    public string LessonContentName { get; set; }
    public int Status { get; set; }
    public Guid? LessonId { get; set; }
    public int IndexOfLessonContent { get; set; }
    public LessonUP LessonUP { get; set; }

    public Guid? ResuorceLinkId { get; set; }
    public ResourceLinkUP ResourceLinkUP { get; set; }
    public virtual ICollection<VideoHistory> VideoHistories { get; set; }
}