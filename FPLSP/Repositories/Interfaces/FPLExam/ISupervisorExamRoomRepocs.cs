using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;

namespace FPLSP.Repositories.Interfaces.FPLExam
{
    public interface ISupervisorExamRoomRepocs
    {
        Task<List<SupervisorExamRoom>> GetAllSupervisorExamRoom();
        Task<bool> AddingRangeSupervisorExamRoom(List<ExamRoomSupervisorViewModel> supervisorExamRooms);
        Task<bool> AddingSupervisorExamRoom(SupervisorExamRoom supervisorExamRooms);
        Task<bool> UpdatingSupervisorExamRoom(SupervisorExamRoom supervisorExamRooms);
        Task<bool> DeletingSupervisorExamRoom(SupervisorExamRoom supervisorExamRooms);
        Task<List<ExamRoomSupervisorViewModel>> GetSupervisorById(string IdUser);
        Task<SupervisorExamRoom> GetCrurrntTimeForSupervisor(string IdUser);

    }
}
