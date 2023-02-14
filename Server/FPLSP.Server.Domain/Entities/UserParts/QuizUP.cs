using FPLSP.Server.Domain.Entities.EntitiesBase;
using FPLSP.Server.Domain.Entities.UserParts;

namespace FPLSP.Server.Domain.Entities.UsesParts;

public class QuizUP : FullEntityBase<Guid>
{

    //QuizTitle : Tiêu đề bài kiểm tra
    public string QuizTitle { get; set; }
    //  StartDay : Ngày Bắt đầu
    public DateTimeOffset StartDay { get; set; }
    // EndDay : Ngày kết thúc 
    public DateTimeOffset EndDay { get; set; }
    public string QuizName { get; set; }
    public string Descriptions { get; set; }
    public int Status { get; set; }
    public Guid? SubjectId { get; set; }

    public int MaxTurn { get; set; }
    public SubjectUP SubjectUp { get; set; }
    public virtual ICollection<QuizQuestionQuizUP> QuizQuestionQuizUPs { get; set; }

    public virtual ICollection<StudentQuizUP> StudentQuizUps { get; set; }
}