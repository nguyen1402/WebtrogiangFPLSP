using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.EntitiesBase;
using FPLSP.Server.Domain.Entities.FPLExam;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class TrainingFacilitiesCP : EntityBase<Guid>
    {


        public string TrainingFacilitiesCode { get; set; }
        public string TrainingInstitutionName { get; set; }
        public string ImageUrl { get; set; }
        public int TrainingInstitution { get; set; }
        public int Status { get; set; }

        public ICollection<LecturersCP> lecturersCPs { get; set; }
        public ICollection<StudentCP> studentCPs { get; set; }
        public ICollection<UserSignIn> UserSignIns { get; set; }
        public ICollection<FPLSP.Server.Domain.Entities.CabinProject.Cabin> Cabins { get; set; }
        public ICollection<TeachingSchedule> teachingSchedules { get; set; }
        public ICollection<ExaminationRoom> examinationRooms { get; set; }

    }
}
