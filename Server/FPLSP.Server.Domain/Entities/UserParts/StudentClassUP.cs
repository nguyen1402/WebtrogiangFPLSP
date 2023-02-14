using System.ComponentModel.DataAnnotations.Schema;

namespace FPLSP.Server.Domain.Entities.UserParts
{
    public class StudentClassUP
    {
        public Guid? StudentId { get; set; }
        // QuizId : Id câu hỏi 
        public Guid? ClassId { get; set; }
        [ForeignKey("StudentId")]
        public virtual StudentUP StudentUp { get; set; }
        [ForeignKey("ClassId")]
        public virtual ClassUp ClassUp { get; set; }
        public int Status { get; set; }
        public int StatusOfStudent { get; set; }
        public string JoinCodeAsign { get; set; }
    }
}
