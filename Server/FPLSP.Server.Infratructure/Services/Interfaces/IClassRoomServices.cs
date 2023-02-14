using FPLSP.Server.Domain.Entities.UserParts;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IClassRoomServices
    {
        Task<List<ClassUp>> GetClassAsync();
    }
}
