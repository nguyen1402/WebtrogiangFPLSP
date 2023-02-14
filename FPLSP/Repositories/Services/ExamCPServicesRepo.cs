using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.Exams;

using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class ExamCPServicesRepo : IExamCPServicesRepo
    {


        private readonly HttpClient _httpClient;
        public ExamCPServicesRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<PageList<ExamCPDto>> GetExamCPList(ExamListSearchVm ExamListSearchVm)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = ExamListSearchVm.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(ExamListSearchVm.ExamCode))
            {
                queryStringParam.Add("ExamCode", ExamListSearchVm.ExamCode);
            }
            if (!string.IsNullOrEmpty(ExamListSearchVm.ExamName))
            {
                queryStringParam.Add("ExamName", ExamListSearchVm.ExamName);
            }
            if (ExamListSearchVm.Status != null)
            {
                queryStringParam.Add("Status", ExamListSearchVm.Status.ToString());
            }
            string url = QueryHelpers.AddQueryString("/api/ExamCPs", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<ExamCPDto>>(url);
            return result;
        }

        public async Task<List<ExamCPDto>> GetAllExamCPListAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<List<ExamCPDto>>($"/api/ExamCPs/GetAll");
            return result;
        }

        public async Task<PageList<ExamCPDto>> GetExamCPListBySubjectId(Guid SubjectId, ExamListSearchVm ExamListSearchVm)
        {
            string Getid = SubjectId.ToString();
            var result = await _httpClient.GetFromJsonAsync<PageList<ExamCPDto>>($"/api/ExamCPs/{Getid}");
            return result;
        }
        public async Task<ExamCP> GetExamCPById(Guid examId)
        {
            var url = Path.Combine("/api/ExamCPs", examId.ToString());
            var result = await _httpClient.GetFromJsonAsync<ExamCP>(url);
            return result;
        }

        public async Task<bool> CreateExamCP(ExamCreateVm ExamCP)
        {
            var result = await _httpClient.PostAsJsonAsync($"/api/ExamCPs", ExamCP);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateExamCP(Guid id, ExamUpdateVm ExamUpdateVm)
        {
            string oker = id.ToString();
            var result = await _httpClient.PutAsJsonAsync($"/api/ExamCPs/{oker}", ExamUpdateVm);
            var aaa = result.IsSuccessStatusCode;
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteExamCP(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"/api/ExamCPs/{id}");
            return result.IsSuccessStatusCode;
        }
    }
}
