using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.StudentCP;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IStudentCPServices
    {
        Task<IQueryable<StudentDto>> GetStudentsAsync();
        Task<int> CreateStudentCP(CreateStudentCPVm student);
        Task<StudentCP> GetStudentCPbyId(Guid id);
        Task<IQueryable<StudentCP>> GetAllStudentCPAsync();
        string GetMaxId();
        Task<StudentCP> GetStudentCPMaxId();
        Task<int> UpdateStudentCP(Guid id, UpdateStudentCPVm student);
        Task<PageList<StudentCP>> GetStudentList(StudentCPListSearch student);
    }
}
