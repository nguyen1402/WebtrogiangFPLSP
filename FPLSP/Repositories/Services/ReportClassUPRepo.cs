using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.ReportClassUP;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class ReportClassUPRepo : IReportClassUPRepo
    {
        private readonly HttpClient _httpClient;
        public ReportClassUPRepo(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<bool> CreateReportClassUP(ReportUPViewModel report)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/reportclassups", report);
            return result.IsSuccessStatusCode;
        }

        public async Task<ReportUPViewModel> GetByIdReport(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<ReportUPViewModel>($"/api/reportclassups/{id}");
            return result;
        }

        public async Task<List<ReportUPDto>> GetListReportClassUP()
        {
            var result = await _httpClient.GetFromJsonAsync<List<ReportUPDto>>("/api/reportclassups/all");
            return result;
        }

        public async Task<PageList<ReportUPDto>> GetPagingReportClassUPs(Guid classUPId, ReportClassUpSearch reportClassUpSearch)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = reportClassUpSearch.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(reportClassUpSearch.Lever.ToString()))
                queryStringParam.Add("lever", reportClassUpSearch.Lever.ToString());
            if (!string.IsNullOrEmpty(reportClassUpSearch.Describe))
                queryStringParam.Add("describe", reportClassUpSearch.Describe);
            string url = QueryHelpers.AddQueryString($"/api/reportclassups/getall/{classUPId}", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<ReportUPDto>>(url);

            return result;
        }

        public async Task<bool> RemoveListReportClassUP(List<Guid> listIdReport)
        {
            var result = await _httpClient.PostAsJsonAsync($"/api/reportclassups/deletelist/", listIdReport);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> RemoveReportClassUP(string id)
        {
            var result = await _httpClient.DeleteAsync($"/api/reportclassups/{id}");
            return result.IsSuccessStatusCode;
        }


        public async Task<bool> UpdateReportClassUP(ReportUPViewModel report)
        {
            var result = await _httpClient.PutAsJsonAsync("/api/reportclassups", report);
            return result.IsSuccessStatusCode;
        }
    }
}

