using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.TrainingFacilitiesCPVm
{
    public class TrainingFacilitiesCPListSearch : PagingParameters
    {
        public string? Name { get; set; }
        public int? Status { get; set; }
    }
}
