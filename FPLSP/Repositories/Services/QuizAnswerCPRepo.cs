using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.QuizAnswerCPDtos;
using FPLSP.Server.Infrastructure.ViewModels.QuizAnswerCPVm;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Json;

namespace FPLSP.Repositories.Services
{
    public class QuizAnswerCPRepo : IQuizAnswerCPRepo
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;

        public QuizAnswerCPRepo(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }
        public async Task<int> CreateQuizAnswerCP(CreateQuizAnswerCPVm quizansweer)
        {
            var content = JsonSerializer.Serialize(quizansweer);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            var postResult = await _client.PostAsync("/api/QuizAnswerCPs", bodyContent);

            if (postResult.IsSuccessStatusCode)
                return 1;

            return 0;
        }

        public async Task<int> DeleteQuizAnswerCP(Guid id)
        {
            var url = Path.Combine("/api/QuizAnswerCPs", id.ToString());

            var deleteResult = await _client.DeleteAsync(url);
            if (!deleteResult.IsSuccessStatusCode)
            {
                return 0;
            }
            return 1;
        }

        public async Task<QuizAnswerCPVm> GetQuizAnswerCPbyId(Guid id)
        {
            var url = Path.Combine("/api/QuizAnswerCPs", id.ToString());

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var quiz = JsonSerializer.Deserialize<QuizAnswerCPVm>(content, _options);
            return quiz;
        }

        public async Task<PageList<QuizAnswerCPDtos>> GetQuizAnswerLists(ListSearchQuizAnswerCP quizanswer)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = quizanswer.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(quizanswer.QuestionCode))
            {
                queryStringParam.Add("QuestionCode", quizanswer.QuestionCode);
            }
            if (!string.IsNullOrEmpty(quizanswer.Answer))
            {
                queryStringParam.Add("Answer", quizanswer.Answer);
            }
            string url = QueryHelpers.AddQueryString("/api/QuizAnswerCPs", queryStringParam);

            var result = await _client.GetFromJsonAsync<PageList<QuizAnswerCPDtos>>(url);

            return result;
        }

        public async Task<int> UpdateQuizAnswerCP(Guid id, QuizAnswerCPVm quizanswer)
        {
            var url = Path.Combine("/api/QuizAnswerCPs", quizanswer.Id.ToString());
            var putResult = await _client.PutAsJsonAsync(url, quizanswer);
            if (putResult.IsSuccessStatusCode)
                return 1;

            return 0;
        }
    }
}
