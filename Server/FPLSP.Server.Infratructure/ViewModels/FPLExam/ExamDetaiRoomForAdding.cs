namespace FPLSP.Server.Infrastructure.ViewModels.FPLExam
{
    public class ExamDetaiRoomForAdding
    {
        public Guid IdExaminationRoom { get; set; }
        public Guid IdSubject { get; set; }
        public Guid IdBlock { get; set; }
        public Guid IdSemester { get; set; }
        //phần dưới là thông tin dạng list
        public List<KeyValueAdding> keyValueAdding { get; set; }
    }
    public class KeyValueAdding
    {
        //làm theo ca sẽ làm khóa chính
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TotalTimeOfExam { get; set; }
        //
        public string SecretKey { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
        public List<string> ListIdStudent { get; set; }
        public Guid IdExamFile { get; set; }
        public List<Guid> ListSupervisorID { get; set; }
    }
}
