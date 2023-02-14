using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Domain.Dtos.AnswerUPDtos;
using FPLSP.Server.Infrastructure.ViewModels.AnswerUp;

namespace FPLSP.Repositories.Services
{
    public class AnswerUPRepo : IAnswerUPRepo
    {
        public HttpClient _httpClient;
        public AnswerUPRepo(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<bool> AddAnswer(AnswerUpVm answerUpVm)
        {
            var answer = await _httpClient.PostAsJsonAsync("api/AnswerUps", answerUpVm);
            if (answer.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Delete(string Id)
        {
            var answer = await _httpClient.DeleteAsync($"api/AnswerUps/{Id}");
            if (answer.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<List<AnswerUPDto>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<AnswerUPDto>>("api/AnswerUps");
        }

        public async Task<AnswerUpVm> GetDetails(string Id)
        {
            return await _httpClient.GetFromJsonAsync<AnswerUpVm>($"api/AnswerUps/{Id}");
        }

        public async Task<bool> Update(string Id, AnswerUpVm answerUpVm)
        {
            var answer = await _httpClient.PutAsJsonAsync($"api/AnswerUps/{Id}", answerUpVm);
            if (answer.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
