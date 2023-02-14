using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.FPLExam
{
    public class ExaminationRoomSearch : PagingParameters
    {
        public string? ExaminationRoomName { get; set; }
        public Guid? TrainId { get; set; }
    }
}
