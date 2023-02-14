using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.SubmitHomeWorkVM;
using System.Text.Json;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace FPLSP.Repositories.Services
{
    public class SubmitHomeworkForStudentRepo : ISubmitHomeworkForStudentRepo
    {
        public HttpClient _httpClient { get; set; }
        private readonly JsonSerializerOptions _options;
        private readonly IHostingEnvironment _hostingEnvironment;
        public SubmitHomeworkForStudentRepo(HttpClient httpClient, IHostingEnvironment hostingEnvironment)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<bool> Student_Update(Guid Id, SubmitHomeWorkForStudentUpdateVm summitUpdate)
        {
            var putResult = await _httpClient.PutAsJsonAsync($"/api/SubmitHomeworkForStudents/{Id}", summitUpdate);
            if (putResult.IsSuccessStatusCode)
                return true;

            return false;
        }
        public async Task<bool> AddMultipleDeadLine(ListHomeWorkForStudent listHomeWorkForStudent)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/SubmitHomeWorks/add-multiple-deadline", listHomeWorkForStudent);
            return result.IsSuccessStatusCode;
        }
        public async Task<List<SubmitHomeWork>> Student_GetAllAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<List<SubmitHomeWork>>("/api/SubmitHomeworkForStudents/all");
            return result;
        }

        public async Task<SubmitHomeWork> Student_GetSubmitByIdAsync(Guid id)
        {
            var response = await _httpClient.GetAsync($"/api/SubmitHomeworkForStudents/{id}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var submit = JsonSerializer.Deserialize<SubmitHomeWork>(content, _options);
            return submit;
        }
    }
}
