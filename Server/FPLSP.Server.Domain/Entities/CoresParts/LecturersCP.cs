using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.EntitiesBase;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Domain.Entities.UserParts;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class LecturersCP : FullEntityBase<Guid>
    {


        public string LecturersCode { get; set; }
        public string LecturersName { get; set; }
        public bool Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PassWord { get; set; }
        public string Address { get; set; }
        public string IdentityCard { get; set; }
        public DateTime IssuedOn { get; set; }
        public string Ethnic { get; set; }
        public string ImageUrl { get; set; }
        //
        public int YearsOfExperience { get; set; }

        public string HomeTown { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        //chức vụ
        public Guid? RoleId { get; set; }

        public RoleCP RoleCPs { get; set; }
        //chuyên Ngành

        //cơ sở đào tạo
        public Guid? TrainingFacilitiesId { get; set; }

        public TrainingFacilitiesCP trainingFacilitiesCP { get; set; }
        //
        public virtual ICollection<LectuterSpecializedCP> LectuterSpecializedCPs { get; set; }
        public virtual ICollection<LectuterSpecializedUP> LectuterSpecializedUPs { get; set; }
        public virtual ICollection<TeachingSchedule> TeachingSchedules { get; set; }
        public virtual ICollection<SupervisorExamRoom> SupervisorExamRooms { get; set; }
        public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; }


    }
}
