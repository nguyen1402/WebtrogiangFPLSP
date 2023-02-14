using FPLSP.Server.Domain.Entities.EntitiesBase;
using FPLSP.Server.Domain.Entities.UserParts;

namespace FPLSP.Server.Domain.Entities.UsesParts;

public class LessonUP : FullEntityBase<Guid>
{

    public string LessonName { get; set; }
    public string LessonCode { get; set; }
    public string Descriptions { get; set; }

    // IsCompleted : Đã hoàn thành 
    public bool IsCompleted { get; set; }
    public int IndexOfLesson { get; set; }
    public int Status { get; set; }
    public Guid? SubjectId { get; set; }
    public SubjectUP SubjectUp { get; set; }

    public virtual ICollection<LessonContentUP> LessonContentUps { get; set; }
    public virtual ICollection<SubmitHomeWork> submitHomeWorks { get; set; }
    public virtual ICollection<News> News { get; set; }
    public virtual ICollection<HomeWork> HomeWorks { get; set; }
}