using FPLSP.Server.Domain.Entities.CoresParts;

namespace FPLSP.Server.Domain.Entities.FPLExam
{
    public class OnlineExamRoom
    {

        public string IdUser { get; set; }
        //
        public string SecretKey { get; set; }
        public Guid IdExaminationRoom { get; set; }
        //
        public DateTime JoinTime { get; set; }
        public byte[] ChekinImage { get; set; }
        public DateTime LeaveTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? Status { get; set; }
        public int? IndexOfStudent { get; set; }
        public string? Note { get; set; }
        public bool IsCompletedExam { get; set; }
        public bool IsViewExamFile { get; set; }
        public bool IsHandlerRequest { get; set; }
        public int CountTurnJoin { get; set; }
        //
        public virtual UserSignIn UserSignIn { get; set; }
        public virtual ExaminationRoomDetail ExaminationRoomDetail { get; set; }
    }
}
