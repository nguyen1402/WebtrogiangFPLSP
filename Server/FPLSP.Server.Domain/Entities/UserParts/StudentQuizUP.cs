using FPLSP.Server.Domain.Entities.UserParts;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPLSP.Server.Domain.Entities.UsesParts;

public class StudentQuizUP
{
    public StudentQuizUP()
    {
        ScoreQuizOfStudent = 0;
    }
    public Guid? StudentId { get; set; }
    // QuizId : Id câu hỏi 
    public Guid? QuizId { get; set; }
    [ForeignKey("StudentId")]
    public virtual StudentUP StudentUp { get; set; }
    [ForeignKey("QuizId")]
    public virtual QuizUP QuizUP { get; set; }
    public double ScoreQuizOfStudent { get; set; }
    public int Status { get; set; }
    public int CounterTurn { get; set; }
    public virtual ICollection<TakeAnswerUP> TakeAnswerUP { get; set; }

    // TakeAnswerId : ID câu trả lời

}