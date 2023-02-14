using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.QuizQuestionCPDtos;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuestionCPVm;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Json;

namespace FPLSP.Repositories.Services
{
    public class QuizQuestionCPRepo : IQuizQuestionCPRepo
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;

        public QuizQuestionCPRepo(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }
        public async Task<int> CreateQuizQuestionCP(CreateQuizQuestionCPVm quizQuestion)
        {
            var content = JsonSerializer.Serialize(quizQuestion);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            var postResult = await _client.PostAsync("/api/QuizQuestionCPs", bodyContent);

            if (postResult.IsSuccessStatusCode)
                return 1;

            return 0;
        }

        public async Task<int> DeleteQuizQuestionCP(Guid id)
        {
            var url = Path.Combine("/api/QuizQuestionCPs", id.ToString());

            var deleteResult = await _client.DeleteAsync(url);
            if (!deleteResult.IsSuccessStatusCode)
            {
                return 0;
            }
            return 1;
        }

        public async Task<QuizQuestionCPVm> GetQuizQuestionCPbyId(Guid id)
        {
            var url = Path.Combine("/api/QuizQuestionCPs", id.ToString());

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var quiz = JsonSerializer.Deserialize<QuizQuestionCPVm>(content, _options);
            return quiz;
        }

        public async Task<PageList<QuizQuestionCPDtos>> GetQuizQuestionList(ListQuizQuestionSearch quizQuestion)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = quizQuestion.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(Convert.ToString(quizQuestion.KindoOfQuestionId)))
            {
                queryStringParam.Add("KindoOfQuestionId", Convert.ToString(quizQuestion.KindoOfQuestionId));
            }
            if (!string.IsNullOrEmpty(Convert.ToString(quizQuestion.QuizQuestionName)))
            {
                queryStringParam.Add("QuizQuestionName", quizQuestion.QuizQuestionName);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(quizQuestion.Status)))
            {
                queryStringParam.Add("Status", Convert.ToString(quizQuestion.Status));
            }
            string url = QueryHelpers.AddQueryString("/api/QuizQuestionCPs", queryStringParam);

            var result = await _client.GetFromJsonAsync<PageList<QuizQuestionCPDtos>>(url);

            return result;
        }

        public async Task<int> UpdateQuizQuestionCP(Guid id, QuizQuestionCPVm quizQuestion)
        {
            var url = Path.Combine("/api/QuizQuestionCPs", quizQuestion.Id.ToString());
            var putResult = await _client.PutAsJsonAsync(url, quizQuestion);
            if (putResult.IsSuccessStatusCode)
                return 1;

            return 0;
        }
    }
}
