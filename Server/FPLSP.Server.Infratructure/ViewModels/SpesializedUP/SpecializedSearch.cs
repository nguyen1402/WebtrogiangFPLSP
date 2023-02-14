using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.SpesializedUP
{
    public class SpecializedSearch : PagingParameters
    {
        public string? Name { get; set; }
        public int? Status { get; set; }
    }
}
