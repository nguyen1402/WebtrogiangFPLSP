using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.UsesParts;

public class AnswerUP : EntityBase<Guid>
{
    // QuestionId : ID câu hỏi 

    // Answer : Câu trả lời

    public string Answer { get; set; }
    public int Status { get; set; }
    public bool IsCorrect { get; set; }
    public Guid? QuizQuestionId { get; set; }

    public QuizQuestionUP QuizQuestionUp { get; set; }
}