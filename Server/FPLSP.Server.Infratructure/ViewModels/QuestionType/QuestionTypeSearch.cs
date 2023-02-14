using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Enums;

namespace FPLSP.Server.Infrastructure.ViewModels.QuestionType
{
    public class QuestionTypeSearch : PagingParameters
    {
        public string? QuestionTypeName { get; set; }

        public QuestionForms? QuestionForm { get; set; }
    }
}
