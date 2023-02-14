using FPLSP.Server.Domain.Dtos;

namespace FPLSP.Data.ClassRoomsApiClient
{
    public interface IClassRoomApiClient
    {

        Task<List<ClassRoomDto>> GetClassUpDto();
    }
}
