namespace FPLSP.Server.Domain.Dtos
{
    public class QuizUpDto
    {
        public Guid Id { get; set; }
        public bool IsChecked { get; set; }
        public string QuizTitle { get; set; }
        public string QuizName { get; set; }
        public Guid? SubjectId { get; set; }
        public string Descriptions { get; set; }
        public int MaxTurn { get; set; }
        public bool IsDeleted { get; set; }
        public double Point { get; set; }
        public int Status { get; set; }
        public DateTimeOffset StartDay { get; set; }
        public DateTimeOffset EndDay { get; set; }
    }
}
