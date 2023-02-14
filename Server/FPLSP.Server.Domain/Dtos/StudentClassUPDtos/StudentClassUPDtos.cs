namespace FPLSP.Server.Domain.Dtos.StudentClassUPDtos
{
    public class StudentClassUPDtos
    {
        public Guid? StudentId { get; set; }
        public Guid? ClassId { get; set; }

        public int Status { get; set; }
        public int StatusOfStudent { get; set; }
        public string JoinCodeAsign { get; set; }
    }
}
