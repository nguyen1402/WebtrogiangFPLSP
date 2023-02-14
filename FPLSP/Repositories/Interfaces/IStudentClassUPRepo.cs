using FPLSP.Data;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.StudentClassUPDtos;
using FPLSP.Server.Domain.Dtos.StudentUPDtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.StudentClassUPVm;
using FPLSP.Server.Infrastructure.ViewModels.StudentsUPVm;
using Microsoft.AspNetCore.Components.Forms;

namespace FPLSP.Repositories.Interfaces
{
    public interface IStudentClassUPRepo
    {
        Task<int> CreateStudentClassUP(StudentClassUPCreateVm student);
        Task<List<StudentClassUP>> GetAllStudentUPAsync();
        Task<StudentClassUPDtos> GetStudentUPById(Guid id);
        Task<int> UpdateStudentUP(Guid idClass, Guid idStudent, StudentClassUPUpdateVm student);
        Task<int> DeleteStudentUP(string jocode, Guid idStudent);
        Task<PageList<StudentClassUPDtos>> GetStudentUPList(StudentUPListSearchVm student);

        Task<List<StudentUpDto>> LoadingBigData(IBrowserFile file);

        Task<List<ExcelErrors>> GetListErr();
        Task<List<StudentUpDto>> GetListSTTestAre(string getfileName,Guid idTrain);
        Task<int> CreateStudentInClassByJoinCode(Guid idClass, Guid idStudent, string joinCode);
    }
}
