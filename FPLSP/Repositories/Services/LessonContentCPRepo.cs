using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.LessonContentCP;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class LessonContentCPRepo : ILessonContentCPRepo
    {
        private readonly HttpClient _httpClient;
        public LessonContentCPRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<int> Create(Guid Id, LessonContentCreateVM creat)
        {
            var url = Path.Combine("/api/LessonContentCPs", Id.ToString());
            var resual = await _httpClient.PostAsJsonAsync(url, creat);
            if (resual.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<int> Delete(Guid id)
        {
            var url = Path.Combine("/api/LessonContentCPs", id.ToString());
            var resual = await _httpClient.DeleteAsync(url);
            if (resual.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<List<LessonContentDto>> GetAll(Guid? id)
        {
            var result = await _httpClient.GetFromJsonAsync<List<LessonContentDto>>($"/api/LessonContentCPs/lesson/{id}");
            return result;
        }
        
        public async Task<List<LessonContentDto>> GetAllLessonContent()
        {
            var result = await _httpClient.GetFromJsonAsync<List<LessonContentDto>>($"/api/LessonContentCPs/allLessonContent");
            return result;
        }

        public async Task<LessonContentUpdateVM> GetbyId(Guid id)
        {
            var url = Path.Combine("/api/LessonContentCPs", id.ToString());
            var result = await _httpClient.GetFromJsonAsync<LessonContentUpdateVM>(url);
            return result;
        }

        public async Task<PageList<LessonContentDto>> GetLessons(Guid Id, LessonContentListSearch parameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = parameters.PageNumber.ToString()
            };

            if (!string.IsNullOrEmpty(parameters.Name))
                queryStringParam.Add("Name", parameters.Name);
            if (!string.IsNullOrEmpty(parameters.Status.ToString()))
                queryStringParam.Add("Status", parameters.Status.ToString());

            string url = QueryHelpers.AddQueryString("/api/LessonContentCPs/getall/" + Id.ToString(), queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<LessonContentDto>>(url);

            return result;
        }

        public async Task<int> Update(Guid id, LessonContentUpdateVM update)
        {
            var url = Path.Combine("/api/LessonContentCPs", id.ToString());
            var resual = await _httpClient.PutAsJsonAsync(url, update);
            if (resual.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<bool> RemoveListLessonContentCP(List<Guid> listIdlessoncontent)
        {
            var result = await _httpClient.PostAsJsonAsync($"/api/LessonContentCPs/deletelist/", listIdlessoncontent);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
