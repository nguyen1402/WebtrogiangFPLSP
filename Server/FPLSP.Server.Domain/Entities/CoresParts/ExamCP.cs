using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class ExamCP : EntityBase<Guid>
    {

        //        ExamCode
        //ExamName
        //Status

        public string ExamCode { get; set; }
        public string ExamName { get; set; }
        public int Status { get; set; }
        //khóa ngoại
        public Guid? SubjectId { get; set; }
        public SubjectCP subjectCP { get; set; }
        //
        public ICollection<ContentOfExamCP> contentOfExamCPs { get; set; }
        public ICollection<ExamLinkCP> examLinkCPs { get; set; }
    }
}
