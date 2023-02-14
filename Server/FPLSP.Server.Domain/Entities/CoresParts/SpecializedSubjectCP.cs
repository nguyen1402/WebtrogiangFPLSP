using System.ComponentModel.DataAnnotations.Schema;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class SpecializedSubjectCP
    {

        public Guid? SpecializedId { get; set; }
        public Guid? SubjectId { get; set; }
        [ForeignKey("SpecializedId")]
        public virtual SpecializedCP specializedCP { get; set; }
        [ForeignKey("SubjectId")]
        public virtual SubjectCP SubjectCP { get; set; }
        public int Status { get; set; }
    }
}
