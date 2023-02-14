using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.QuizAnswerCPDtos;
using FPLSP.Server.Infrastructure.ViewModels.QuizAnswerCPVm;

namespace FPLSP.Repositories.Interfaces
{
    public interface IQuizAnswerCPRepo
    {
        Task<int> CreateQuizAnswerCP(CreateQuizAnswerCPVm quizansweer);
        Task<PageList<QuizAnswerCPDtos>> GetQuizAnswerLists(ListSearchQuizAnswerCP quizanswer);
        Task<int> UpdateQuizAnswerCP(Guid id, QuizAnswerCPVm quizanswer);
        Task<QuizAnswerCPVm> GetQuizAnswerCPbyId(Guid id);
        Task<int> DeleteQuizAnswerCP(Guid id);
    }
}
