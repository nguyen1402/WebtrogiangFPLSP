using Blazored.Toast.Services;
using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.TrainingFacilitiesCPVm;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Json;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace FPLSP.Repositories.Services
{
    public class TrainingFacilitiesCPRepo : ITrainingFacilitiesCPRepo
    {
        public HttpClient _httpClient { get; set; }
        private readonly JsonSerializerOptions _options;
        private readonly IHostingEnvironment _hostingEnvironment;
        public IToastService ToastService { get; set; } = new ToastService();
        public TrainingFacilitiesCPRepo(HttpClient httpClient, IHostingEnvironment hostingEnvironment)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<List<TrainingFacilitiesCP>> GetTrainingFacilitiesAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<List<TrainingFacilitiesCP>>("/api/TrainingFacilitiesCPs/all");
            return result;
        }

        public async Task<bool> CreateTrainingFacility(TrainingFacilitiesCPRequest trainingFacilitiesCPRequest)
        {
            var content = JsonSerializer.Serialize(trainingFacilitiesCPRequest);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            var postResult = await _httpClient.PostAsync("/api/TrainingFacilitiesCPs", bodyContent);

            if (postResult.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<bool> UpdateTrainingFacility(Guid Id, TrainingFacilitiesCPRequest trainingFacilitiesCPRequest)
        {
            var putResult = await _httpClient.PutAsJsonAsync($"/api/TrainingFacilitiesCPs/{Id}", trainingFacilitiesCPRequest);
            if (putResult.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<bool> DeleteTrainingFacility(Guid Id)
        {
            var deleteResult = await _httpClient.DeleteAsync($"/api/TrainingFacilitiesCPs/{Id}");
            if (deleteResult.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<PageList<TrainingFacilitiesCPViewModel>> GetTrainingFacilityList(TrainingFacilitiesCPListSearch search)
        {

            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = search.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(search.Name))
                queryStringParam.Add("name", search.Name);
            if (search.Status != null)
                queryStringParam.Add("status", search.Status.ToString());

            string url = QueryHelpers.AddQueryString("/api/TrainingFacilitiesCPs", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<TrainingFacilitiesCPViewModel>>(url);
            return result;
        }

        public async Task<TrainingFacilitiesCPViewModel> GetTrainingFacilityListById(Guid Id)
        {
            var response = await _httpClient.GetFromJsonAsync<TrainingFacilitiesCPViewModel>($"/api/TrainingFacilitiesCPs/{Id}");


            return response;
        }

        public async Task<IQueryable<TrainingFacilitiesCPViewModel>> GetTrainingFacilityMapper()
        {
            var url = Path.Combine("/api/TrainingFacilitiesCPs/all");

            var response = await _httpClient.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var result = JsonSerializer.Deserialize<IQueryable<TrainingFacilitiesCPViewModel>>(content, _options);

            return result;
        }

        public async Task<TrainingFacilitiesCP> GetTrainingFacilityMaxCode()
        {
            var maxCodetf = await _httpClient.GetFromJsonAsync<TrainingFacilitiesCP>("/api/TrainingFacilitiesCPs/maxCode");
            return maxCodetf;
        }

        public async Task<string> LoadingImageUrl(IBrowserFile file, string trainingFacilityCode)
        {
            try
            {
                var x = file.Name;
                string fileName = $"{_hostingEnvironment.WebRootPath}\\css\\images\\TrainingFacilityCP\\{trainingFacilityCode}.png";

                using (FileStream fileStream = System.IO.File.Create(fileName))
                {
                    Stream stream = file.OpenReadStream(10000000);

                    await stream.CopyToAsync(fileStream);
                    fileStream.Flush();
                }
                var imageUrl = $"{trainingFacilityCode}.png";

                return imageUrl;
            }
            catch (Exception)
            {
                ToastService.ShowError("Không tải File quá dung lượng cho phép", "Error");
                return "";
            }
        }

        public async Task<bool> RemoveListTF(List<Guid> listIdTF)
        {
            var result = await _httpClient.PostAsJsonAsync($"/api/TrainingFacilitiesCPs/deletelist/", listIdTF);
            return result.IsSuccessStatusCode;
        }
    }
}
