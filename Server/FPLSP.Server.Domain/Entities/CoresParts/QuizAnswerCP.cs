using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class QuizAnswerCP : EntityBase<Guid>
    {
        public string Answer { get; set; }
        public bool IsCorrect { get; set; }
        public Guid IdQuizQuestion { get; set; }

        public virtual QuizQuestionCP QuizQuestionCP { get; set; }
    }
}
