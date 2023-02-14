using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.EntitiesBase;
using FPLSP.Server.Domain.Entities.UserParts;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPLSP.Server.Domain.Entities.CabinProject
{
    public class TeachingSchedule : EntityBase<Guid>
    {

        public DateTime ImportTime { get; set; }
        public Guid IdAdminImport { get; set; }
        public Guid SubjectId { get; set; }
        public Guid ClassId { get; set; }
        public Guid IdShift { get; set; }

        public DateTime TeachingDay { get; set; }
        public int IndexOfTeachingSchedule { get; set; }
        public int Status { get; set; }
        //
        public Guid IdBlock { get; set; }
        public Guid IdSemester { get; set; }
        public Guid IdTrainingFacility { get; set; }

        public string Note { get; set; }
        public string Remote { get; set; }
        public Guid IdLecturter { get; set; }
        public virtual TrainingFacilitiesCP TrainingFacilitiesCPs { get; set; }
        public virtual SubjectClassUP SubjectClassUP { get; set; }
        public virtual SemesterBlock SemesterBlock { get; set; }
        public virtual LecturersCP LecturersCP { get; set; }
        public virtual Shift Shift { get; set; }
        [NotMapped]
        public bool IsEditing { get; set; }
    }
}
