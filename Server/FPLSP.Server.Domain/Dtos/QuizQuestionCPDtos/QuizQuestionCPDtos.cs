using FPLSP.Server.Domain.Enums;

namespace FPLSP.Server.Domain.Dtos.QuizQuestionCPDtos
{
    public class QuizQuestionCPDtos
    {
        public Guid Id { get; set; }
        public Guid? KindoOfQuestionId { get; set; }
        public QuestionForms? QuizQuestionForm { get; set; }
        public string? QuestionTypeName { get; set; }
        public string QuestionName { get; set; }
        public string QuestionCode { get; set; }
        public int Status { get; set; }
    }
}
