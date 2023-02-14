using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.BookMark;

namespace FPLSP.Repositories.Services
{
    public class BookMarkClassRepo : IBookMarkClassRepo
    {
        private readonly HttpClient _httpClient;
        public BookMarkClassRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> AddToBookMark(BookMarkClassVM bookMarkClass)
        {
            var res = await _httpClient.PostAsJsonAsync($"/api/BookMarkClasses", bookMarkClass);
            return res.IsSuccessStatusCode;
        }

        public async Task<List<BookMarkClass>> GetListBookMarkForUser(Guid IdUser)
        {
            var res = await _httpClient.GetFromJsonAsync<List<BookMarkClass>>($"/api/BookMarkClasses/{IdUser.ToString()}");
            return res;
        }

        public async Task<bool> RemoveBookMark(Guid IdBookMark)
        {
            var res = await _httpClient.DeleteAsync($"/api/BookMarkClasses/{IdBookMark.ToString()}");
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateBookMark(Guid IdBookMark, BookMarkClassVM bookMarkClass)
        {
            var res = await _httpClient.PutAsJsonAsync($"/api/BookMarkClasses/{IdBookMark.ToString()}", bookMarkClass);
            return res.IsSuccessStatusCode;
        }
    }
}
