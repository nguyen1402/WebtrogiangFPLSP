namespace FPLSP.Server.Domain.Dtos
{
    public class ExamLinkDto
    {
        public Guid Id { get; set; }
        public Guid? ExamId { get; set; }
        public string ExamLinkCode { get; set; }
        public string Path { get; set; }
        public DateTime CreatedDay { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsChecked { get; set; }
        public int Status { get; set; }
    }
}
