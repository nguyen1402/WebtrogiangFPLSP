using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.HomeWork;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class HomeWorkClient : IHomeWorkClient
    {
        private readonly HttpClient _httpClient;
        public HomeWorkClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<int> CreateCP(HomeWorkCreatVM creat)
        {
            var url = Path.Combine("/api/HomeWorks");
            var result = await _httpClient.PostAsJsonAsync(url, creat);
            if (result.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<int> DeleteCP(Guid id)
        {
            var url = Path.Combine($"/api/HomeWorks/{id}");
            var result = await _httpClient.DeleteAsync(url);
            if (result.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<HomeWork> Getbyid(Guid id)
        {
            var url = Path.Combine($"/api/HomeWorks/getby/{id}");
            var result = await _httpClient.GetFromJsonAsync<HomeWork>(url);
            return result;
        }

        public async Task<PageList<HomeWork>> GetCPList(Guid idclass, Guid idsubject, Guid idlesson, HomeWorkSeachList parameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = parameters.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(parameters.Name))
                queryStringParam.Add("name", parameters.Name);
            string url = QueryHelpers.AddQueryString($"/api/HomeWorks/all/{idclass}/{idsubject}/{idlesson}", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<HomeWork>>(url);

            return result;
        }

        public async Task<int> UpdateCP(Guid id, HomeWorkUpdateVM update)
        {
            var url = Path.Combine($"/api/HomeWorks/{id}");
            var result = await _httpClient.PutAsJsonAsync(url, update);
            if (result.IsSuccessStatusCode) return 1;
            return 0;
        }
    }
}
