using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class ExamLinkCP : EntityBase<Guid>
    {

        public Guid? ExamId { get; set; }
        public string ExamLinkCode { get; set; }
        public string Path { get; set; }
        public DateTime CreatedDay { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Status { get; set; }
        public ExamCP examCP { get; set; }
    }
}
