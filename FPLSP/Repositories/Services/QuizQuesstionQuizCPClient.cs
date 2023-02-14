using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuesstionQuizCP;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class QuizQuesstionQuizCPClient : IQuizQuesstionQuizCPClient
    {
        private readonly HttpClient _httpClient;
        public QuizQuesstionQuizCPClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<int> Create(Guid quizId, QuizQuesstionQuizCPCreateVM create)
        {
            create.StatusQuizQuestion = 1;
            create.StatusQuizQuiz = 1;

            var url = Path.Combine("/api/QuizQuesstionQuizCPs", quizId.ToString());
            var resual = await _httpClient.PostAsJsonAsync(url, create);
            if (resual.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<int> Delete(Guid quizquesstionId)
        {
            var url = Path.Combine("/api/QuizQuesstionQuizCPs", quizquesstionId.ToString());

            var deleteResult = await _httpClient.DeleteAsync(url);
            if (!deleteResult.IsSuccessStatusCode)
            {
                return 0;
            }
            return 1;
        }

        public async Task<int> DeleteListQuizQuestionQuiz(List<Guid> listIdQuizQuestionQuiz)
        {
            var result = await _httpClient.PostAsJsonAsync($"/api/QuizQuesstionQuizCPs/deletelist/", listIdQuizQuestionQuiz);
            if (result.IsSuccessStatusCode)
            {
                return 1;
            }
            return 0;
        }

        public async Task<List<QuizQuesstionQuizCPDto>> GetAllCauHoi(Guid idsubject)
        {
            var url = Path.Combine("/api/QuizQuesstionQuizCPs/getallcauhoi", idsubject.ToString());
            var result = await _httpClient.GetFromJsonAsync<List<QuizQuesstionQuizCPDto>>(url);
            return result;
        }

        public async Task<QuizQuesstionQuizCPDto> GetbyId(Guid quizquesstionId)
        {
            var url = Path.Combine("/api/QuizQuesstionQuizCPs", quizquesstionId.ToString());
            var result = await _httpClient.GetFromJsonAsync<QuizQuesstionQuizCPDto>(url);
            return result;
        }

        public async Task<PageList<QuizQuesstionQuizCPDto>> GetPagingParamets(Guid quizId, QuizQuesstionQuizCPListSearch parameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = parameters.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(parameters.Name))
                queryStringParam.Add("Name", parameters.Name);
            if (!string.IsNullOrEmpty(parameters.Status.ToString()))
                queryStringParam.Add("Status", parameters.Status.ToString());

            string url = QueryHelpers.AddQueryString("/api/QuizQuesstionQuizCPs/getall/" + quizId.ToString(), queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<QuizQuesstionQuizCPDto>>(url);

            return result;
        }

        public async Task<int> Update(Guid QuizQuestionId, QuizQuesstionQuizCPUpdateVM update)
        {
            var url = Path.Combine("/api/QuizQuesstionQuizCPs", QuizQuestionId.ToString());
            var resual = await _httpClient.PutAsJsonAsync(url, update);
            if (resual.IsSuccessStatusCode) return 1;
            return 0;
        }
    }
}
