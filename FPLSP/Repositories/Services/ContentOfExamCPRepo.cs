using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.ContentOfExamsCP;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class ContentOfExamCPRepo : IContentOfExamCPRepo
    {
        public ContentOfExamCPRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public HttpClient _httpClient { get; set; }

        public async Task<bool> CreateCoeCP(CoeCreateVm CreateVm)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/ContentOfExamCPs", CreateVm);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteCoeCP(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"/api/ContentOfExamCPs/{id}");
            return result.IsSuccessStatusCode;
        }


        public async Task<ContentOfExamCP> GetCoeCPById(Guid Id)
        {
            var url = Path.Combine("/api/ContentOfExamCPs", Id.ToString());
            var result = await _httpClient.GetFromJsonAsync<ContentOfExamCP>(url);
            return result;
        }

        public async Task<PageList<ContentOfExamCPDto>> GetCoeCPList(CoeListSearchVm ListSearch)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = ListSearch.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(ListSearch.CoeCode))
            {
                queryStringParam.Add("CoeCode", ListSearch.CoeCode);
            }
            if (!string.IsNullOrEmpty(ListSearch.Content))
            {
                queryStringParam.Add("Content", ListSearch.Content);
            }
            if (ListSearch.Status != null)
            {
                queryStringParam.Add("Status", ListSearch.Status.ToString());
            }
            string url = QueryHelpers.AddQueryString("/api/ContentOfExamCPs", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<ContentOfExamCPDto>>(url);
            return result;
        }

        public async Task<List<ContentOfExamCPDto>> GetCoeCPListAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<ContentOfExamCPDto>>("/api/ContentOfExamCPs/GetAll");
            return result;
        }

        public async Task<PageList<ContentOfExamCPDto>> GetCoeCPListByExamId(Guid Id, CoeListSearchVm ListSearch)
        {
            string Getid = Id.ToString();
            var result = await _httpClient.GetFromJsonAsync<PageList<ContentOfExamCPDto>>($"/api/ContentOfExamCPs/{Getid}");
            return result;
        }

        public async Task<bool> UpdateCoeCP(Guid id, CoeUpdateVm UpdateVm)
        {
            string oker = id.ToString();
            var result = await _httpClient.PutAsJsonAsync($"/api/ContentOfExamCPs/{oker}", UpdateVm);

            return result.IsSuccessStatusCode;
        }


    }
}
