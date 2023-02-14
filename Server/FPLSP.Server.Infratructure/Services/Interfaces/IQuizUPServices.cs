using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.QuizUp.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.QuizUp;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IQuizUPServices
    {
        Task<bool> Add(QuizUpVm quizUpvm, Guid idsubject);
        Task<bool> Delete(Guid idQuiz);
        Task<List<QuizUpDto>> Get();
        Task<QuizUpEditVm> GetById(Guid Id);
        Task<bool> Update(Guid Id, QuizUpEditVm quizUpvm);
        Task<bool> DeleteAll(List<Guid> listId);
        Task<PageList<QuizUpDto>> GetPageList(ListQuizUpSearch listQuizSearch, Guid idsubject);
    }
}
