namespace FPLSP.Server.Domain.Dtos
{
    public class ExamCPDto
    {
        public Guid Id { get; set; }
        public string ExamCode { get; set; }
        public string ExamName { get; set; }
        public int Status { get; set; }
        public bool IsChecked { get; set; }

        public Guid? SubjectId { get; set; }
    }
}
