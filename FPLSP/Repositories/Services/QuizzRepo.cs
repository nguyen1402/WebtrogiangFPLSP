using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.Quizz;

namespace FPLSP.Repositories.Services
{
    public class QuizzRepo : IQuizzRepo
    {
        private readonly HttpClient _httpClient;
        public QuizzRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<QuizzForStudent>> GetListQuiz(RouterQuizz routerQuizz)
        {
            var res = await _httpClient.GetFromJsonAsync<List<QuizzForStudent>>("/api/Quizzs");
            return res;
        }
    }
}
