namespace FPLSP.Server.Domain.Dtos.StudentStatisticVM
{
    public class QuizSummit
    {
        public Guid? QuizId { get; set; }
        public Guid? StudentId { get; set; }
        public string QuizName { get; set; }
        public double ScoreQuizOfStudent { get; set; }
    }
}
