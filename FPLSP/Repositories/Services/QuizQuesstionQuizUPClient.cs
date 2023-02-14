using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuesstionQuizUP;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class QuizQuesstionQuizUPClient : IQuizQuesstionQuizUPClient
    {
        private readonly HttpClient _httpClient;
        public QuizQuesstionQuizUPClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<int> Create(Guid quizId, QuizQuesstionQuizUPCreateVM create)
        {
            var url = Path.Combine("/api/QuizQuesstionQuizUPs", quizId.ToString());
            var resual = await _httpClient.PostAsJsonAsync(url, create);
            if (resual.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<int> Delete(Guid quizquesstionId)
        {
            var url = Path.Combine("/api/QuizQuesstionQuizUPs", quizquesstionId.ToString());

            var deleteResult = await _httpClient.DeleteAsync(url);
            if (!deleteResult.IsSuccessStatusCode)
            {
                return 0;
            }
            return 1;
        }

        public async Task<int> DeleteListQuizQuestionQuiz(List<Guid> listIdQuizQuestionQuiz)
        {
            var result = await _httpClient.PostAsJsonAsync($"/api/QuizQuesstionQuizUPs/deletelist/", listIdQuizQuestionQuiz);
            if (result.IsSuccessStatusCode)
            {
                return 1;
            }
            return 0;
        }

        public async Task<List<QuizQuesstionQuizUPDto>> GetAllCauHoi(Guid idsubject)
        {
            var url = Path.Combine("/api/QuizQuesstionQuizUPs/getallcauhoi", idsubject.ToString());
            var result = await _httpClient.GetFromJsonAsync<List<QuizQuesstionQuizUPDto>>(url);
            return result;
        }

        public async Task<QuizQuesstionQuizUPDto> GetbyId(Guid quizquesstionId)
        {
            var url = Path.Combine("/api/QuizQuesstionQuizUPs", quizquesstionId.ToString());
            var result = await _httpClient.GetFromJsonAsync<QuizQuesstionQuizUPDto>(url);
            return result;
        }

        public async Task<PageList<QuizQuesstionQuizUPDto>> GetPagingParamets(Guid quizId, QuizQuesstionQuizUPListSearch parameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = parameters.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(parameters.Name))
                queryStringParam.Add("Name", parameters.Name);
            if (!string.IsNullOrEmpty(parameters.Status.ToString()))
                queryStringParam.Add("Status", parameters.Status.ToString());

            string url = QueryHelpers.AddQueryString("/api/QuizQuesstionQuizUPs/getall/" + quizId.ToString(), queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<QuizQuesstionQuizUPDto>>(url);

            return result;
        }

        public async Task<int> Update(Guid QuizQuestionId, QuizQuesstionQuizUPUpdateVM update)
        {
            var url = Path.Combine("/api/QuizQuesstionQuizUPs", QuizQuestionId.ToString());
            var resual = await _httpClient.PutAsJsonAsync(url, update);
            if (resual.IsSuccessStatusCode) return 1;
            return 0;
        }
    }
}
