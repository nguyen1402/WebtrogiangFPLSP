namespace FPLSP.Server.Domain.Dtos
{
    public class LectuterSpecializedCPDto
    {
        public Guid Idspecialized { get; set; }
        public Guid Idlecturers { get; set; }
        public bool Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public List<string>? Emsils { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Ethnic { get; set; }
        public string ImageUrl { get; set; }
        public int Status { get; set; }
        public string SpecializedCode { get; set; }
        public string SpecializationName { get; set; }
    }
}
