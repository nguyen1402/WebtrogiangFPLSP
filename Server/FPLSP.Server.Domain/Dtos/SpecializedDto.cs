namespace FPLSP.Server.Domain.Dtos
{
    public class SpecializedDto
    {
        public Guid Id { get; set; }
        public string SpecializedCode { get; set; }
        public string SpecializationName { get; set; }
        public int Status { get; set; }
        public int Level { get; set; }
        public string Image { get; set; }
        public Guid? IdSpeciality { get; set; }

        // Them cho LecturerPages

        public bool IsChecked { get; set; } = false;
    }
}
