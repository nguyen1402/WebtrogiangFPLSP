using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class SpecializedCP : FullEntityBase<Guid>
    {

        //bảng đệ quy

        public string SpecializedCode { get; set; }
        public string SpecializationName { get; set; }
        public int Status { get; set; }
        public int Level { get; set; }
        public string Image { get; set; }
        public Guid? IdSpeciality { get; set; }

        //[ForeignKey("IdChuyenNganhHep")]
        //[InverseProperty("InverseReportsToNavigation")]
        public virtual SpecializedCP SpecializedCPs { get; set; }

        //[InverseProperty("ChuyenNganhs")]

        public virtual ICollection<SpecializedCP> InverseReportsToNavigation { get; set; }

        public virtual ICollection<LectuterSpecializedCP> LectuterSpecializedCPs { get; set; }

        public virtual ICollection<SpecializedSubjectCP> SpecializedSubjectCPs { get; set; }
    }
}
