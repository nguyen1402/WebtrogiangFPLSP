using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.StudentStatistics
{
    public class StudentStatisticListSearch : PagingParameters
    {
        public string? Masv { get; set; }
        public string? trangthai { get; set; }

        public string? quizid { get; set; }
    }
}
