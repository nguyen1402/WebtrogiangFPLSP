using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CabinProject
{
    public class Cabin : EntityBase<Guid>
    {

        public string CabinName { get; set; }
        public int IndexOfCabin { get; set; }
        public DateTime CreateTime { get; set; }
        public string BuildingName { get; set; }
        public int Status { get; set; }
        //
        public Guid IdTrainingFacility { get; set; }
        public virtual TrainingFacilitiesCP TrainingFacilitiesCPs { get; set; }
        public virtual ICollection<BookingCabin> BookingCabins { get; set; }
        public virtual ICollection<GroupCabin> GroupCabins { get; set; }

    }
}
