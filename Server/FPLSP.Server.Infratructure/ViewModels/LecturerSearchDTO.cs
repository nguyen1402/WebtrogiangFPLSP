using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels
{
    public class LecturerSearchDTO : PagingParameters
    {
        public string? Name { get; set; }
        public Guid? RoleId { get; set; }

        public Guid? TrainingFacilitiesId { get; set; }

        public Guid? SpecializedId { get; set; }
    }
}
