namespace FPLSP.Server.Infrastructure.ViewModels.FPLExam
{
    public class OnlineExamViewModel
    {
        public string IdUser { get; set; }
        //
        public string SecretKey { get; set; }
        public Guid IdExaminationRoom { get; set; }
        //
        public bool IsHandlerRequest { get; set; }
        public DateTime JoinTime { get; set; }
        public byte[] ChekinImage { get; set; } = new byte[0];
        public DateTime LeaveTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? Status { get; set; }
        public int? IndexOfStudent { get; set; }
        public string? Note { get; set; }
        public bool IsCompletedExam { get; set; }
        public bool IsViewExamFile { get; set; }
        public int CountTurnJoin { get; set; }



    }
}
