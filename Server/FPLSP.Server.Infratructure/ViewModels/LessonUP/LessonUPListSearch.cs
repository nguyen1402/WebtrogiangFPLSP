using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.LessonUP
{
    public class LessonUPListSearch : PagingParameters
    {
        public string? Name { get; set; }
        public bool? IsCompleted { get; set; }
        public int? Status { get; set; }
        public Guid? SubjectId { get; set; }
    }
}
