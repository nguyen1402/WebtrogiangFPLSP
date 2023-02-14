using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.QuizUp.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.QuizUp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class QuizUPRepo : IQuizUPRepo
    {
        public HttpClient _httpClient;
        public QuizUPRepo(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient)); ;
        }

        public async Task<bool> Update(string id, QuizUpEditVm quizUpvm)
        {

            var result = await _httpClient.PutAsJsonAsync($"/api/QuizUps/{id}", quizUpvm);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        [HttpGet]
        public async Task<List<QuizUpDto>> GetListQuizUp()
        {
            var result = await _httpClient.GetFromJsonAsync<List<QuizUpDto>>("/api/QuizUps/QuizUp");
            return result;
        }
        [HttpGet]
        public async Task<QuizUpEditVm> GetQuizUp(string id)
        {

            var result = await _httpClient.GetFromJsonAsync<QuizUpEditVm>($"/api/QuizUps/{id}");
            return result;
        }

        public async Task<bool> Delete(string id)
        {
            var result = await _httpClient.DeleteAsync($"/api/QuizUps/{id}");
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        [HttpPost]
        public async Task<bool> Add(QuizUpVm quizUpvm, string idsubject)
        {
            var result = await _httpClient.PostAsJsonAsync($"/api/QuizUps/AddQuizUp/{idsubject}", quizUpvm);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteAll(List<Guid> listId)
        {
            var result = await _httpClient.PostAsJsonAsync($"/api/QuizUps/deleteAll", listId);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<PageList<QuizUpDto>> GetPageList(ListQuizUpSearch quiz, string idsubject)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = quiz.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(Convert.ToString(quiz.Status)))
            {
                queryStringParam.Add("Status", Convert.ToString(quiz.Status));
            }
            if (!string.IsNullOrEmpty(Convert.ToString(quiz.Search)))
            {
                queryStringParam.Add("Search", Convert.ToString(quiz.Search));
            }
            string url = QueryHelpers.AddQueryString($"/api/QuizUps/page/{idsubject}", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<QuizUpDto>>(url);

            return result;
        }
    }
}

