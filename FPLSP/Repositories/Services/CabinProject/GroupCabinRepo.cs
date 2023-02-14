using FPLSP.Repositories.Interfaces.CabinProject;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.GroupCabin;
using Microsoft.AspNetCore.WebUtilities;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Text;
using System.Text.Json;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace FPLSP.Repositories.Services.Cabin
{
    public class GroupCabinRepo : IGroupCabinRepo
    {
        public HttpClient _httpClient { get; set; }
        private readonly JsonSerializerOptions _options;
        private readonly IHostingEnvironment _hostingEnvironment;

        public GroupCabinRepo(HttpClient httpClient, IHostingEnvironment hostingEnvironment)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<bool> CreateGroupCabin(GroupCabinCreateViewModel request)
        {
            var content = JsonSerializer.Serialize(request);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            var postResult = await _httpClient.PostAsync("/api/GroupCabins", bodyContent);

            if (postResult.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<bool> DeleteGroupCabin(Guid IdSpec, Guid IdCabin)
        {
            var deleteResult = await _httpClient.DeleteAsync($"/api/GroupCabins/{IdSpec}/{IdCabin}");
            if (deleteResult.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<List<GroupCabinViewModel>> GetAllGroupCabinAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<List<GroupCabinViewModel>>("/api/GroupCabins/all");
            return result;
        }

        public async Task<GroupCabinViewModel> GetGroupCabinListById(string IdSpec, string IdCabin)
        {
            var response = await _httpClient.GetFromJsonAsync<GroupCabinViewModel>($"/api/GroupCabins/{IdSpec}/{IdCabin}");
            return response;
        }

        public async Task<PageList<GroupCabinViewModel>> GetGroupCabinListSearch(GroupCabinSearchViewModel search)
        {
            var queryStringParam = new Dictionary<string, string>();

            #region Tham số trên Url
            if (!string.IsNullOrEmpty(search.GroupCabinName))
                queryStringParam.Add("GroupCabinName", search.GroupCabinName);
            if (search.IndexOfGroupCabin != 0)
                queryStringParam.Add("DateOfGrouping", search.IndexOfGroupCabin.ToString());

            // Trạng Thái
            if (search.Status != -1)
                queryStringParam.Add("Status", search.Status.ToString());
            #endregion

            string url = QueryHelpers.AddQueryString("/api/GroupCabins", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<GroupCabinViewModel>>(url);

            return result;
        }

        public async Task<bool> RemoveListGroupCabin(List<(Guid, Guid)> listIdSpecCabin)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateGroupCabin(Guid IdSpec, Guid IdCabin, GroupCabinUpdateViewModel request)
        {
            var putResult = await _httpClient.PutAsJsonAsync($"/api/GroupCabins/{IdSpec}/{IdCabin}", request);
            if (putResult.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<bool> ChangeStatus(string IdSpec, string IdCabin)
        {
            var putResult = await _httpClient.PutAsJsonAsync($"/api/GroupCabins/ChangeStatus/{IdSpec}/", IdCabin);
            if (putResult.IsSuccessStatusCode)
                return true;

            return false;
        }
    }
}
