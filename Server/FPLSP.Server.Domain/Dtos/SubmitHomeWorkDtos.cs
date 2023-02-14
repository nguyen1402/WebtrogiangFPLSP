namespace FPLSP.Server.Domain.Dtos
{
    public class SubmitHomeWorkDtos
    {
        public Guid Id { get; set; }
        public DateTime? SubmitTime { get; set; }
        public string SubmitLink { get; set; }
        public int Status { get; set; }
        public Guid IdClass { get; set; }
        public Guid IdSubject { get; set; }
        public Guid IdStudent { get; set; }
        public Guid IdLesson { get; set; }
        public string LessonName { get; set; }
        public string SubjectName { get; set; }
        public string StudentCode { get; set; }
        public string StudentName { get; set; }
    }
}
