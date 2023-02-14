namespace FPLSP.Server.Infrastructure.ViewModels
{
    public class TrainingFacilitiesCPViewModel
    {
        public Guid ID { get; set; }
        public string TrainingFacilitiesCode { get; set; }
        public string TrainingInstitutionName { get; set; }
        public string ImageUrl { get; set; }
        public int TrainingInstitution { get; set; }
        public int Status { get; set; }
        public int LecturerAmount { get; set; }
        public bool IsChecked { get; set; } = false;
    }
}
