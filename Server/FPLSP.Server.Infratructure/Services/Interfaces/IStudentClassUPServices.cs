using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.StudentClassUPVm;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IStudentClassUPServices
    {
        Task<PageList<StudentClassUP>> GetStudentClassUPList(StudentClassUPSearch SearchVm);
        Task<PageList<StudentClassUP>> GetStudentClassUPListByClassId(Guid Id, StudentClassUPSearch SearchVm);
        Task<StudentClassUP> CreateStudentClassUP(StudentClassUP StudentClassUP);
        Task<StudentClassUP> UpdateStudentClassUP(Guid idClass, Guid idStudent, StudentClassUPUpdateVm StudentClassUPUpdateVm);
        Task<StudentClassUP> DeleteStudentClassUP(string jocode, Guid idStudent);

        Task<StudentClassUP> GetStudentClassUPById(Guid id);
        Task<List<StudentClassUP>> GetAllStudentUPAsync();

        Task<StudentUP> CreateStudentbyEmail(StudentUP StudentUP);
    }
}
