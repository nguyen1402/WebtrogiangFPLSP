namespace FPLSP.Server.Infrastructure.ViewModels.QuizQuestionUp
{
    public class QuizQuestionUpVm
    {
        public Guid Id { get; set; }
        public string QuestionTital { get; set; }

        public string ContentQuestion { get; set; }

        public string QuestionName { get; set; }
        public string QuestionCode { get; set; }
        public int Status { get; set; }
        public Guid? QuestionTypeId { get; set; }
    }
}
