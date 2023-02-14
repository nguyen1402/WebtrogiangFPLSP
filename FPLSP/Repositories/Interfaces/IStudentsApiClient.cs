using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Dtos.StudentUPDtos;

namespace FPLSP.Data.StudentsApiClient
{
    public interface IStudentsApiClient
    {
        Task<List<StudentUpDto>> GetStudentUpDto();
        Task<bool> CreateStudentInClass(CreateStudentInClassDto createStudentInClassDto);
    }
}
