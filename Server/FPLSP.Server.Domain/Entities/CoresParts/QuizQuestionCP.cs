using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class QuizQuestionCP : EntityBase<Guid>
    {

        public string QuestionTital { get; set; }
        public string ContentQuestion { get; set; }
        public Guid? KindoOfQuestionId { get; set; }

        public string QuestionName { get; set; }
        public string QuestionCode { get; set; }
        public int Status { get; set; }


        public virtual KindoOfQuestionCP KindoOfQuestionCP { get; set; }

        public virtual ICollection<QuizAnswerCP> QuizAnswerCp { get; set; }
        public virtual ICollection<QuizQuestionQuizCP> QuizQuestionQuizCPs { get; set; }

    }
}
