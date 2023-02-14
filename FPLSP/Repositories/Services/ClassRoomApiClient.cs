using FPLSP.Server.Domain.Dtos;
using System.Text.Json;

namespace FPLSP.Data.ClassRoomsApiClient
{
    public class ClassRoomApiClient : IClassRoomApiClient
    {
        public HttpClient _httpClient;
        private readonly JsonSerializerOptions _options;

        public ClassRoomApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<List<ClassRoomDto>> GetClassUpDto()
        {
            var url = Path.Combine("/api/ClassRooms");

            var response = await _httpClient.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var result = JsonSerializer.Deserialize<List<ClassRoomDto>>(content, _options);

            return result;
        }
    }
}
