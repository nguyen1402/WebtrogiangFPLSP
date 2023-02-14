using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Domain.Entities.UserParts;

namespace FPLSP.Repositories.Services
{
    public class TypeOfNewFeedRepo : ITypeOfNewFeedRepo
    {
        private readonly HttpClient _httpClient;
        public TypeOfNewFeedRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<TypeOfNewFeed>> GetNewFeedsAsync()
        {
            var res = await _httpClient.GetFromJsonAsync<List<TypeOfNewFeed>>("/api/TypesOfNewFeed");
            return res;
        }
    }
}
