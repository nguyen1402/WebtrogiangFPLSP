using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.StudentCPDtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.StudentCP;

namespace FPLSP.Repositories.Interfaces
{
    public interface IStudentCPApiClient
    {
        Task<int> CreateStudent(CreateStudentCPVm student);
        Task<List<StudentCP>> GetAllStudentAsync();
        Task<StudentCP> GetMaxIdStudent();
        Task<StudentCPDtos> GetStudentById(Guid id);
        Task<int> UpdateStudentCP(StudentCPDtos student);
        Task<int> DeleteStudentCP(CreateStudentCPVm subject_delete);
        Task<PageList<StudentCPDtos>> GetStudentList(StudentCPListSearch student);
    }
}
