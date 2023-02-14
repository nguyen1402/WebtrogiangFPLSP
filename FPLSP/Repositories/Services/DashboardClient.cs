using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Dtos.DashboardDtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.Specialized;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class DashboardClient : IDashboardClient
    {
        private readonly HttpClient _httpClient;

        public DashboardClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }


        public async Task<List<TrainingFacilitiesForDashBoardDto>> GetInforTraningFacilitiesForDashboard()
        {
            var result = await _httpClient.GetFromJsonAsync<List<TrainingFacilitiesForDashBoardDto>>($"/api/Dashboard/GetDashboard");
            return result;
        }

        public async Task<int> GetAllStudentUPNotUser()
        {
            var ressult = await _httpClient.GetFromJsonAsync<int>($"api/Dashboard/GetAllStudentUPNotUser");
            return ressult;

        }
        public async Task<int> GetAllLectureNotUser(Guid idTran)
        {
            var result = await _httpClient.GetFromJsonAsync<int>($"/api/Dashboard/GetAllLectureNotUser/{idTran}");
            return result;
        }
        public async Task<int> GetAllSpec()
        {
            var result = await _httpClient.GetFromJsonAsync<int>($"/api/Dashboard/GetAllSpec");
            return result;
        }
        public async Task<PageList<SpecializedDto>> GetAllSpecByIdTran(Guid idTran, SpecializedListSearch parameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = parameters.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(parameters.Name))
                queryStringParam.Add("name", parameters.Name);
            string url = QueryHelpers.AddQueryString("/api/Dashboard/GetAllSpecByIdTran/" + idTran.ToString(), queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<SpecializedDto>>(url);

            return result;
        }
    }
}
