using FPLSP.Server.Infrastructure.ViewModels.Quizz;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IQuizzRepo
    {

        Task<List<QuizzForStudent>> GetListQuiz(RouterQuizz routerQuizz);
    }
}
