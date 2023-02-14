using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class StudentCP : FullEntityBase<Guid>
    {

        public string StudentCode { get; set; }
        public string StudentName { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string IdentityCardNumber { get; set; }
        public DateTime IssuedOn { get; set; }
        public string Ethnic { get; set; }
        public string ImageUrl { get; set; }
        //
        public string Description { get; set; }
        public string FathersName { get; set; }
        public string MotherName { get; set; }
        public string HomeTown { get; set; }
        public int Status { get; set; }

        //Các khóa ngoại
        //TrainingFacilities
        public Guid? TrainingFacilitiesId { get; set; }

        public TrainingFacilitiesCP trainingFacilitiesCP { get; set; }


    }
}
