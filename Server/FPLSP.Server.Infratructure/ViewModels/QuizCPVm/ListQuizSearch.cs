using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.QuizCPVm
{
    public class ListQuizSearch : PagingParameters
    {
        public int Status { get; set; }
        public string? QuizName { get; set; }
    }
}
