using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.EntitiesBase;
using FPLSP.Server.Domain.Entities.UserParts;

namespace FPLSP.Server.Domain.Entities.UsesParts
{
    public class SpecializedUP : FullEntityBase<Guid>
    {
        public string SpecializedCode { get; set; }
        public string SpecializationName { get; set; }
        public int Status { get; set; }
        public int Level { get; set; }
        public string Image { get; set; }
        public Guid? SpecialityId { get; set; }

        public SpecializedUP SpecializedUp { get; set; }


        public virtual ICollection<SpecializedUP> InverseReportsToNavigation { get; set; }
        public virtual ICollection<SpecializedSubjectUP> SpecializedSubjectUPs { get; set; }

        public virtual ICollection<LectuterSpecializedUP> LectuterSpecializedUPs { get; set; }
        public virtual ICollection<GroupCabin> GroupCabins { get; set; }




    }
}
