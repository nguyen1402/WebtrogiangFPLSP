namespace FPLSP.Server.Domain.Dtos.DoQuizDtos;

public class AnswerDto
{
    public Guid Id { get; set; }
    public string? Answer { get; set; }
    public int? Status { get; set; }
    public bool StudentChoose { get; set; }
    public bool IsCorrect { get; set; }
    public Guid QuizQuestionId { get; set; }
}