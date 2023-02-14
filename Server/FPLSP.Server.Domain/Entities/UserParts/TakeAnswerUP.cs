

using FPLSP.Server.Domain.Entities.EntitiesBase;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPLSP.Server.Domain.Entities.UsesParts;

public class TakeAnswerUP : EntityBase<Guid>
{
    // QuestionId : Id câu hỏi
    public Guid QuestionId { get; set; }
    public QuizQuestionUP QuizQuestionUP { get; set; }
    // StudentQuizId : id sinh viên trả lời câu hỏi 
    public Guid? StudentId { get; set; }
    // QuizId : Id câu hỏi 
    public Guid? QuizId { get; set; }

    public virtual StudentQuizUP StudentQuizUp { get; set; }

    // TakeAnswers : câu trả lời của sinh viên
    [NotMapped]
    public Dictionary<Guid, Guid> TakeAnswers { get; set; } = new Dictionary<Guid, Guid>();



}