using FPLSP.Server.Domain.Enums;

namespace FPLSP.Server.Domain.Dtos.QuestionType
{
    public class QuestionTypeDto
    {
        public Guid Id { get; set; }
        public string QuestionTypeName { get; set; }
        public QuestionForms QuestionForm { get; set; }
    }
}
