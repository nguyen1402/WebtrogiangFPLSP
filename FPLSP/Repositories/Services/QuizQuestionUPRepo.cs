using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Domain.Dtos.QuizQuestionUPDto;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuestionUp;

namespace FPLSP.Repositories.Services
{
    public class QuizQuestionUPRepo : IQuizQuestionUPRepo
    {
        public HttpClient _httpClient;
        public QuizQuestionUPRepo(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<bool> Add(QuizQuestionUpVm quizQuestionUpVm)
        {
            var quizQuestionUp = await _httpClient.PostAsJsonAsync("api/QuizQuestionUps", quizQuestionUpVm);
            if (quizQuestionUp.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Delete(string Id)
        {
            var quizQuestionUp = await _httpClient.DeleteAsync($"api/QuizQuestionUps/{Id}");
            if (quizQuestionUp.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<List<QuizQuestionUpDto>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<QuizQuestionUpDto>>("api/QuizQuestionUps");
        }

        public async Task<QuizQuestionUpVm> GetDetails(string Id)
        {
            return await _httpClient.GetFromJsonAsync<QuizQuestionUpVm>($"api/QuizQuestionUps/{Id}");
        }

        public async Task<bool> Update(string Id, QuizQuestionUpVm quizQuestionUpVm)
        {
            var quizQuestionUp = await _httpClient.PutAsJsonAsync($"api/QuizQuestionUps/{Id}", quizQuestionUpVm);
            if (quizQuestionUp.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
