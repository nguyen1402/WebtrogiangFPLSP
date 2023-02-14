namespace FPLSP.Server.Domain.Entities.UserParts
{
    public class ClassUp

    {
        public Guid Id { get; set; }
        public string ClassroomName { get; set; }// tên lớp học 

        public string Building { get; set; }// Tòa Nhà 

        public int Status { get; set; }// trạng thái 

        public virtual ICollection<ReportClassUP> ReportClassUps { get; set; }

        public virtual ICollection<StudentClassUP> StudentClassUPs { get; set; }
        public virtual ICollection<SubjectClassUP> SubjectClassUPs { get; set; }

    }
}
