using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuesstionQuizUP;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IQuizQuesstionQuizUPServices
    {
        Task<PageList<QuizQuesstionQuizUPDto>> GetPagingParamets(Guid quizId, QuizQuesstionQuizUPListSearch parameters);
        Task<List<QuizQuesstionQuizUPDto>> GetAllCauHoi(Guid idsubject);
        Task<QuizQuesstionQuizUPDto> GetbyId(Guid quizquesstionId);
        Task<int> Create(Guid quizId, QuizQuesstionQuizUPCreateVM create);
        Task<int> Update(Guid QuizQuestionId, QuizQuesstionQuizUPUpdateVM update);
        Task<int> Delete(Guid quizquesstionId);
        Task<bool> DeleteListQuestionQuizUP(List<Guid> ListIdQuizQuesstionQuiz);
    }
}
