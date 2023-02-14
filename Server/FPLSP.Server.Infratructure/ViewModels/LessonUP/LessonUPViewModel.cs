namespace FPLSP.Server.Infrastructure.ViewModels.LessonUP
{
    public class LessonUPViewModel //Hiển thị LessonUP
    {
        public Guid Id { get; set; }
        public string LessonName { get; set; }
        public string LessonCode { get; set; }
        public string Descriptions { get; set; }
        public bool IsCompleted { get; set; }
        public int Status { get; set; }
        public int IndexOfLesson { get; set; }
        public bool IsChecked { get; set; }
        public Guid? SubjectId { get; set; }
    }
}
