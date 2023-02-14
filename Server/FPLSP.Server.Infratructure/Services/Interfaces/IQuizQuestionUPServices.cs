using FPLSP.Server.Domain.Dtos.QuizQuestionUPDto;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuestionUp;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IQuizQuestionUPServices
    {
        Task<IQueryable<QuizQuestionUpDto>> GetAll();
        Task<bool> Add(QuizQuestionUpVm quizQuestionUpVm);
        Task<bool> Delete(Guid Id);
        Task<bool> Update(Guid Id, QuizQuestionUpVm quizQuestionUpVm);
        Task<QuizQuestionUP> GetDetails(Guid Id);
    }
}
