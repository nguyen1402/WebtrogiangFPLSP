namespace FPLSP.Server.Infrastructure.ViewModels.StudentClassUPVm
{
    public class StudentClassUPCreateVm
    {
        public Guid? StudentId { get; set; }

        public Guid? ClassId { get; set; }
        public int Status { get; set; }
        public int StatusOfStudent { get; set; }
        public string JoinCodeAsign { get; set; }
    }
}
