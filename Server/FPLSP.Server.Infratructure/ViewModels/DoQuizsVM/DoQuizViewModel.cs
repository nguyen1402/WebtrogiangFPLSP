namespace FPLSP.Server.Infrastructure.ViewModels.DoQuizsVM;

public class DoQuizViewModel
{
    public DoQuizViewModel()
    {
        QuestionIdCollection = new List<AnswerQuestionViewModel>();
    }

    public Guid StudentId { get; set; }
    public List<AnswerQuestionViewModel> QuestionIdCollection { get; set; }

}