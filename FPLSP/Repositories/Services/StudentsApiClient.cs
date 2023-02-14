using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Dtos.StudentUPDtos;

namespace FPLSP.Data.StudentsApiClient
{
    public class StudentsApiClient : IStudentsApiClient
    {
        public HttpClient _httpClient;
        private Guid _idClass;

        public StudentsApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }


        public async Task<List<StudentUpDto>> GetStudentUpDto()
        {
            var url = Path.Combine("/api/Student");
            var result = await _httpClient.GetFromJsonAsync<List<StudentUpDto>>(url);
            return result;
        }


        public async Task<bool> CreateStudentInClass(CreateStudentInClassDto createStudentInClassDto)
        {
            var url = Path.Combine("/api/ManageStudents", createStudentInClassDto.idStudent.ToString());
            var result = await _httpClient.PutAsJsonAsync(url, createStudentInClassDto);
            return result.IsSuccessStatusCode;
        }
    }
}
