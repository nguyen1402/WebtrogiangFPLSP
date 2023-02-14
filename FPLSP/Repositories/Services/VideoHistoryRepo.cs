using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.VideoHistoryVm;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class VideoHistoryRepo : IVideoHistoryRepo
    {
        public HttpClient _httpClient;

        public VideoHistoryRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //Tìm kiếm đối tượng dựa vào ID
        public async Task<VideoHistoryViewModel> GetById(string IdStudent, string IdLessonContent)
        {
            var result = await _httpClient.GetFromJsonAsync<VideoHistoryViewModel>($"/api/VideoHistories/{IdStudent}/{IdLessonContent}");

            return result;
        }

        //Tạo mới và trả về true nếu thành công
        public async Task<bool> Create(VideoHistoryCreateRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/VideoHistories", request);
            return result.IsSuccessStatusCode;
        }

        //Cập nhật và trả về true nếu thành công
        public async Task<bool> Update(Guid IdStudent, Guid IdLessonContent, VideoHistoryUpdateRequest request)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/VideoHistories/{IdStudent}/{IdLessonContent}", request);
            return result.IsSuccessStatusCode;
        }

        //Xóa và trả về true nếu thành công
        public async Task<bool> Delete(Guid IdStudent, Guid IdLessonContent)
        {
            var result = await _httpClient.DeleteAsync($"/api/VideoHistories/{IdStudent}/{IdLessonContent}");
            return result.IsSuccessStatusCode;
        }

        //Lấy toàn bộ danh sách
        public async Task<List<VideoHistoryViewModel>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<VideoHistoryViewModel>>($"/api/VideoHistories/all/");
            return result;
        }

        public async Task<PageList<VideoHistoryDto>> GetListLink(Guid IdStudent, Guid IdLesson, VideoHistoryListSearch search)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = search.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(search.LessonContentName))
                queryStringParam.Add("LessonContentName", search.LessonContentName);

            string url = QueryHelpers.AddQueryString($"/api/VideoHistories/VideoHistoryDto/{IdStudent}/{IdLesson}", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<VideoHistoryDto>>(url);
            return result;
        }

        public async Task<bool> UpdateListVideo(List<VideoHistoryDto> listvideo)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/VideoHistories/uploatList/", listvideo);
            return result.IsSuccessStatusCode;
        }
    }
}
