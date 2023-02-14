namespace FPLSP.Server.Domain.Dtos
{
    public class VideoHistoryDto
    {
        public Guid IdStuden { get; set; }
        public string Path { get; set; }
        public string LessonContenCode { get; set; }
        public Guid IdLessonConten { get; set; }

        public string LessonContenName { get; set; }
        public DateTime TimeOfSaveHistory { get; set; }
        public bool IsBookmark { get; set; }
        public int Status { get; set; }
        public bool IsChecked { get; set; } = false;
    }
}
