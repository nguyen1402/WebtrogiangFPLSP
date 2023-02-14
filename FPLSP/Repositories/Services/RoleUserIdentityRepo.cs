using FPLSP.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace FPLSP.Repositories.Services
{
    public class RoleUserIdentityRepo : IRoleUserIdentityRepo
    {
        private readonly HttpClient _httpClient;
        public RoleUserIdentityRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> AddRole(IdentityRole identityRole)
        {
            var results = await _httpClient.PostAsJsonAsync("/api/RoleIdentitys/add-role", identityRole);
            return results.IsSuccessStatusCode;
        }

        public async Task<List<IdentityRole>> GetAllRolesAsync()
        {

            var results = await _httpClient.GetFromJsonAsync<List<IdentityRole>>("/api/RoleIdentitys");
            return results;
        }

        public async Task<IdentityRole> GetRoleById(string Id)
        {

            var results = await _httpClient.GetFromJsonAsync<IdentityRole>($"/api/RoleIdentitys/{Id}");
            return results;
        }

        public async Task<bool> RemoveRoles(string Id)
        {
            var results = await _httpClient.DeleteAsync($"/api/RoleIdentitys/{Id}");
            return results.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateRoles(IdentityRole identityRole)
        {
            var results = await _httpClient.PutAsJsonAsync("/api/RoleIdentitys", identityRole);
            return results.IsSuccessStatusCode;
        }
    }
}
