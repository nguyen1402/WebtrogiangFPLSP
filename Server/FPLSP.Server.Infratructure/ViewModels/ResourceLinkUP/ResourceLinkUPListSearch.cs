using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.ResourceLinkUP
{
    public class ResourceLinkUPListSearch : PagingParameters
    {
        public string? Name { get; set; }
        public int? Status { get; set; }
    }
}
