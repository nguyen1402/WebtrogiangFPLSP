using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;

namespace FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam
{
    public interface IExaminationRoomServices
    {
        Task<bool> AddExaminationRoom(ExaminationRoomDetailView examinationRoomViewModel);
        Task<List<ExaminationRoom>> GetAllExamRoom();
        Task<ExaminationRoom> GetExamRoomById(Guid Id);
        Task<PageList<ExaminationRoomDetailView>> GetExamRoomForPaging(ExaminationRoomSearch examinationRoomSearch);
        Task<bool> DeleteExamRoom(Guid IdExamroom);
        Task<bool> UpdateExamRoom(ExaminationRoomDetailView examinationRoomViewModel);
    }
}
