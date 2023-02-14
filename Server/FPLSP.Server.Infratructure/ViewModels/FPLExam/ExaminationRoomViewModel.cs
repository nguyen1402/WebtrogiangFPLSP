namespace FPLSP.Server.Infrastructure.ViewModels.FPLExam
{
    public class ExaminationRoomDetailView
    {
        public Guid Id { get; set; }
        public string ExaminationRoomName { get; set; }
        public DateTime CreateTime { get; set; }
        public int IndexOfExaminationRoom { get; set; }
        public int Status { get; set; }
        //khóa ngoại
        public Guid IdTrainingFacility { get; set; }
        //
        public string TrainingFacilityName { get; set; }
    }
}
