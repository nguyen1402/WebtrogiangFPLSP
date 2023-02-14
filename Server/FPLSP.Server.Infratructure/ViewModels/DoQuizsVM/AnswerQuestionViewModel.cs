namespace FPLSP.Server.Infrastructure.ViewModels.DoQuizsVM;

public class AnswerQuestionViewModel
{
    public AnswerQuestionViewModel()
    {
        AnswerId = new List<Guid>();
        Answer = new List<string>();
    }
    public List<string> Answer { get; set; }
    public Guid QuestionId { get; set; }
    public List<Guid> AnswerId { get; set; }
}