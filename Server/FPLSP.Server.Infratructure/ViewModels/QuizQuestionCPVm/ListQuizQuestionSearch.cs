using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.QuizQuestionCPVm
{
    public class ListQuizQuestionSearch : PagingParameters
    {
        public string? QuizQuestionName { get; set; }

        public Guid? KindoOfQuestionId { get; set; }
        public int? Status { get; set; }
    }
}
