using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class ImageCP : EntityBase<Guid>
    {
        public Guid CoeId { get; set; }
        public string Path { get; set; }
        public string Descriptions { get; set; }
        public int Status { get; set; }
        public virtual ContentOfExamCP ContentOfExamCP { get; set; }
    }
}
