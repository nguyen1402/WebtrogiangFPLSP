using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.KindOfQuestionCPDtos;
using FPLSP.Server.Infrastructure.ViewModels.KìnOfQuestionCPVm;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Json;

namespace FPLSP.Repositories.Services
{
    public class KindoOfQuestionCPRepo : IKindoOfQuestionCPRepo
    {
        //
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;

        public KindoOfQuestionCPRepo(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }
        public async Task<int> CreateKOQCP(KindOfQuestionCPVm koq)
        {
            var content = JsonSerializer.Serialize(koq);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            var postResult = await _client.PostAsync("/api/KindoOfQuestionCPs", bodyContent);

            if (postResult.IsSuccessStatusCode)
                return 1;

            return 0;
        }

        public async Task<int> DeleteKOQCP(Guid id)
        {
            var url = Path.Combine("/api/KindoOfQuestionCPs", id.ToString());

            var deleteResult = await _client.DeleteAsync(url);
            if (!deleteResult.IsSuccessStatusCode)
            {
                return 0;
            }
            return 1;
        }

        public async Task<KindOfQuestionCPVm> GetKOQCPbyId(Guid id)
        {
            var url = Path.Combine("/api/KindoOfQuestionCPs", id.ToString());

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var quiz = JsonSerializer.Deserialize<KindOfQuestionCPVm>(content, _options);
            return quiz;
        }

        public async Task<PageList<KindOfQuestionCPDtos>> GetKOQList(ListKOQCPSearch koq)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = koq.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(koq.QuestionTypeName))
            {
                queryStringParam.Add("QuestionTypeName", koq.QuestionTypeName);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(koq.QuestionForm)))
            {
                queryStringParam.Add("QuestionForm", Convert.ToString(koq.QuestionForm));
            }
            string url = QueryHelpers.AddQueryString("/api/KindoOfQuestionCPs", queryStringParam);

            var result = await _client.GetFromJsonAsync<PageList<KindOfQuestionCPDtos>>(url);

            return result;
        }

        public async Task<int> UpdateKOQCP(KindOfQuestionCPVm koq)
        {
            var url = Path.Combine("/api/KindoOfQuestionCPs", koq.Id.ToString());
            var putResult = await _client.PutAsJsonAsync(url, koq);
            if (putResult.IsSuccessStatusCode)
                return 1;

            return 0;
        }
    }
}
