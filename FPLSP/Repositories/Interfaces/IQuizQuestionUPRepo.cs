using FPLSP.Server.Domain.Dtos.QuizQuestionUPDto;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuestionUp;

namespace FPLSP.Repositories.Interfaces
{
    public interface IQuizQuestionUPRepo
    {
        Task<List<QuizQuestionUpDto>> GetAll();
        Task<bool> Add(QuizQuestionUpVm quizQuestionUpVm);
        Task<bool> Delete(string Id);
        Task<QuizQuestionUpVm> GetDetails(string Id);
        Task<bool> Update(string Id, QuizQuestionUpVm quizQuestionUpVm);
    }
}
