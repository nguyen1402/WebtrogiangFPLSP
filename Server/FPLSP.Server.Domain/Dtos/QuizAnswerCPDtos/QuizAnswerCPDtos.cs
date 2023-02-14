namespace FPLSP.Server.Domain.Dtos.QuizAnswerCPDtos
{
    public class QuizAnswerCPDtos
    {
        public Guid Id { get; set; }
        public string QuestionCode { get; set; }
        public string Answer { get; set; }
        public Guid IdQuizQuestion { get; set; }
    }
}
