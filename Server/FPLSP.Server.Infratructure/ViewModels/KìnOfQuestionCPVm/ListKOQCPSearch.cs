using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Enums;

namespace FPLSP.Server.Infrastructure.ViewModels.KìnOfQuestionCPVm
{
    public class ListKOQCPSearch : PagingParameters
    {
        public string? QuestionTypeName { get; set; }

        // QuestionForm : Mẫu Câu hỏi
        public QuestionForms? QuestionForm { get; set; }
    }
}
