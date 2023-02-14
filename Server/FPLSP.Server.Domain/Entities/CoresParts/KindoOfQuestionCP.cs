using FPLSP.Server.Domain.Entities.EntitiesBase;
using FPLSP.Server.Domain.Enums;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class KindoOfQuestionCP : EntityBase<Guid>
    {
        public string QuestionTypeName { get; set; }

        // QuestionForm : Mẫu Câu hỏi
        public QuestionForms QuestionForm { get; set; }

        public virtual ICollection<QuizQuestionCP> QuizQuestionCp { get; set; }
    }
}
