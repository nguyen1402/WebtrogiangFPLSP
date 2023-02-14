namespace FPLSP.Server.Domain.Dtos.TakeAnswerDtos;

public class TakeAnswerUPDto
{
    public Guid Id { get; set; }

    public Guid QuestionId { get; set; }
    // StudentQuizId : id sinh viên trả lời câu hỏi 
    public Guid? StudentId { get; set; }
    // QuizId : Id câu hỏi 
    public Guid? QuizId { get; set; }
    // TakeAnswers : câu trả lời của sinh viên
    public Dictionary<Guid, Guid> TakeAnswers { get; set; } = new Dictionary<Guid, Guid>();

}