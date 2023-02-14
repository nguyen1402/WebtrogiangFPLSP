using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.LectuterSpecializedCP;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class LectuterSpecializedCPCilents : ILectuterSpecializedCPCilents
    {
        private readonly HttpClient _httpClient;
        public LectuterSpecializedCPCilents(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<int> Create(Guid specializedId, LectuterSpecializedCPCreateVM create)
        {
            var url = Path.Combine("/api/LectuterSpecializedCPs", specializedId.ToString());
            var resual = await _httpClient.PostAsJsonAsync(url, create);
            if (resual.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<int> Delete(Guid specializedId, Guid lecturerid)
        {
            var url = Path.Combine("/api/LectuterSpecializedCPs", specializedId.ToString(), lecturerid.ToString());
            var resual = await _httpClient.DeleteAsync(url);
            if (resual.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<List<LectuterSpecializedCPDto>> GetAllAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<List<LectuterSpecializedCPDto>>($"/api/LectuterSpecializedCPs/getall");
            return result;
        }

        public async Task<LectuterSpecializedCPDto> GetbyId(Guid specializedId, Guid lecturerid)
        {
            var url = Path.Combine("/api/LectuterSpecializedCPs", specializedId.ToString(), lecturerid.ToString());
            var result = await _httpClient.GetFromJsonAsync<LectuterSpecializedCPDto>(url);
            return result;
        }

        public async Task<PageList<LectuterSpecializedCPDto>> Gets(Guid specializedId, LectuterSpecializedCPListSearch parameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = parameters.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(parameters.Name))
                queryStringParam.Add("name", parameters.Name);

            string url = QueryHelpers.AddQueryString("/api/LectuterSpecializedCPs/getall/" + specializedId.ToString(), queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<LectuterSpecializedCPDto>>(url);

            return result;
        }

        public async Task<int> Update(Guid specializedId, Guid lecturerid, LectuterSpecializedCPUpdateVM update)
        {
            var url = Path.Combine("/api/LectuterSpecializedCPs", specializedId.ToString(), lecturerid.ToString());
            var resual = await _httpClient.PutAsJsonAsync(url, update);
            if (resual.IsSuccessStatusCode) return 1;
            return 0;
        }
    }
}
