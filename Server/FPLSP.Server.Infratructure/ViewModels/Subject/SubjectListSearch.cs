using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.Subject
{
    public class SubjectListSearch : PagingParameters
    {
        public Guid SpecializedId { get; set; }
        public string? SubjectCode { get; set; }
        public string? Name { get; set; }
        public int? Status { get; set; }

    }
}