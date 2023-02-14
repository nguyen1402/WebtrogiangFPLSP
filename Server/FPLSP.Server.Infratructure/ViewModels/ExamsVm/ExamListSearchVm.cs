using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.Exams
{
    public class ExamListSearchVm : PagingParameters
    {
        public string? ExamCode { get; set; }
        public string? ExamName { get; set; }
        public int? Status { get; set; }
    }
}
