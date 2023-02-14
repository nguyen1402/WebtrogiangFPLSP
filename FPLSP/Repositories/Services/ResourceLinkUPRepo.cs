using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.ResourceLinkUP;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class ResourceLinkUPRepo : IResourceLinkUPRepo
    {
        public HttpClient _httpClient;

        public ResourceLinkUPRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //Lấy danh sách theo trang
        public async Task<PageList<ResourceLinkUPDto>> GetList(ResourceLinkUPListSearch search)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = search.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(search.Name))
                queryStringParam.Add("name", search.Name);
            if (search.Status != null)
                queryStringParam.Add("status", search.Status.ToString());

            string url = QueryHelpers.AddQueryString("/api/ResourceLinkUPs", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<ResourceLinkUPDto>>(url);

            return result;
        }

        //Tìm kiếm đối tượng dựa vào ID
        public async Task<ResourceLinkUPViewModel> GetById(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<ResourceLinkUPViewModel>($"/api/ResourceLinkUPs/{id}");
            return result;
        }

        //Tạo mới và trả về true nếu thành công
        public async Task<bool> Create(ResourceLinkUPCreateRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/ResourceLinkUPs​/create", request);
            return result.IsSuccessStatusCode;
        }

        //Cập nhật và trả về true nếu thành công
        public async Task<bool> Update(Guid Id, ResourceLinkUPViewModel request)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/ResourceLinkUPs/{Id}", request);
            return result.IsSuccessStatusCode;
        }

        //Xóa và trả về true nếu thành công
        public async Task<bool> Delete(Guid Id)
        {
            var result = await _httpClient.DeleteAsync($"/api/ResourceLinkUPs/{Id}");
            return result.IsSuccessStatusCode;
        }

        //Lấy toàn bộ danh sách
        public async Task<List<ResourceLinkUPViewModel>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<ResourceLinkUPViewModel>>($"/api/ResourceLinkUPs/all/");
            return result;
        }

        public async Task<bool> DeleteList(int method, List<Guid> listIdLink)
        {
            var result = await _httpClient.PostAsJsonAsync($"/api/ResourceLinkUPs/{method}", listIdLink);
            return result.IsSuccessStatusCode;
        }
    }
}
