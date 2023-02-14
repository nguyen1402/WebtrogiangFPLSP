using FPLSP.Server.Domain.Entities.EntitiesBase;
using FPLSP.Server.Domain.Entities.UserParts;

namespace FPLSP.Server.Domain.Entities.UsesParts;

public class QuizQuestionUP : EntityBase<Guid>
{


    public string QuestionTital { get; set; }

    public string ContentQuestion { get; set; }

    public string QuestionName { get; set; }
    public string QuestionCode { get; set; }
    public int Status { get; set; }

    public Guid? QuestionTypeId { get; set; }

    public QuestionType QuestionTypes { get; set; }

    public virtual ICollection<AnswerUP> AnswerUps { get; set; }
    public virtual ICollection<TakeAnswerUP> TakeAnswerUPs { get; set; }
    public virtual ICollection<QuizQuestionQuizUP> QuizQuestionQuizUPs { get; set; }
}