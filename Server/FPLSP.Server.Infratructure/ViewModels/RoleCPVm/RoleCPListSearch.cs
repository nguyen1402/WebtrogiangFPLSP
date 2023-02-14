using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.RoleCPVm
{
    public class RoleCPListSearch : PagingParameters
    {
        public string? Name { get; set; }
        public int? Status { get; set; }
    }
}
