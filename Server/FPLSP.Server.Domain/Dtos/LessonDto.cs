namespace FPLSP.Server.Domain.Dtos
{
    public class LessonDto
    {
        public Guid Id { get; set; }
        public Guid? SubjectId { get; set; }
        public string LessonName { get; set; }
        public string LessonCode { get; set; }
        public string Descriptions { get; set; }

        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int TotalOfSub { get; set; }
        public int Status { get; set; }
        public int Index { get; set; }
        public bool IsChecked { get; set; } = false;
    }
}
