namespace FPLSP.Server.Infrastructure.ViewModels.QuizAnswerCPVm
{
    public class QuizAnswerCPVm
    {
        public Guid Id { get; set; }
        public string QuestionCode { get; set; }
        public string Answer { get; set; }
        public Guid IdQuizQuestion { get; set; }
    }
}
