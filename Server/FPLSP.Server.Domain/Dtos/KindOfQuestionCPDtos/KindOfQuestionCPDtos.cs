using FPLSP.Server.Domain.Enums;

namespace FPLSP.Server.Domain.Dtos.KindOfQuestionCPDtos
{
    public class KindOfQuestionCPDtos
    {
        public Guid Id { get; set; }
        public string QuestionTypeName { get; set; }

        // QuestionForm : Mẫu Câu hỏi
        public QuestionForms QuestionForm { get; set; }
    }
}
