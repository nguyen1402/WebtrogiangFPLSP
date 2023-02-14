using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.NewFeed;

namespace FPLSP.Repositories.Services
{
    public class SenderNotification : ISenderNotification
    {
        private readonly HttpClient _httpClient;
        public SenderNotification(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> SendAsync(NewFeedVM newFeedVM)
        {
            var res = await _httpClient.PostAsJsonAsync("/api/Noticafications", newFeedVM);
            return res.IsSuccessStatusCode;
        }
    }
}
