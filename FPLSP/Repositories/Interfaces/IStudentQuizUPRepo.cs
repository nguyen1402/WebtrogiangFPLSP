using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.StudentQuizUPVm;

namespace FPLSP.Repositories.Interfaces
{
    public interface IStudentQuizUPRepo
    {
        Task<StudentQuizUPDtos> GetbyId(Guid studenId, Guid quizId);
        Task<List<StudentQuizUPDtos>> GetAllAsync();
        Task<int> Create(StudentQuizCreateUPVM create);
        Task<int> Update(Guid studenId, Guid quizId, StudentQuizUpdateUPVM update);
        Task<int> Delete(Guid studenId, Guid quizId);
    }
}
