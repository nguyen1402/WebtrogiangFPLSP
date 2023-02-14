using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.StudentCPDtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.StudentCP;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Json;

namespace FPLSP.Repositories.Services
{
    public class StudentCPApiClient : IStudentCPApiClient
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;

        public StudentCPApiClient(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<int> CreateStudent(CreateStudentCPVm student)
        {
            var content = JsonSerializer.Serialize(student);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            var postResult = await _client.PostAsync("/api/StudentsCP", bodyContent);

            if (postResult.IsSuccessStatusCode)
                return 1;

            return 0;
        }

        public Task<int> DeleteStudentCP(CreateStudentCPVm subject_delete)
        {
            throw new NotImplementedException();
        }

        public async Task<List<StudentCP>> GetAllStudentAsync()
        {
            var url = Path.Combine("/api/StudentsCP/all");

            var result = await _client.GetFromJsonAsync<List<StudentCP>>(url);
            return result;
        }

        public async Task<StudentCP> GetMaxIdStudent()
        {
            var url = Path.Combine("/api/StudentsCP/maxId");
            var result = await _client.GetFromJsonAsync<StudentCP>(url);
            return result;
        }

        public async Task<StudentCPDtos> GetStudentById(Guid id)
        {
            var url = Path.Combine("/api/StudentsCP", id.ToString());

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var student = JsonSerializer.Deserialize<StudentCPDtos>(content, _options);
            return student;
        }

        public async Task<PageList<StudentCPDtos>> GetStudentList(StudentCPListSearch student)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = student.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(student.NameStudent))
            {
                queryStringParam.Add("NameStudent", student.NameStudent);
            }
            if (!string.IsNullOrEmpty(student.Status))
            {
                queryStringParam.Add("Status", student.Status);
            }
            string url = QueryHelpers.AddQueryString("/api/StudentsCP", queryStringParam);

            var result = await _client.GetFromJsonAsync<PageList<StudentCPDtos>>(url);

            return result;
        }

        public async Task<int> UpdateStudentCP(StudentCPDtos student)
        {
            var url = Path.Combine("/api/StudentsCP", student.Id.ToString());
            var putResult = await _client.PutAsJsonAsync(url, student);
            if (putResult.IsSuccessStatusCode)
                return 1;

            return 0;
        }
    }
}
