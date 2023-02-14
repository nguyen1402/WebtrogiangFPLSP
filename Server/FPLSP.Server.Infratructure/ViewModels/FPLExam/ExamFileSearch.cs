using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.FPLExam
{
    public class ExamFileSearch : PagingParameters
    {
        public string? IdUserUpload { get; set; }
        public string? SubjectName { get; set; }
        public string? FileName { get; set; }
        public DateTime? CreateTime { get; set; }

        public DateTime? DeleteTime { get; set; }
    }
}
