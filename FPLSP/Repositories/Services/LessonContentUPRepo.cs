using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.ViewModels.LessonContentUP;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class LessonContentUPRepo : ILessonContentUPRepo
    {
        public HttpClient _httpClient;

        public LessonContentUPRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //Lấy danh sách theo trang
        public async Task<PageList<LessonContentUPViewModel>> GetList(LessonContentUPListSearch search)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = search.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(search.Name))
                queryStringParam.Add("name", search.Name);
            if (search.Status != null)
                queryStringParam.Add("status", search.Status.ToString());
            if (search.LessonId != null)
                queryStringParam.Add("lessonId", search.LessonId.ToString());
            if (search.ResuorceLinkId != null)
                queryStringParam.Add("resuorceLinkId", search.ResuorceLinkId.ToString());

            string url = QueryHelpers.AddQueryString("/api/LessonContentUPs", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<LessonContentUPViewModel>>(url);

            return result;
        }

        //Tìm kiếm đối tượng dựa vào ID
        public async Task<LessonContentUPViewModel> GetById(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<LessonContentUPViewModel>($"/api/LessonContentUPs/{id}");
            return result;
        }

        //Tạo mới và trả về true nếu thành công
        public async Task<bool> Create(LessonContentUPCreateRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/LessonContentUPs", request);
            return result.IsSuccessStatusCode;
        }

        //Cập nhật và trả về true nếu thành công
        public async Task<bool> Update(Guid Id, LessonContentUPUpdateRequest request)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/LessonContentUPs/{Id}", request);
            return result.IsSuccessStatusCode;
        }

        //Xóa và trả về true nếu thành công
        public async Task<bool> Delete(Guid Id)
        {
            var result = await _httpClient.DeleteAsync($"/api/LessonContentUPs/{Id}");
            return result.IsSuccessStatusCode;
        }

        //Lấy toàn bộ danh sách
        public async Task<List<LessonContentUPViewModel>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<LessonContentUPViewModel>>($"/api/LessonContentUPs/all/");
            return result;
        }

        public async Task<bool> RemoveAll(List<Guid> listIdSubject)
        {
            var result = await _httpClient.PostAsJsonAsync($"/api/LessonContentUPs/deletelist/", listIdSubject);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
