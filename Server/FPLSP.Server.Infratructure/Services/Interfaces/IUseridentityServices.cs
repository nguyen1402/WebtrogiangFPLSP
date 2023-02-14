using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.ViewModels;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IUseridentityServices
    {
        Task<PageList<UserInListRoles>> GetAllUser(UserRoleSearch userRoleSearch);
        Task<bool> AddRolesToUser(UserUpdateRoles userUpdateRoles);
        Task<UserInListRoles> GetUserRoleById(string Id);
        Task<UserInListRoles> GetRoleUser(string email);
        Task<PageList<UserInListRoles>> GetAllUserNotRole(UserRoleSearch userRoleSearch);
        Task<List<UserInListRoles>> GetAllListUser();
        Task<bool> CheckUserChageIdTrain(string idUser, Guid idTrain);
        Task<bool> DeleteUserNorRole(string idUser);
    }
}
