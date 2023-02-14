using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Dtos.StudentStatisticVM;
using FPLSP.Server.Domain.Dtos.StudentUPDtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.StudentStatistics;
using FPLSP.Server.Infrastructure.ViewModels.StudentsUPVm;


namespace FPLSP.Repositories.Interfaces
{
    public interface IStudentUPRepo
    {
        Task<int> CreateStudentUP(StudentUPCreateVm student);
        Task<List<StudentUP>> GetAllStudentUPAsync();
        Task<StudentUP> GetMaxIdStudentUP();
        Task<StudentUpDto> GetStudentUPById(Guid id);
        Task<int> UpdateStudentUP(Guid id, StudentUpdateVM student);
        Task<int> DeleteStudentUP(Guid id);
        public Task<int> RemoveRangeStudentUP(StudentRemovRangeVM id);
        Task<PageList<StudentUpDto>> GetStudentUPList(StudentUPListSearchVm student);
        Task<PageList<StudentStatisticsDtos>> StudentStatisticsDtos(Guid idclass, Guid idsubject, StudentStatisticListSearch studentParameters);
        Task<PageList<StudentStatisticsDtos>> QuizStatisticsDtos(Guid idclass, Guid idsubject, StudentStatisticListSearch studentParameters);
        Task<Thongtinlop> Thongtinlop(Guid id, Guid idsubject);
        Task<ListIdStudent> GetListIdStudents(Guid idclass);
        Task<List<StudentUpDto>> GetAllStudentDtosAsync();

        Task<int> CreateStudentUPstudentInClass(StudentUpDto studentInClassCreate);
    }
}
