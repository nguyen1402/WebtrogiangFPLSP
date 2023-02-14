using DocumentFormat.OpenXml.Office2010.Excel;
using FPLSP.Repositories.Interfaces.CabinProject;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin;
using FPLSP.Server.Infrastructure.ViewModels.LecturerCPVm;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.WebUtilities;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace FPLSP.Repositories.Services.Cabin
{
    public class CabinRepo : ICabinRepo
    {
        public HttpClient _httpClient { get; set; }
        private readonly JsonSerializerOptions _options;
        private readonly IHostingEnvironment _hostingEnvironment;

        public CabinRepo(HttpClient httpClient, IHostingEnvironment hostingEnvironment)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<bool> CreateCabin(CabinCreateViewModel request)
        {
            var content = JsonSerializer.Serialize(request);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            var postResult = await _httpClient.PostAsync("/api/Cabins", bodyContent);

            if (postResult.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<bool> DeleteCabin(Guid Id)
        {
            var deleteResult = await _httpClient.DeleteAsync($"/api/Cabins/{Id}");
            if (deleteResult.IsSuccessStatusCode)
                return true;

            return false;

        }
		public async Task<bool> ChangeStatus(string IdCabin)
		{
			var deleteResult = await _httpClient.PutAsJsonAsync($"/api/Cabins/{IdCabin}", IdCabin);
			if (deleteResult.IsSuccessStatusCode)
				return true;

			return false;
		}

		public async Task<List<CabinViewModel>> GetAllCabinAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<List<CabinViewModel>>("/api/Cabins/all");
            return result;
        }

        public async Task<CabinViewModel> GetCabinListById(string Id)
        {
            var response = await _httpClient.GetFromJsonAsync<CabinViewModel>($"/api/Cabins/{Id}");
            return response;
        }

        public async Task<PageList<CabinViewModel>> GetCabinListSearch(CabinSearchViewModel search)
        {
            var queryStringParam = new Dictionary<string, string>();

            #region Tham số trên Url 
                if (!string.IsNullOrEmpty(search.CabinName))
                    queryStringParam.Add("CabinName", search.CabinName); 
            if (!string.IsNullOrEmpty(search.BuildingName))
                    queryStringParam.Add("BuildingName", search.BuildingName); 
            if (!string.IsNullOrEmpty(search.Status.ToString()))
                    queryStringParam.Add("Status", search.Status.ToString());
               

                // Trạng Thái
              
            #endregion

            string url = QueryHelpers.AddQueryString("/api/Cabins", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<CabinViewModel>>(url);

            return result;
        }

        public async Task<bool> RemoveListCabin(List<Guid> listIdSpecCabin)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateCabin(Guid Id, CabinUpdateViewModel request)
        {
            var putResult = await _httpClient.PutAsJsonAsync($"/api/Cabins/{Id}", request);
            if (putResult.IsSuccessStatusCode)
                return true;

            return false;
        }
    }
}
