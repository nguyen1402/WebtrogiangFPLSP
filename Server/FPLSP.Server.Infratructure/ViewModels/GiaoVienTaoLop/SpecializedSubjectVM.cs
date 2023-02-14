namespace FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop
{
    public class SpecializedSubjectVM
    {
        public Guid? SpecializedId { get; set; }
        public Guid? SubjectId { get; set; }
        public string SpecializationName { get; set; }
        public string SubjectName { get; set; }
        public DateTime CreatedDay { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public int TotalOfSub { get; set; }

        public int Status { get; set; }
    }
}
