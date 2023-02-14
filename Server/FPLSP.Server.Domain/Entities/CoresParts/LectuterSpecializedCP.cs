using System.ComponentModel.DataAnnotations.Schema;

namespace FPLSP.Server.Domain.Entities.CoresParts
{

    public class LectuterSpecializedCP
    {
        public Guid? LectuterId { get; set; }

        public Guid? SpecializedId { get; set; }
        [ForeignKey("LectuterId")]
        public virtual LecturersCP LecturersCP { get; set; }
        [ForeignKey("SpecializedId")]
        public virtual SpecializedCP SpecializedCP { get; set; }
        public int Status { get; set; }
    }
}
