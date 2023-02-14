using FPLSP.Server.Domain.Entities.UsesParts;

namespace FPLSP.Server.Domain.Entities.CabinProject
{
    public class GroupCabin
    {
        public Guid IdSpec { get; set; }
        public Guid IdCabin { get; set; }
        public string GroupCabinName { get; set; }
        public DateTime DateOfGrouping { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int IndexOfGroupCabin { get; set; }
        public int Status { get; set; }
        //
        public virtual SpecializedUP SpecializedUP { get; set; }
        public virtual Cabin Cabin { get; set; }

    }
}
