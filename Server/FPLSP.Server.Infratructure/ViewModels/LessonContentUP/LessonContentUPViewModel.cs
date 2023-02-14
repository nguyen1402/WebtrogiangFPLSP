namespace FPLSP.Server.Infrastructure.ViewModels.LessonContentUP
{
    public class LessonContentUPViewModel //Hiển thị LessonContentUP
    {
        public Guid Id { get; set; }
        public string LessonContentCode { get; set; }
        public string LessonContentName { get; set; }
        public string? Content { get; set; }
        public string? Descriptions { get; set; }
        public int Status { get; set; }
        public bool IsChecked { get; set; }
        public Guid? LessonId { get; set; }
        public Guid? ResuorceLinkId { get; set; }
    }
}
