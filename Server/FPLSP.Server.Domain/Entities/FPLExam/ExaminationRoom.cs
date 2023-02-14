using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.FPLExam
{
    public class ExaminationRoom : EntityBase<Guid>
    {

        public string ExaminationRoomName { get; set; }
        public DateTime CreateTime { get; set; }
        public int IndexOfExaminationRoom { get; set; }
        public int Status { get; set; }
        //khóa ngoại
        public Guid IdTrainingFacility { get; set; }

        public virtual TrainingFacilitiesCP TrainingFacilitiesCPs { get; set; }
        //
        public virtual ICollection<ExaminationRoomDetail> ExaminationRoomDetails { get; set; }
    }
}
