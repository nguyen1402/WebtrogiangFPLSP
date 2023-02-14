using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class RoleCP : EntityBase<Guid>
    {
        public string RoleCode { get; set; }
        public int Status { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<LecturersCP> Lecturers { get; set; }
    }
}
