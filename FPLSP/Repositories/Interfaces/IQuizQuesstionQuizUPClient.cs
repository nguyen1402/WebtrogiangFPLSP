using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuesstionQuizUP;

namespace FPLSP.Repositories.Interfaces
{
    public interface IQuizQuesstionQuizUPClient
    {
        Task<PageList<QuizQuesstionQuizUPDto>> GetPagingParamets(Guid quizId, QuizQuesstionQuizUPListSearch parameters);
        Task<QuizQuesstionQuizUPDto> GetbyId(Guid quizquesstionId);
        Task<List<QuizQuesstionQuizUPDto>> GetAllCauHoi(Guid idsubject);
        Task<int> Create(Guid quizId, QuizQuesstionQuizUPCreateVM create);
        Task<int> Update(Guid QuizQuestionId, QuizQuesstionQuizUPUpdateVM update);
        Task<int> Delete(Guid quizquesstionId);
        Task<int> DeleteListQuizQuestionQuiz(List<Guid> listIdQuizQuestionQuiz);
    }
}
