using FPLSP.Server.Domain.Enums;

namespace FPLSP.Server.Domain.Dtos.DoQuizDtos;

public class QuestionDto
{
    public QuestionDto()
    {
        AnswerDtoCollection = new List<AnswerDto>();
    }
    public Guid Id { get; set; }
    public int QuestionNumber { get; set; }
    public string QuestionTital { get; set; }
    public string ContentQuestion { get; set; }
    public List<AnswerDto> AnswerDtoCollection { get; set; }
    public Guid TypeId { get; set; }
    public QuestionForms TypeName { get; set; }
}