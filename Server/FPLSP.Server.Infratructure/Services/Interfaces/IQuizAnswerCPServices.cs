using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.QuizAnswerCPDtos;
using FPLSP.Server.Infrastructure.ViewModels.QuizAnswerCPVm;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IQuizAnswerCPServices
    {
        Task<int> CreateQuizAnswerCP(CreateQuizAnswerCPVm quizAnswer);
        Task<PageList<QuizAnswerCPDtos>> GetQuizAnswerList(ListSearchQuizAnswerCP quizQuestion);
        Task<int> UpdateQuizAnswerCP(Guid id, QuizAnswerCPVm quizAnswer);
        Task<QuizAnswerCPVm> GetQuizAnswerCPbyId(Guid id);
        Task<int> DeleteQuizAnswerCP(Guid id);
    }
}
