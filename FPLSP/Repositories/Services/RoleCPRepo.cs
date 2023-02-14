using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.RoleCPVm;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Json;

namespace FPLSP.Repositories.Services
{
    public class RoleCPRepo : IRoleCPRepo
    {
        public HttpClient _httpClient { get; set; }
        private readonly JsonSerializerOptions _options;

        public RoleCPRepo()
        {
            _httpClient = new HttpClient();
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<bool> CreateRole(RoleCPRequest roleCPViewModel)
        {
            var content = JsonSerializer.Serialize(roleCPViewModel);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            var postResult = await _httpClient.PostAsync("/api/RoleCPs", bodyContent);

            if (postResult.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<bool> DeleteRole(Guid Id)
        {
            var url = Path.Combine("/api/RoleCPs/", Id.ToString());

            var deleteResult = await _httpClient.DeleteAsync(url);
            if (deleteResult.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<List<RoleCP>> GetAllRoleAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<List<RoleCP>>("/api/RoleCPs/all");
            return result;
        }

        public async Task<PageList<RoleCPViewModel>> GetRoleListAsync(RoleCPListSearch search)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = search.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(search.Name))
                queryStringParam.Add("name", search.Name);
            if (search.Status != null)
                queryStringParam.Add("status", search.Status.ToString());

            string url = QueryHelpers.AddQueryString("/api/RoleCPs", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<RoleCPViewModel>>(url);

            return result;
        }

        public async Task<RoleCPViewModel> GetRoleListById(Guid Id)
        {
            var response = await _httpClient.GetAsync($"/api/RoleCPs/{Id}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var role = JsonSerializer.Deserialize<RoleCPViewModel>(content, _options);
            return role;
        }

        public async Task<IQueryable<RoleCPViewModel>> GetRoleMapper()
        {
            var url = Path.Combine("/api/RoleCPs/all");

            var response = await _httpClient.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var result = JsonSerializer.Deserialize<IQueryable<RoleCPViewModel>>(content, _options);

            return result;
        }

        public async Task<bool> UpdateRole(Guid Id, RoleCPRequest roleCPViewModel)
        {
            var putResult = await _httpClient.PutAsJsonAsync($"/api/RoleCPs/{Id}", roleCPViewModel);
            if (putResult.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<RoleCP> GetMaxCodeRole()
        {
            var maxCodeRole = await _httpClient.GetFromJsonAsync<RoleCP>("/api/RoleCPs/maxCode");
            return maxCodeRole;
        }

        public async Task<bool> RemoveListRole(List<Guid> listIdRole)
        {
            var result = await _httpClient.PostAsJsonAsync($"/api/RoleCPs/deletelist/", listIdRole);
            return result.IsSuccessStatusCode;
        }
    }
}