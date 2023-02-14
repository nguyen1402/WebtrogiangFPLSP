using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.LessonContentUP
{
    public class LessonContentUPListSearch : PagingParameters
    {
        public string? Name { get; set; }
        public int? Status { get; set; }
        public Guid? LessonId { get; set; }
        public Guid? ResuorceLinkId { get; set; }
    }
}
