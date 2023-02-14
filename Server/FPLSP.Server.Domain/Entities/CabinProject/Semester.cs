using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CabinProject
{
    public class Semester : EntityBase<Guid>
    {
        public string NameofSemester { get; set; }
        public int IndexOfSemester { get; set; }
        public int Status { get; set; }
        public virtual ICollection<SemesterBlock> SemesterBlocks { get; set; }


    }
}
