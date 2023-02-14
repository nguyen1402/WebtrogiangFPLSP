using FPLSP.Server.Domain.Entities.UserParts;

namespace FPLSP.Server.Infrastructure.ViewModels.StudentClassUPVm
{
    public class StudentClassUPUpdateVm
    {
        public Guid? StudentId { get; set; }
        // QuizId : Id câu hỏi 
        public Guid? ClassId { get; set; }
        public virtual StudentUP StudentUp { get; set; }
        public virtual ClassUp ClassUp { get; set; }
        public int Status { get; set; }
        public int StatusOfStudent { get; set; }
        public string JoinCodeAsign { get; set; }
    }
}
