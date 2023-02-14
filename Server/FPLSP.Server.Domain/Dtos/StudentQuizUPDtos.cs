namespace FPLSP.Server.Domain.Dtos
{
    public class StudentQuizUPDtos
    {
        public string StudentName { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public Guid? StudentId { get; set; }
        public Guid? QuizId { get; set; }
        public string QuizName { get; set; }
        public double ScoreQuizOfStudent { get; set; }
        public int Status { get; set; }
        public int CounterTurn { get; set; }
    }
}
