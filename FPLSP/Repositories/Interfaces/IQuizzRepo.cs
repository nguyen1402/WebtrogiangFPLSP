using FPLSP.Server.Infrastructure.ViewModels.Quizz;

namespace FPLSP.Repositories.Interfaces
{
    public interface IQuizzRepo
    {
        Task<List<QuizzForStudent>> GetListQuiz(RouterQuizz routerQuizz);


    }
}
