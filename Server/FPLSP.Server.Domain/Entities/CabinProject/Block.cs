using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CabinProject
{
    public class Block : EntityBase<Guid>
    {
        public string NameOfBlock { get; set; }
        public int IndexOfBlock { get; set; }
        public int Status { get; set; }
        public virtual ICollection<SemesterBlock> SemesterBlocks { get; set; }


    }
}
