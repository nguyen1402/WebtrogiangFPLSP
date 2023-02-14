using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.ReportClassUP
{
    public class ReportClassUpSearch : PagingParameters
    {
        public string? Describe { get; set; }
        public int? Lever { get; set; }
    }
}
