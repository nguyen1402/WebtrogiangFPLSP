using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.VideoHistoryVm
{
    public class VideoHistoryListSearch : PagingParameters
    {
        public string? LessonContentName { get; set; }//tìm kiếm theo name

    }
}
