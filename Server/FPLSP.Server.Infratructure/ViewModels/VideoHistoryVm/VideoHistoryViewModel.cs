namespace FPLSP.Server.Infrastructure.ViewModels.VideoHistoryVm
{
    public class VideoHistoryViewModel  //Hiển thị VideoHistory 
    {
        public Guid IdStudent { get; set; }
        public Guid IdLessonContent { get; set; }
        public DateTime TimeOfSaveHistory { get; set; }
        public DateTime WatchedTime { get; set; }
        public bool IsBookMarked { get; set; }
        public int Status { get; set; }
        public string Path { get; set; }
        public string LessonContentCode { get; set; }
        public string LessonContentName { get; set; }
    }
}
