using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.QuizAnswerCPVm
{
    public class ListSearchQuizAnswerCP : PagingParameters
    {
        public string? QuestionCode { get; set; }
        public string? Answer { get; set; }
    }
}
