using FPLSP.Server.Domain.Dtos;

namespace FPLSP.Data.ManageStudents
{
    public class ManageStudentApiClient : IManageStudentApiClient
    {
        public HttpClient _httpClient;


        public ManageStudentApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ManageStudentUpDto>> GetStudentUpDto(Guid id)
        {

            var result = await _httpClient.GetFromJsonAsync<List<ManageStudentUpDto>>($"/api/ManageStudents/{id}");
            return result;
        }


    }
}
