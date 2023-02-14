using DocumentFormat.OpenXml.Office2010.Excel;
using FPLSP.Pages.PagesSubjectCP;
using FPLSP.Repositories.Interfaces.CabinProject;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services.CabinProject
{
    public class SemesterBlockRepo : ISemesterBlockRepo
    {
        public HttpClient _httpClient;
        public SemesterBlockRepo(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<bool> CreateSemesterBlock(SemesterBlockVM semester)
        {
            var answer = await _httpClient.PostAsJsonAsync("api/SemesterBlocks/", semester);
            if (answer.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteSemesterBlock(string IdBlock, string IdSemester)
        {
            var answer = await _httpClient.DeleteAsync($"api/SemesterBlocks/{IdBlock}/{IdSemester}");
            if (answer.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<List<SemesterBlockDto>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<SemesterBlockDto>>("api/SemesterBlocks");
        }

        public async Task<SemesterBlockVM> GetById(string IdBlock, string IdSemester)
        {
            return await _httpClient.GetFromJsonAsync<SemesterBlockVM>($"api/SemesterBlocks/{IdBlock}/{IdSemester}");
        }

        public async Task<PageList<SemesterBlockDto>> GetPageList(SemesterBlockSearch semesterBlockSearch)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = semesterBlockSearch.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(Convert.ToString(semesterBlockSearch.Status)))
            {
                queryStringParam.Add("Status", Convert.ToString(semesterBlockSearch.Status));
            }
			if (!string.IsNullOrEmpty(semesterBlockSearch.Search))
			{
				queryStringParam.Add("Search", semesterBlockSearch.Search);
			}
			string url = QueryHelpers.AddQueryString($"/api/SemesterBlocks/page/", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<SemesterBlockDto>>(url);

			return result;
        }

        public async Task<bool> UpdateSemesterBlock(SemesterBlockVM semester)
        {
            var block = await _httpClient.PutAsJsonAsync($"api/SemesterBlocks/", semester);
            if (block.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
