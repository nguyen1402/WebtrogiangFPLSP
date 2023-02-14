using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.ViewModels.NewFeed;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class NewFeedRepo : INewFeedRepo
    {
        private readonly HttpClient _httpClient;
        public NewFeedRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> AddToNewFeed(NewFeedVM newFeedVM)
        {
            var res = await _httpClient.PostAsJsonAsync($"/api/NewFeeds", newFeedVM);
            return res.IsSuccessStatusCode;
        }

        public async Task<PageList<NewFeedOverView>> GetListAllNewFeed(SearchNewFeed searchNewFeed)
        {
            var res = await _httpClient.GetFromJsonAsync<PageList<NewFeedOverView>>($"/api/NewFeeds");
            return res;
        }

        public async Task<List<NewFeedOverView>> GetListNewForUser(Guid IdUser)
        {
            var res = await _httpClient.GetFromJsonAsync<List<NewFeedOverView>>($"/api/NewFeeds/{IdUser.ToString()}");
            return res;
        }

        public async Task<bool> RemoveNewFeed(Guid IdNewFeed)
        {
            var res = await _httpClient.DeleteAsync($"/api/NewFeeds/{IdNewFeed.ToString()}");
            return res.IsSuccessStatusCode;
        }
        public async Task<List<NewFeedOverView>> GetListNewForClass(Guid? IdClass, Guid? IdSubject)
        {
            var queryStringParam = new Dictionary<string, string>
            {

            };
            if (IdClass.HasValue)
            {
                queryStringParam.Add("idclass", IdClass.ToString());
            }
            if (IdSubject.HasValue)
            {
                queryStringParam.Add("idsubject", IdSubject.ToString());
            }
            string url = QueryHelpers.AddQueryString($"/api/NewFeeds/getnewfeed-class", queryStringParam);
            var res = await _httpClient.GetFromJsonAsync<List<NewFeedOverView>>(url);
            return res;
        }
        public async Task<bool> UpdateNewFeed(Guid IdNewFeed, NewFeedVM newFeedVM)
        {
            var res = await _httpClient.PutAsJsonAsync($"/api/NewFeeds/{IdNewFeed}", newFeedVM);
            return res.IsSuccessStatusCode;
        }
    }
}
