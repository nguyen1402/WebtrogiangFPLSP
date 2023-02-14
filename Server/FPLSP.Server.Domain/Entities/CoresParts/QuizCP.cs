using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class QuizCP : FullEntityBase<Guid>
    {

        public string QuizTitle { get; set; }
        public Guid SubjectId { get; set; }
        public string QuizName { get; set; }
        public string Descriptions { get; set; }

        public int Status { get; set; }
        public int MaxTurn { get; set; }
        //  StartDay : Ngày Bắt đầu
        public DateTimeOffset StartDay { get; set; }
        // EndDay : Ngày kết thúc 
        public DateTimeOffset EndDay { get; set; }
        public virtual SubjectCP SubjectCP { get; set; }
        public virtual ICollection<QuizQuestionQuizCP> QuizQuestionQuizCPs { get; set; }
    }
}
