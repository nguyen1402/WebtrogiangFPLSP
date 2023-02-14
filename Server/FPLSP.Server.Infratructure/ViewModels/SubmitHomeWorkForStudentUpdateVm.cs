namespace FPLSP.Server.Infrastructure.ViewModels
{
    public class SubmitHomeWorkForStudentUpdateVm
    {
        public Guid Id { get; set; }
        public DateTime? SubmitTime { get; set; }
        public string? SubmitLink { get; set; }

        public int Status { get; set; }

    }
}
