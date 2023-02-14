using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.QuizCPDtos;
using FPLSP.Server.Infrastructure.ViewModels.QuizCPVm;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IQuizCPServices
    {
        Task<int> CreateQuizCP(Guid idsubject, QuizCPVm quiz);
        Task<PageList<SubjectQuizCPDtos>> GetQuizList(Guid idsubject, ListQuizSearch quiz);
        Task<int> UpdateQuizCP(Guid id, UpdateQuizCPVm quiz);
        Task<SubjectQuizCPDtos> GetQuizCPbyId(Guid id);
        Task<int> DeleteQuizCP(Guid id);
        Task<List<SubjectQuizCPDtos>> GetAllQuizCPbyIdSubject(Guid idsubject);
        Task<bool> RemoveListQuizCP(List<Guid> listIdQuiz);
        Task<int> CreateExcelQuizQuestion(List<ExcelQuizQuestion> lstexcelQuizQuestions);

    }
}
