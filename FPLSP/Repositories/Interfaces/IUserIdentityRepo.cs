using FPLSP.Data;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.ViewModels;

namespace FPLSP.Repositories.Interfaces
{
    public interface IUserIdentityRepo
    {

        Task<PageList<UserInListRoles>> GetAllUser(UserRoleSearch userRoleSearch);
        Task<bool> AddRolesToUser(UserUpdateRolesHasClaims userUpdateRoles);
        Task<UserInListRoles> GetUserRoleById(string Id);
        Task<UserInListRoles> GetRoleUser(string email);
        Task<List<UserInListRoles>> GetAllListUser();
        Task<bool> CheckUserChageIdTrain(string idUser, Guid idTrain);
        Task<bool> DeleteUserNorRole(string idUser);
    }
}
