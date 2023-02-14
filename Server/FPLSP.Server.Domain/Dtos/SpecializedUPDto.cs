namespace FPLSP.Server.Domain.Dtos
{
    public class SpecializedUPDto
    {
        public Guid Id { get; set; }

        public string SpecializedCode { get; set; }

        public string SpecializationName1 { get; set; }
        public string SpecializationName2 { get; set; }
        public string SpecializationName3 { get; set; }

        public int Status { get; set; }

        public Guid? SpecialityId { get; set; }

        public int Level { get; set; }

        public DateTimeOffset CreateTime { get; set; }

        public Guid CreateBy { get; set; }

        public DateTimeOffset ModifiedTime { get; set; }

        public Guid ModifiedBy { get; set; }

        public bool IsDeleted { get; set; }

        public Guid DeletedBy { get; set; }

        public DateTimeOffset DeletedTime { get; set; }

    }
}
