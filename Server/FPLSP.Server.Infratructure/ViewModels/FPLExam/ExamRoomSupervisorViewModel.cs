using System.ComponentModel.DataAnnotations.Schema;

namespace FPLSP.Server.Infrastructure.ViewModels.FPLExam
{
    public class ExamRoomSupervisorViewModel
    {
        public Guid IdLecturter { get; set; }
        public string SecretKey { get; set; }
        public Guid IdExaminationRoom { get; set; }
        //
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Status { get; set; }
        public bool IsMainSupervisor { get; set; }
        public string? Note { get; set; }
        public string SubjectName { get; set; }
        [NotMapped]
        public string CountDown { get; set; }

    }
}
