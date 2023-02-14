using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuesstionQuizCP;

namespace FPLSP.Repositories.Interfaces
{
    public interface IQuizQuesstionQuizCPClient
    {
        Task<PageList<QuizQuesstionQuizCPDto>> GetPagingParamets(Guid quizId, QuizQuesstionQuizCPListSearch parameters);
        Task<QuizQuesstionQuizCPDto> GetbyId(Guid quizquesstionId);
        Task<List<QuizQuesstionQuizCPDto>> GetAllCauHoi(Guid idsubject);
        Task<int> Create(Guid quizId, QuizQuesstionQuizCPCreateVM create);
        Task<int> Update(Guid QuizQuestionId, QuizQuesstionQuizCPUpdateVM update);
        Task<int> Delete(Guid quizquesstionId);
        Task<int> DeleteListQuizQuestionQuiz(List<Guid> listIdQuizQuestionQuiz);
    }
}
