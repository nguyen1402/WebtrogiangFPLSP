namespace FPLSP.Server.Infrastructure.ViewModels.CabinProject
{
    public class TeachingSchedulesViewModel
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
    }
}
