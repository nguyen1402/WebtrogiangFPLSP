using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.KindOfQuestionCPDtos;
using FPLSP.Server.Domain.Dtos.QuizCPDtos;
using FPLSP.Server.Infrastructure.ViewModels.QuizCPVm;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuestionCPVm;
using Microsoft.AspNetCore.Components.Forms;

namespace FPLSP.Repositories.Interfaces
{
    public interface IQuizCPRepo
    {
        Task<int> CreateQuizCP(Guid idsubject, QuizCPVm quiz);
        Task<PageList<SubjectQuizCPDtos>> GetQuizCPList(Guid idsubject, ListQuizSearch quiz);
        Task<int> UpdateQuizCP(Guid idquiz, UpdateQuizCPVm quiz);
        Task<SubjectQuizCPDtos> GetQuizById(Guid id);
        Task<int> DeleteQuizCP(Guid idQuiz);
        Task<bool> RemoveListQuizCP(List<Guid> listIdQuiz);

        Task<List<SubjectQuizCPDtos>> GetAllQuizCPbyIdSubject(Guid idsubject);
        Task<List<ExcelQuizQuestion>> LoadingBigData(IBrowserFile file,Guid idQuiz);
        Task<List<KindOfQuestionCPDtos>> GetAllKoq();
        Task<int> CreateExcelQuizQuestion(List<ExcelQuizQuestion> lstexcelQuizQuestions);
    }
}
