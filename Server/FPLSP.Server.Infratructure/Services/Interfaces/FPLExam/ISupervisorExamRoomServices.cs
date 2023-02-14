using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;

namespace FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam
{
    public interface ISupervisorExamRoomServices
    {
        Task<List<SupervisorExamRoom>> GetAllSupervisorExamRoom();
        Task<bool> AddingRangeSupervisorExamRoom(List<ExamRoomSupervisorViewModel> supervisorExamRooms);
        Task<bool> AddingSupervisorExamRoom(SupervisorExamRoom supervisorExamRooms);
        Task<bool> UpdatingSupervisorExamRoom(SupervisorExamRoom supervisorExamRooms);
        Task<bool> DeletingSupervisorExamRoom(SupervisorExamRoom supervisorExamRooms);
        Task<SupervisorExamRoom> GetCrurrntTimeForSupervisor(string IdUser);
        Task<List<ExamRoomSupervisorViewModel>> GetSupervisorById(string IdUser);
    }
}
