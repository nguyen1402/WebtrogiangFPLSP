using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.QuizUp.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.QuizUp;

namespace FPLSP.Repositories.Interfaces
{
    public interface IQuizUPRepo
    {
        Task<List<QuizUpDto>> GetListQuizUp();
        Task<QuizUpEditVm> GetQuizUp(string id);
        Task<bool> Update(string id, QuizUpEditVm quizUpvm);
        Task<bool> Delete(string id);
        Task<bool> Add(QuizUpVm quizUpvm, string idsubject);
        Task<bool> DeleteAll(List<Guid> listId);
        Task<PageList<QuizUpDto>> GetPageList(ListQuizUpSearch quiz, string idsubject);
    }
}
