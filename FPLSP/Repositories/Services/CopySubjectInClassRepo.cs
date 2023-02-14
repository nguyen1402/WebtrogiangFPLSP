using FPLSP.Repositories.Interfaces;

namespace FPLSP.Repositories.Services
{
    public class CopySubjectInClassRepo : ICopySubjectInClassRepo
    {
        public CopySubjectInClassRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public HttpClient _httpClient { get; set; }

        public async Task<bool> Copy(Guid idsubject)
        {
            var result = await _httpClient.GetAsync($"/api/CopySubjectInClasses/CreateAllSubject/{idsubject}");
            return result.IsSuccessStatusCode;
        }
    }
}
