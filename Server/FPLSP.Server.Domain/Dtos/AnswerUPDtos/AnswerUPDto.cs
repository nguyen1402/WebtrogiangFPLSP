namespace FPLSP.Server.Domain.Dtos.AnswerUPDtos
{
    public class AnswerUPDto
    {
        public Guid Id { get; set; }
        public string Answer { get; set; }
        public Guid? QuizQuestionId { get; set; }
        public int Status { get; set; }
    }
}
