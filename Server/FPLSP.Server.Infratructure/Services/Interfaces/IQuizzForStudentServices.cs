using FPLSP.Server.Infrastructure.ViewModels.Quizz;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IQuizzForStudentServices
    {
        Task<List<QuizzForStudent>> GetListQuiz(RouterQuizz routerQuizz);



    }
}
