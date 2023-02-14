using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.QuizQuestionCPDtos;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuestionCPVm;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IQuizQuestionCPServices
    {
        Task<int> CreateQuizQuestionCP(CreateQuizQuestionCPVm quizQuestion);
        Task<PageList<QuizQuestionCPDtos>> GetQuizQuestionList(ListQuizQuestionSearch quizQuestion);
        Task<int> UpdateQuizQuestionCP(Guid id, QuizQuestionCPVm quizQuestion);
        Task<QuizQuestionCPVm> GetQuizQuestionCPbyId(Guid id);
        Task<int> DeleteQuizQuestionCP(Guid id);
    }
}
