namespace FPLSP.Server.Infrastructure.ViewModels.AnswerUp
{
    public class AnswerUpVm
    {
        public Guid Id { get; set; }

        public string Answer { get; set; }
        public int Status { get; set; }
        public Guid QuizQuestionId { get; set; }

    }
}
