using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Dtos.StudentStatisticVM;
using FPLSP.Server.Domain.Dtos.StudentUPDtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.StudentStatistics;
using FPLSP.Server.Infrastructure.ViewModels.StudentsUPVm;
namespace FPLSP.Server.Infrastructure.Services.Interfaces;

public interface IStudentUpServices
{
    Task<IQueryable<StudentUpDto>> GetStudentsAsync();
    Task<int> CreateStudentUP(StudentUPCreateVm student);
    Task<StudentUP> GetStudentUPbyId(Guid id);
    Task<List<StudentUP>> GetAllStudentUPAsync();
    string GetMaxId();
    Task<StudentUP> GetStudentUPMaxId();
    Task<int> UpdateStudentUP(Guid id, StudentUpdateVM student);
    Task<PageList<StudentUP>> GetStudentList(StudentUPListSearchVm student);
    Task<StudentUP> Delete(Guid id);
    Task<List<StudentUP>> DeleteRange(List<Guid> _lstId);

    Task<PageList<StudentStatisticsDtos>> StudentStatisticsDtos(Guid idsubject, Guid idclass, StudentStatisticListSearch studentParameters);

    Task<PageList<StudentStatisticsDtos>> QuizStatisticsDtos(Guid idsubject, Guid idclass, StudentStatisticListSearch studentParameters);
    Task<ListIdStudent> GetListIdStudents(Guid idclass);
    Task<Thongtinlop> Thongtinlop(Guid id, Guid idsubject);
}