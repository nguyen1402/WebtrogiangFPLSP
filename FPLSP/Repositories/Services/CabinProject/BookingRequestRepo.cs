using FPLSP.Repositories.Interfaces.CabinProject;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingRequest;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Json;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace FPLSP.Repositories.Services.BookingRequest
{
    public class BookingRequestRepo : IBookingRequestRepo
    {
        public HttpClient _httpClient { get; set; }
        private readonly JsonSerializerOptions _options;
        private readonly IHostingEnvironment _hostingEnvironment;

        public BookingRequestRepo(HttpClient httpClient, IHostingEnvironment hostingEnvironment)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<bool> CreateBookingRequest(BookingRequestCreateViewModel request)
        {
            var content = JsonSerializer.Serialize(request);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            var postResult = await _httpClient.PostAsync("/api/BookingRequests", bodyContent);

            if (postResult.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<bool> DeleteBookingRequest(Guid Id)
        {
            var deleteResult = await _httpClient.DeleteAsync($"/api/BookingRequests/undo/{Id}");
            if (deleteResult.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<List<BookingRequestViewModel>> GetAllBookingRequestAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<List<BookingRequestViewModel>>("/api/BookingRequests/all");
            return result;
        }

        public async Task<BookingRequestViewModel> GetBookingRequestListById(Guid Id)
        {
            var response = await _httpClient.GetAsync($"/api/BookingRequests/{Id}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var result = JsonSerializer.Deserialize<BookingRequestViewModel>(content, _options);
            return result;
        }

        public async Task<PageList<BookingRequestViewModel>> GetBookingRequestListSearch(BookingRequestSearchViewModel search)
        {
            var queryStringParam = new Dictionary<string, string>();

            #region Tham số trên Url 
            if (!string.IsNullOrEmpty(search.ContentOfRequest))
                queryStringParam.Add("BookingRequestName", search.ContentOfRequest);
            if (search.IndexOfBookingRequest != 0)
                queryStringParam.Add("DateOfGrouping", search.IndexOfBookingRequest.ToString());

            // Trạng Thái
            if (search.Status != -1)
                queryStringParam.Add("Status", search.Status.ToString());
            #endregion

            string url = QueryHelpers.AddQueryString("/api/BookingRequests", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<BookingRequestViewModel>>(url);

            return result;
        }

        public async Task<bool> RemoveListBookingRequest(List<Guid> listIdSpecBookingRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateBookingRequest(Guid Id, BookingRequestUpdateViewModel request)
        {
            var putResult = await _httpClient.PutAsJsonAsync($"/api/BookingRequests/{Id}", request);
            if (putResult.IsSuccessStatusCode)
                return true;

            return false;
        }
    }
}
