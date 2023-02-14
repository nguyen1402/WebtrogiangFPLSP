using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.ResourceLink;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class ResourceLinkRepocs : IResourceLinkRepo
    {
        private readonly HttpClient _httpClient;
        public ResourceLinkRepocs(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<int> Create(ResourceLinkCreateVM models_create)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/ResourceLinks", models_create);
            if (result.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<int> Delete(Guid id)
        {
            var url = Path.Combine("/api/ResourceLinks", id.ToString());
            var result = await _httpClient.DeleteAsync(url);
            if (result.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<List<ResourceLinkDto>> GetAllAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<List<ResourceLinkDto>>("/api/Resourcelinks/all");
            return result;
        }

        public async Task<ResourceLinkUpdateVM> GetbyId(Guid id)
        {
            var url = Path.Combine("/api/Resourcelinks", id.ToString());
            var result = await _httpClient.GetFromJsonAsync<ResourceLinkUpdateVM>(url);

            return result;
        }

        public async Task<PageList<ResourceLinkDto>> Gets(ResourceLinkListSearch parameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = parameters.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(parameters.Name))
                queryStringParam.Add("Name", parameters.Name);
            if (!string.IsNullOrEmpty(parameters.Status.ToString()))
                queryStringParam.Add("Status", parameters.Status.ToString()); 
            if (parameters.IdSubject != Guid.Empty)
                queryStringParam.Add("IdSubject", parameters.IdSubject.ToString());

            string url = QueryHelpers.AddQueryString("/api/Resourcelinks", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<ResourceLinkDto>>(url);
            return result;
        }

        public async Task<int> Update(Guid id, ResourceLinkUpdateVM models_update)
        {
            var url = Path.Combine("/api/Resourcelinks", id.ToString());
            var result = await _httpClient.PutAsJsonAsync(url, models_update);
            if (result.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<bool> RemoveListResource(List<Guid> listIdResource)
        {
            var result = await _httpClient.PostAsJsonAsync($"/api/Resourcelinks/deletelist/", listIdResource);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
