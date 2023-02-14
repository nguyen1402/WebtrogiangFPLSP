using System.ComponentModel.DataAnnotations.Schema;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class QuizQuestionQuizCP
    {

        public Guid? QuizQuestionId { get; set; }
        public Guid? QuizId { get; set; }
        [ForeignKey("QuizQuestionId")]
        public virtual QuizQuestionCP QuizQuestionCP { get; set; }
        public int Status { get; set; }
        [ForeignKey("QuizId")]
        public virtual QuizCP QuizCP { get; set; }
    }
}
