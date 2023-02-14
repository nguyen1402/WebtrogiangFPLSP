namespace FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop
{
    public class LectuterSpecializedSubjectVM
    {
        public Guid? LectuterId { get; set; }
        public Guid? SpecializedId { get; set; }
        public Guid? SubjectId { get; set; }
        public string SpecializationName { get; set; }
        public string SubjectName { get; set; }
        public DateTime CreatedDay { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public int TotalOfSub { get; set; }
        public string LecturersName { get; set; }
        public bool Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
        public string ImageUrl { get; set; }
    }
}
