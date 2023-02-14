using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.QuizQuesstionQuizCP
{
    public class QuizQuesstionQuizCPListSearch : PagingParameters
    {
        public string? Name { get; set; }

        //public Guid? KindoOfQuestionId { get; set; }
        public int Status { get; set; }
    }
}
