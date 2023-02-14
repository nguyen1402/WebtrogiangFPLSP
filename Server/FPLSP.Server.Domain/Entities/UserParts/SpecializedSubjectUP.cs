using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.UsesParts;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPLSP.Server.Domain.Entities.UserParts
{

    public class SpecializedSubjectUP
    {
        public Guid? SpecializedId { get; set; }
        public Guid? SubjectId { get; set; }
        [ForeignKey("SpecializedId")]
        public virtual SpecializedUP specializedUP { get; set; }
        [ForeignKey("SubjectId")]
        public virtual SubjectUP SubjectUP { get; set; }
        public int Status { get; set; }

        public virtual ICollection<GroupCabin> GroupCabins { get; set; }
    }
}
