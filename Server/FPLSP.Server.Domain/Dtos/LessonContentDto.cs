namespace FPLSP.Server.Domain.Dtos
{
    public class LessonContentDto
    {
        public Guid Id { get; set; }
        public string LessonContentCode { get; set; }
        public string LessonContentName { get; set; }
        public string Content { get; set; }
        public string TitleLink { get; set; }
        public string? Pathclone { get; set; }
        public int Status { get; set; }
        public int Index { get; set; }
        public List<string>? Path { get; set; }
        public string? Descriptions { get; set; }
        public Guid? IdLesson { get; set; }
        public Guid? ResourceLinkId { get; set; }
        public bool IsChecked { get; set; }
    }
}
