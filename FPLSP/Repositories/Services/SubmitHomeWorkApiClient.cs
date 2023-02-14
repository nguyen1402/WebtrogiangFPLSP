using DocumentFormat.OpenXml.Office2010.Excel;
using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.SubmitHomeWorkVM;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class SubmitHomeWorkApiClient : ISubmitHomeWorkApiClient
    {
        private readonly HttpClient _httpClient;
        public SubmitHomeWorkApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<int> Add(SubmitHomeWorkCreateVM summit)
        {
            var url = Path.Combine("/api/SubmitHomeWorks");
            var result = await _httpClient.PostAsJsonAsync(url, summit);
            if (result.IsSuccessStatusCode) return 1;
            return 0;
        }
        public async Task<int> DeleteSubmit(Guid idClass, Guid idSubject, Guid idStudent)
        {
            var result = await _httpClient.DeleteAsync($"/api/SubmitHomeWorks/{idClass}/{idSubject}/{idStudent}");
            if (result != null)
            {
                return 1;
            }
            return 0;
        }

        public async Task<List<SubmitHomeWorkDtos>> GetALl()
        {
            var url = Path.Combine("/api/SubmitHomeWorks/getall/tatca");
            var result = await _httpClient.GetFromJsonAsync<List<SubmitHomeWorkDtos>>(url);
            return result;
        }

        public async Task<PageList<SubmitHomeWorkDtos>> ThongkeNopbai(ListSubmitHomeWorkSeach parameters, Guid idclass, Guid idlesson)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = parameters.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(parameters.Status))
                queryStringParam.Add("Status", parameters.Status);

            string url = QueryHelpers.AddQueryString($"/api/SubmitHomeWorks/getall/{idclass}/{idlesson}", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<SubmitHomeWorkDtos>>(url);

            return result;
        }
    }
}
