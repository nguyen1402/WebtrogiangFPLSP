using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;

namespace FPLSP.Server.Infrastructure.ViewModels.Quizz
{
    public class QuizzForStudent
    {
        public Guid? StudentId { get; set; }
        // QuizId : Id câu hỏi 
        public Guid? QuizId { get; set; }
        public List<QuizQuestionQuizUP> ListQuizzQuestion { get; set; }
        public TakeAnswerUP takeAnswerUP { get; set; }
        public List<Guid> ListAnswer { get; set; }


    }

}
