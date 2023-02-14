using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuesstionQuizCP;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IQuizQuesstionQuizCPServices
    {
        Task<PageList<QuizQuesstionQuizCPDto>> GetPagingParamets(Guid quizId, QuizQuesstionQuizCPListSearch parameters);
        Task<List<QuizQuesstionQuizCPDto>> GetAllCauHoi(Guid idsubject);
        Task<QuizQuesstionQuizCPDto> GetbyId(Guid quizquesstionId);
        Task<int> Create(Guid quizId, QuizQuesstionQuizCPCreateVM create);
        Task<int> Update(Guid QuizQuestionId, QuizQuesstionQuizCPUpdateVM update);
        Task<int> Delete(Guid quizquesstionId);
        Task<bool> DeleteListQuestionQuizCP(List<Guid> ListIdQuizQuesstionQuiz);
    }
}
