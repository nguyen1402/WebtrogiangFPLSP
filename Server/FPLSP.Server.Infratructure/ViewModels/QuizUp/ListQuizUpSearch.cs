using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.QuizUp
{
    public class ListQuizUpSearch : PagingParameters
    {
        public int? Status { get; set; }
        public string? Search { get; set; }
    }
}
