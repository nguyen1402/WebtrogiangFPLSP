using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.LecturerCPVm
{
    public class LecturersCPListSearch : PagingParameters
    {
        public string? Name { get; set; }
        public int? Status { get; set; }
        public Guid? RoleId { get; set; }
        public Guid? TrainingFacilityID { get; set; }
    }
}
