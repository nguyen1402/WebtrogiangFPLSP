using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.LessonUP;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class LessonUPRepo : ILessonUPRepo
    {
        public HttpClient _httpClient;

        public LessonUPRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //Lấy danh sách theo trang
        public async Task<PageList<LessonUPViewModel>> GetList(LessonUPListSearch search)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = search.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(search.Name))
                queryStringParam.Add("name", search.Name);
            if (search.IsCompleted != null)
                queryStringParam.Add("IsCompleted", search.IsCompleted.ToString());
            if (search.Status != null)
                queryStringParam.Add("status", search.Status.ToString());
            if (search.SubjectId != null)
                queryStringParam.Add("SubjectId", search.SubjectId.ToString());

            string url = QueryHelpers.AddQueryString("/api/LessonUPs", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<LessonUPViewModel>>(url);

            return result;
        }

        //Tìm kiếm đối tượng dựa vào ID
        public async Task<LessonUPViewModel> GetById(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<LessonUPViewModel>($"/api/LessonUPs/{id}");
            return result;
        }

        //Tạo mới và trả về true nếu thành công
        public async Task<bool> Create(LessonUPCreateRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/LessonUPs", request);
            return result.IsSuccessStatusCode;
        }

        //Cập nhật và trả về true nếu thành công
        public async Task<bool> Update(Guid Id, LessonUPUpdateRequest request)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/LessonUPs/{Id}", request);
            return result.IsSuccessStatusCode;
        }

        //Xóa và trả về true nếu thành công
        public async Task<bool> Delete(Guid Id)
        {
            var result = await _httpClient.DeleteAsync($"/api/LessonUPs/{Id}");
            return result.IsSuccessStatusCode;
        }

        //Lấy toàn bộ danh sách
        public async Task<List<LessonUPViewModel>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<LessonUPViewModel>>($"/api/LessonUPs/all");
            return result;
        }
        public async Task<List<LessonContentCP>> GetAllLessonContentCP()
        {
            var result = await _httpClient.GetFromJsonAsync<List<LessonContentCP>>($"/api/LessonUPs/allLessonContentCP/");
            return result;
        }
        public async Task<List<LessonCP>> GetAllLessonCP()
        {
            var result = await _httpClient.GetFromJsonAsync<List<LessonCP>>($"/api/LessonUPs/allLessonCP/");
            return result;
        }
        public async Task<List<ResourceLink>> GetAllResourceLinkCP()
        {
            var result = await _httpClient.GetFromJsonAsync<List<ResourceLink>>($"/api/LessonUPs/allResourceLinkCP/");
            return result;
        }

        public async Task<bool> RemoveListLessonUP(List<Guid> listIdSubject)
        {
            var result = await _httpClient.PostAsJsonAsync($"/api/LessonUPs/deletelist/", listIdSubject);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
