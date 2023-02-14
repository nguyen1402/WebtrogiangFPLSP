using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.StudentCP
{
    public class StudentCPListSearch : PagingParameters
    {
        public string? NameStudent { get; set; }
        public string? Status { get; set; }
    }
}
