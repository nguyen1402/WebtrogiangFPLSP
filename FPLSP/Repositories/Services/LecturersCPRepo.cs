using DocumentFormat.OpenXml.Office2010.Excel;
using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.LecturerCPVm;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Json;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace FPLSP.Repositories.Services
{
    public class LecturersCPRepo : ILecturersCPRepo
    {
        public HttpClient _httpClient { get; set; }
        private readonly JsonSerializerOptions _options;
        private readonly IHostingEnvironment _hostingEnvironment;
        public LecturersCPRepo(HttpClient httpClient, IHostingEnvironment hostingEnvironment)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<bool> CreateLecturer(LecturersCPRequest LecturerCPViewModel)
        {
            var putResult = await _httpClient.PostAsJsonAsync($"/api/LecturersCPs/createLecture", LecturerCPViewModel);
            if (putResult.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<bool> UpdateLecturer(Guid Id, LecturersCPRequest LecturerCPViewModel)
        {
            var putResult = await _httpClient.PutAsJsonAsync($"/api/LecturersCPs/{Id}", LecturerCPViewModel);
            if (putResult.IsSuccessStatusCode)
                return true;

            return false;
        }
        public async Task<bool> UpdateLectureCP(LecturersCP lecturerCP)
        {
            var putResult = await _httpClient.PutAsJsonAsync($"/api/LecturersCPs/UpdateLectureCP", lecturerCP);
            if (putResult.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<bool> DeleteLecturer(Guid Id)
        {
            var deleteResult = await _httpClient.DeleteAsync($"/api/LecturersCPs/{Id}");
            if (deleteResult.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<List<LecturersCP>> GetAllLecturerAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<List<LecturersCP>>("/api/LecturersCPs/all");
            return result;
        }

        public async Task<PageList<LecturersCPViewModel>> GetLecturerListAsync(PagingParameters pagingParameters)
        {
            var result = await _httpClient.GetFromJsonAsync<PageList<LecturersCPViewModel>>("/api/LecturersCPs");
            return result;
        }

        public async Task<LecturersCPViewModel> GetLecturerListById(Guid Id)
        {
            var response = await _httpClient.GetAsync($"/api/LecturersCPs/{Id}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var lecturer = JsonSerializer.Deserialize<LecturersCPViewModel>(content, _options);
            return lecturer;
        }

        public async Task<List<LecturersCP>> GetLecturerMapper()
        {
            var maxCodeLecturer = await _httpClient.GetFromJsonAsync<List<LecturersCP>>("/api/LecturersCPs/all");
            return maxCodeLecturer;
        }

        public async Task<LecturersCPViewModel> GetMaxCodeLecturer()
        {
            var maxCodeLecturer = await _httpClient.GetFromJsonAsync<LecturersCPViewModel>("/api/LecturersCPs/maxCode");
            return maxCodeLecturer;
        }

        public async Task<string> LoadingImageUrl(IBrowserFile file, string lecturerCode)
        {
            var x = file.Name;
            string fileName = $"{_hostingEnvironment.WebRootPath}\\css\\images\\LecturerCP\\{lecturerCode}.png";

            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                Stream stream = file.OpenReadStream();

                await stream.CopyToAsync(fileStream);
                fileStream.Flush();
            }
            var imageUrl = $"{lecturerCode}.png";

            return imageUrl;
        }

        public async Task<PageList<LecturersCPViewModel>> GetLecturerListPagingAsync(LecturersCPListSearch search)
        {

            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = search.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(search.Name))
                queryStringParam.Add("name", search.Name);
            if (search.Status != null)
                queryStringParam.Add("status", search.Status.ToString());
            if (search.RoleId != null)
                queryStringParam.Add("RoleId", search.RoleId.ToString());
            if (search.TrainingFacilityID != null)
                queryStringParam.Add("TrainingFacilityID", search.TrainingFacilityID.ToString());

            string url = QueryHelpers.AddQueryString("/api/LecturersCPs", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<LecturersCPViewModel>>(url);

            return result;
        }

        public async Task<bool> RemoveListLecturer(List<Guid> listIdLecturer)
        {
            var result = await _httpClient.PostAsJsonAsync($"/api/LecturersCPs/deletelist/list", listIdLecturer);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> CreateLecturerForTrain(CreateleatureForTrainVm lecturersCPVM)
        {

            var postResult = await _httpClient.PostAsJsonAsync("/api/LecturersCPs/train", lecturersCPVM);

            return postResult.IsSuccessStatusCode;

        }

        public async Task<bool> UpdateLecturerTrain(Guid Id, CreateleatureForTrainVm createleatureForTrain)
        {
            var postResult = await _httpClient.PutAsJsonAsync($"/api/LecturersCPs/train/{Id}", createleatureForTrain);

            return postResult.IsSuccessStatusCode;
        }
    }
}