namespace FPLSP.Server.Domain.Dtos
{
    public class SubjectsSpecializedDtos
    {
        public Guid SubjectId { get; set; }
        public Guid SpecializedId { get; set; }
        public string SpecializationName { get; set; }
        public int StatusSpecialized { get; set; }
        public string SubjectName { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public int TotalOfSub { get; set; }
        public int StatusSubject { get; set; }
        public string Image { get; set; }
    }
}
