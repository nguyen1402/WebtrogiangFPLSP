namespace FPLSP.Server.Infrastructure.ViewModels.SubmitHomeWorkVM
{
    public class SubmitListHomeWorkCreateVM
    {
        public DateTime StartedDate { get; set; } = DateTime.Now;
        public DateTime EndTime { get; set; } = DateTime.Now;
        public DateTime? SubmitTime { get; set; } = DateTime.Now;
        public List<Guid?> IdClass { get; set; }
        public Guid IdSubject { get; set; }
        public List<Guid?> LsIdStudent { get; set; }
        public List<Guid?> IdLesson { get; set; }
    }
}
