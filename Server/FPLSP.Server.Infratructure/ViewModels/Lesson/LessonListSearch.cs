using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.Lesson
{
    public class LessonListSearch : PagingParameters
    {
        public string? Name { get; set; }
        public int Status { get; set; }

    }
}