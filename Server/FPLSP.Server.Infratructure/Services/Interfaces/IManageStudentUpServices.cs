using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Dtos.StudentUPDtos;
using FPLSP.Server.Domain.Entities.UserParts;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IManageStudentUpServices
    {
        Task<StudentUP> AddStudentToClass(CreateStudentInClassDto createStudentInClassDto);

        Task<StudentUP> RemoveStudentFromClass(Guid idStudent);

        Task<List<ManageStudentUpDto>> GetListStudentsInClass(Guid id);
        Task<List<StudentUpDto>> GetDetailStudents(Guid id);
    }
}
