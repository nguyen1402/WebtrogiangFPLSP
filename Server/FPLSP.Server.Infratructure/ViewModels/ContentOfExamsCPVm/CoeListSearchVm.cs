using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.ContentOfExamsCP
{
    public class CoeListSearchVm : PagingParameters
    {
        public string? CoeCode { get; set; }
        public string? Content { get; set; }
        public int? Status { get; set; }
    }
}
