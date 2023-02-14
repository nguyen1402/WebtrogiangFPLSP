using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.Quizz;
using System.Net.Http.Json;

namespace FPLSP.Server.Infrastructure.Services.Implements
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
