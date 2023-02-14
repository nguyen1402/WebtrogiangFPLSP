using FPLSP.Server.Domain.Entities.EntitiesBase;
using FPLSP.Server.Domain.Enums;

namespace FPLSP.Server.Domain.Entities.UsesParts;

public class QuestionType : EntityBase<Guid>
{

    // QuestionTypeName : Tên loại câu hỏi
    public string QuestionTypeName { get; set; }

    // QuestionForm : Mẫu Câu hỏi
    public QuestionForms QuestionForm { get; set; }

    public virtual ICollection<QuizQuestionUP> QuizQuestionUPs { get; set; }
}