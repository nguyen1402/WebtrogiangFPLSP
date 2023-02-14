using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;

namespace FPLSP.Repositories.Interfaces.FPLExam
{
    public interface IExaminationRoomRepo
    {

        Task<bool> AddExaminationRoom(ExaminationRoomDetailView examinationRoomViewModel);
        Task<List<ExaminationRoom>> GetAllExamRoom();
        Task<PageList<ExaminationRoomDetailView>> GetExamRoomForPaging(ExaminationRoomSearch examinationRoomSearch);
        Task<bool> DeleteExamRoom(Guid IdExamroom);
        Task<ExaminationRoom> GetExamRoomById(Guid Id);
        Task<bool> UpdateExamRoom(ExaminationRoomDetailView examinationRoomViewModel);
    }
}
