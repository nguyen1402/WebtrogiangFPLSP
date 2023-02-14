using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.FPLExam
{
    public class ExamRoomDetailSearch : PagingParameters
    {
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? ExamRoomDetailName { get; set; }
        public Guid? IdBlock { get; set; }
        public Guid? IdSemester { get; set; }
        public Guid? IdSubJect { get; set; }
        public string? SupervisorName { get; set; }


    }
}
