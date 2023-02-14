using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.StudentQuizUPVm;

namespace FPLSP.Repositories.Services
{
    public class StudentQuizUPRepo : IStudentQuizUPRepo
    {
        private readonly HttpClient _httpClient;
        public StudentQuizUPRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<int> Create(StudentQuizCreateUPVM create)
        {
            var url = Path.Combine("/api/StudentQuizUPs");
            var resual = await _httpClient.PostAsJsonAsync(url, create);
            if (resual.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<int> Delete(Guid studenId, Guid quizId)
        {
            var url = Path.Combine($"/api/StudentQuizUPs/{studenId}/{quizId}");
            var resual = await _httpClient.DeleteAsync(url);
            if (resual.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<List<StudentQuizUPDtos>> GetAllAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<List<StudentQuizUPDtos>>($"/api/StudentQuizUPs/getall");
            return result;
        }

        public async Task<StudentQuizUPDtos> GetbyId(Guid studenId, Guid quizId)
        {
            var url = Path.Combine($"/api/StudentQuizUPs/{studenId}/{quizId}");
            var result = await _httpClient.GetFromJsonAsync<StudentQuizUPDtos>(url);
            return result;
        }

        public async Task<int> Update(Guid studenId, Guid quizId, StudentQuizUpdateUPVM update)
        {
            var url = Path.Combine($"/api/StudentQuizUPs/{studenId}/{quizId}");
            var resual = await _httpClient.PutAsJsonAsync(url, update);
            if (resual.IsSuccessStatusCode) return 1;
            return 0;
        }
    }
}
