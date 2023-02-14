namespace FPLSP.Server.Domain.Dtos.DoQuizDtos;

public class AnswersOfQuizDto
{
    public AnswersOfQuizDto()
    {
        AnswerCollectionOfQuestion = new List<TakeAnswerToList>();
    }

    public Guid QuestionId { get; set; }
    public List<TakeAnswerToList> AnswerCollectionOfQuestion { get; set; }
}