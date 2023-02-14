using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.EntitiesBase;
using FPLSP.Server.Domain.Entities.UsesParts;

namespace FPLSP.Server.Domain.Entities.FPLExam
{
    public class ExamStorage : EntityBase<Guid>
    {

        public DateTime CreateTime { get; set; }
        public byte[] ExamFile { get; set; }
        public string FileName { get; set; }
        public int IndexOfExamStorageFile { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }

        public DateTime DeleteTime { get; set; }
        //FK
        public Guid SubjectId { get; set; }
        public string IdUserUpLoad { get; set; }
        public virtual SubjectUP SubjectUP { get; set; }
        public virtual UserSignIn UserSignIn { get; set; }
        //

        public virtual ICollection<ExaminationRoomDetail> ExaminationRoomDetails { get; set; }

    }
}
