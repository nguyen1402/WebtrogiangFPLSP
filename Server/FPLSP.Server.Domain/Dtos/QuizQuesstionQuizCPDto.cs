using FPLSP.Server.Domain.Enums;

namespace FPLSP.Server.Domain.Dtos
{
    public class QuizQuesstionQuizCPDto
    {
        public string QuestionTypeName { get; set; }
        public QuestionForms QuestionForm { get; set; }
        public List<string> Answers { get; set; }
        public string QuestionName { get; set; }
        public string ContentQuestion { get; set; }

        public string QuestionCode { get; set; }
        public Guid KindoOfQuestionId { get; set; }

        public int StatusQuizQuestion { get; set; }

        public Guid QuizQuestionId { get; set; }
        public Guid QuizId { get; set; }

        public int StatusQuizQuiz { get; set; }

        public List<bool> lsIsCorrect { get; set; }
        public bool IsChecked { get; set; }
    }
}
