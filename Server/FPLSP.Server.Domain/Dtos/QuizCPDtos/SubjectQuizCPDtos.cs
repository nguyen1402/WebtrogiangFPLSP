namespace FPLSP.Server.Domain.Dtos.QuizCPDtos
{
    public class SubjectQuizCPDtos
    {
        public Guid Id { get; set; }
        public string QuizName { get; set; }
        public string Descriptions { get; set; }
        public int MaxTurn { get; set; }
        public double Point { get; set; }
        public int Status { get; set; }
        public DateTimeOffset StartDay { get; set; }
        public DateTimeOffset EndDay { get; set; }
        public bool IsChecked { get; set; } = false;
    }
}
