using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.Lesson;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class LessonCPRepo : ILessonCPRepo
    {
        private readonly HttpClient _httpClient;
        public LessonCPRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<int> Create(Guid Id, LessonCreateVM lesson)
        {
            var url = Path.Combine("/api/LessonCPs", Id.ToString());
            var resual = await _httpClient.PostAsJsonAsync(url, lesson);
            if (resual.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<int> Delete(Guid id)
        {
            var url = Path.Combine("/api/LessonCPs", id.ToString());
            var resual = await _httpClient.DeleteAsync(url);
            if (resual.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<LessonDto> GetbyId(Guid id)
        {
            var url = Path.Combine("/api/LessonCPs", id.ToString());
            var result = await _httpClient.GetFromJsonAsync<LessonDto>(url);
            return result;
        }

        public async Task<PageList<LessonDto>> GetLessons(Guid Id, LessonListSearch parameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = parameters.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(parameters.Name))
                queryStringParam.Add("Name", parameters.Name);
            if (!string.IsNullOrEmpty(parameters.Status.ToString()))
                queryStringParam.Add("Status", parameters.Status.ToString());

            string url = QueryHelpers.AddQueryString("/api/LessonCPs/getall/" + Id.ToString(), queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<LessonDto>>(url);

            return result;
        }

        public async Task<int> Update(Guid id, LessonUpdateVM lesson_update)
        {
            var url = Path.Combine("/api/LessonCPs", id.ToString());
            var resual = await _httpClient.PutAsJsonAsync(url, lesson_update);
            if (resual.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<bool> RemoveListLessonCP(List<Guid> listIdSubject)
        {
            var result = await _httpClient.PostAsJsonAsync($"/api/LessonCPs/deletelist/", listIdSubject);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<List<LessonDto>> GetAll(Guid id)
        {
            var result = await _httpClient.GetFromJsonAsync<List<LessonDto>>($"/api/LessonCPs/alllessonbyid/{id}");
            return result;
        }
        public async Task<List<LessonDto>> GetAllLesson()
        {
            var result = await _httpClient.GetFromJsonAsync<List<LessonDto>>($"/api/LessonCPs/GetAllLesson");
            return result;
        }
    }
}
