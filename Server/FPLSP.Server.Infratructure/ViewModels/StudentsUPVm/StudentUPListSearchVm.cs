using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.StudentsUPVm
{
    public class StudentUPListSearchVm : PagingParameters
    {
        public string? NameStudent { get; set; }
        public string? Status { get; set; }
    }
}
