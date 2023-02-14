using FPLSP.Server.Domain.Dtos;

namespace FPLSP.Data.ManageStudents
{
    public interface IManageStudentApiClient
    {
        Task<List<ManageStudentUpDto>> GetStudentUpDto(Guid id);


    }
}
