namespace FPLSP.Server.Infrastructure.ViewModels.StudentQuizUPVm
{
    public class StudentQuizUpdateUPVM
    {
        public Guid? StudentId { get; set; }
        public Guid? QuizId { get; set; }
        public double ScoreQuizOfStudent { get; set; }
        public int Status { get; set; }
        public int CounterTurn { get; set; }
    }
}
