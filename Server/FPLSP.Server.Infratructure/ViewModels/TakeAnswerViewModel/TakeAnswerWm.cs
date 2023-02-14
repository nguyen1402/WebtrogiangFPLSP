namespace FPLSP.Server.Infrastructure.ViewModels.TakeAnswerViewModel;

public class TakeAnswerWm
{
    public Guid StudentId { get; set; }
    public Guid QuizId { get; set; }
    public Guid QuestionId { get; set; }
    public Dictionary<Guid, Guid> TakeAnswers { get; set; } = new Dictionary<Guid, Guid>();
}