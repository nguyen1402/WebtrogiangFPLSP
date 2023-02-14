using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPLSP.Server.Domain.Entities.UserParts
{
    public class LectuterSpecializedUP
    {
        public Guid? LectuterId { get; set; }

        public Guid? SpecializedId { get; set; }
        [ForeignKey("LectuterId")]
        public virtual LecturersCP LecturersCP { get; set; }
        [ForeignKey("SpecializedId")]
        public virtual SpecializedUP SpecializedUP { get; set; }
        public int Status { get; set; }
    }
}
