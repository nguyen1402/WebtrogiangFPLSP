namespace FPLSP.Server.Domain.Dtos
{
    public class ContentOfExamCPDto
    {
        public Guid Id { get; set; }
        public Guid? ExamId { get; set; }
        public string CoeCode { get; set; }
        public int Level { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateStarted { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public int TotalOfQuestions { get; set; }
        public int QuestionType { get; set; }
        public string Content { get; set; }
        public int Status { get; set; }
        public bool IsChecked { get; set; }
        public bool IsDeleted { get; set; }
    }
}
