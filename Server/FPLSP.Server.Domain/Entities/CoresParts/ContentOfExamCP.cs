using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class ContentOfExamCP : FullEntityBase<Guid>
    {

        public Guid? ExamId { get; set; }
        //
        public string CoeCode { get; set; }
        public int Level { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateStarted { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public int TotalOfQuestions { get; set; }
        public int QuestionType { get; set; }
        public string Content { get; set; }
        public int Status { get; set; }
        //
        public virtual ExamCP ExamCP { get; set; }
        public virtual ICollection<ImageCP> ImageCPs { get; set; }

    }
}
