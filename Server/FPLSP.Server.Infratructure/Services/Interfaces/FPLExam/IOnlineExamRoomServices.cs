using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;

namespace FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam
{
    public interface IOnlineExamRoomServices
    {
        Task<List<OnlineExamRoom>> GetAllOnlineExamRoom();
        Task<bool> AddRangeOnlineExamRoom(List<OnlineExamRoom> onlineExamRoom);
        Task<bool> AddOnlineExamRoom(OnlineExamViewModel onlineExamRoom);
        Task<bool> DeleteOnlineExamRoom(string ScreateKey, string IdUser);
        Task<bool> UpdateOnlineExamRoom(OnlineExamViewModel onlineExamRoom);
        Task<List<OnlineExamHasImageViewModel>> GetOnlineExamRoomById(string Secret);
        Task<bool> FastUpdateTurn(string ScreateKey, string IdUser);
        Task<int> getTurnById(string ScreateKey, string IdUser);
        Task<OnlineExamRoom> getScretKeyLastestForUser(string IdUser);
        Task<bool> FastChangingStatus(string ScreateKey, string IdUser);
        Task<int> FastGettingStatus(string ScreateKey, string IdUser);
        //
        Task<List<OnlineExamHasImageViewModel>> HandlerRequestComeIn(string Secret);
        Task<bool> FastUpdateHanlerWhenOut(string ScreateKey, string IdUser);
        Task<bool> FastUpdateHanlerOneTime(string ScreateKey, string IdUser);
        Task<List<StudentGoToExamViewModel>> GetAllOfExamByIdStudent(string idStudent);
        Task<bool> ReOpenExamFileForUser(string ScreateKey, string IdUser);
    }
}
