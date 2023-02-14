using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.Specialized
{
    public class SpecializedListSearch : PagingParameters
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public int? Status { get; set; }
    }
}

