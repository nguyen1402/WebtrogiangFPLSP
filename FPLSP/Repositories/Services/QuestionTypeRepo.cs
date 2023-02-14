using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.QuestionType;
using FPLSP.Server.Infrastructure.ViewModels.QuestionType;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class QuestionTypeRepo : IQuestionTypeRepo
    {
        HttpClient _httpClient;
        public QuestionTypeRepo(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient)); ;
        }

        public async Task<bool> Add(QuestionTypeVm questionTypeVm)
        {
            var update = await _httpClient.PostAsJsonAsync($"api/QuestionTypes/", questionTypeVm);
            if (update.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<QuestionTypeVm> Get(string Id)
        {
            return await _httpClient.GetFromJsonAsync<QuestionTypeVm>($"api/QuestionTypes/{Id}");
        }

        public async Task<List<QuestionTypeDto>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<QuestionTypeDto>>("api/QuestionTypes");
        }

        public async Task<PageList<QuestionTypeDto>> GetPageList(QuestionTypeSearch questionTypeSearch)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = questionTypeSearch.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(questionTypeSearch.QuestionTypeName))
            {
                queryStringParam.Add("QuestionTypeName", questionTypeSearch.QuestionTypeName);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(questionTypeSearch.QuestionForm)))
            {
                queryStringParam.Add("QuestionForm", Convert.ToString(questionTypeSearch.QuestionForm));
            }
            string url = QueryHelpers.AddQueryString("/api/QuestionTypes/page", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<QuestionTypeDto>>(url);

            return result;
        }

        public async Task<bool> Update(string Id, QuestionTypeVm questionTypeVm)
        {
            var update = await _httpClient.PutAsJsonAsync($"api/QuestionTypes/{Id}", questionTypeVm);
            if (update.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
