using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.NewFeed
{
    public class SearchNewFeed : PagingParameters
    {
        public string? Title { get; set; }

        public string? Content { get; set; }
        public Guid? IdClass { get; set; }
        public Guid? IdSubject { get; set; }
        public Guid? IdTypeOfNewFeed { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CratedTime { get; set; }
    }
}
