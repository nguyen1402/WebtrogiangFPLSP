using DocumentFormat.OpenXml.Office2010.Excel;
using FPLSP.Repositories.Interfaces.CabinProject;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;

namespace FPLSP.Repositories.Services.CabinProject
{
    public class SemesterRepo : ISemesterRepo
    {
        public HttpClient _httpClient;
        public SemesterRepo(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<bool> CreateSemester(SemesterVM semesterVM)
        {
            var answer = await _httpClient.PostAsJsonAsync("api/Semesters/", semesterVM);
            if (answer.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteSemester(string Id)
        {
            var answer = await _httpClient.DeleteAsync($"api/Semesters/{Id}");
            if (answer.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<List<SemesterDto>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<SemesterDto>>($"api/Semesters/");
        }

        public async Task<SemesterVM> GetDetails(string Id)
        {
            return await _httpClient.GetFromJsonAsync<SemesterVM>($"api/Semesters/{Id}");
        }
        public async Task<bool> UpdateSemester(SemesterVM semesterVM)
        {
            var semester = await _httpClient.PutAsJsonAsync($"api/Semesters/", semesterVM);
            if (semester.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
