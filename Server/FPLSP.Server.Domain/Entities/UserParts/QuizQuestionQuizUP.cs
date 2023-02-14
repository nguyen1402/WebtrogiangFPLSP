using FPLSP.Server.Domain.Entities.UsesParts;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPLSP.Server.Domain.Entities.UserParts
{
    public class QuizQuestionQuizUP
    {
        public Guid? QuizQuestionId { get; set; }
        public Guid? QuizId { get; set; }
        public int Status { get; set; }
        [ForeignKey("QuizQuestionId")]
        public virtual QuizQuestionUP QuizQuestionUP { get; set; }

        [ForeignKey("QuizId")]
        public virtual QuizUP QuizUP { get; set; }
    }
}
