using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.ExamLinks;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class ExamLinkCPRepo : IExamLinkCPRepo
    {
        public ExamLinkCPRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public HttpClient _httpClient { get; set; }
        public async Task<bool> CreateExamLinkCP(ExamLinkCreateVm examLinkCreateVm)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/ExamLinkCPs", examLinkCreateVm);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteExamLinkCP(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"/api/ExamLinkCPs/{id}");
            return result.IsSuccessStatusCode;
        }

        public async Task<ExamLinkCP> GetExamLinkCPById(Guid Id)
        {
            var url = Path.Combine("/api/ExamLinkCPs", Id.ToString());
            var result = await _httpClient.GetFromJsonAsync<ExamLinkCP>(url);
            return result;
        }
        public async Task<List<ExamLinkCP>> GetExamLinkCP()
        {

            var result = await _httpClient.GetFromJsonAsync<List<ExamLinkCP>>("/api/ExamLinkCPs/GetAll");
            return result;
        }

        public async Task<PageList<ExamLinkDto>> GetExamLinkCPList(ExamLinkListSearchVm examLinkListSearch)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = examLinkListSearch.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(examLinkListSearch.ExamLinkCode))
            {
                queryStringParam.Add("ExamLinkCode", examLinkListSearch.ExamLinkCode);
            }
            if (!string.IsNullOrEmpty(examLinkListSearch.Path))
            {
                queryStringParam.Add("Path", examLinkListSearch.Path);
            }
            if (examLinkListSearch.CreatedDay != null)
            {
                queryStringParam.Add("CreatedDay", examLinkListSearch.CreatedDay.ToString());
            }
            if (examLinkListSearch.Status != null)
            {
                queryStringParam.Add("Status", examLinkListSearch.Status.ToString());
            }
            string url = QueryHelpers.AddQueryString("/api/ExamLinkCPs", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<ExamLinkDto>>(url);
            return result;
        }

        public async Task<PageList<ExamLinkDto>> GetExamLinkCPListByExamId(Guid Id, ExamLinkListSearchVm examLinkListSearch)
        {
            string Getid = Id.ToString();
            var result = await _httpClient.GetFromJsonAsync<PageList<ExamLinkDto>>($"/api/ExamLinkCPs/{Getid}");
            return result;
        }


        public async Task<bool> UpdateExamLinkCP(Guid id, ExamLinkUpdateVm examLinkUpdateVm)
        {
            string oker = id.ToString();
            var result = await _httpClient.PutAsJsonAsync($"/api/ExamLinkCPs/{oker}", examLinkUpdateVm);

            return result.IsSuccessStatusCode;
        }
    }
}
