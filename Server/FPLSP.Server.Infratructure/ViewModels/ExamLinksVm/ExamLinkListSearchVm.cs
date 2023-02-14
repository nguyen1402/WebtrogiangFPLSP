using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.ExamLinks
{
    public class ExamLinkListSearchVm : PagingParameters
    {

        public string? ExamLinkCode { get; set; }
        public string? Path { get; set; }
        public DateTime? CreatedDay { get; set; }
        public int? Status { get; set; }
    }
}
