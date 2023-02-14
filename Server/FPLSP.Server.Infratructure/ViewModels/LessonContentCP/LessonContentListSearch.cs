using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.LessonContentCP
{
    public class LessonContentListSearch : PagingParameters
    {
        public string? Name { get; set; }
        public int Status { get; set; }

    }
}
