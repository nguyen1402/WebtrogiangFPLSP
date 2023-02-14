using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.FPLSPDbContext;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.SubjectsSpecializedVM;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Text.Json;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace FPLSP.Repositories.Services
{
    public class SubjectsSpecializedUPRepo : ISubjectsSpecializedUPRepo
    {
        public HttpClient _httpClient { get; set; }
        private readonly JsonSerializerOptions _options;
        private readonly IHostingEnvironment _hostingEnvironment;
        private ISpecializedUPRepo _specRepo;
        private ApplicationDbContext _ApplicationDbContext = new ApplicationDbContext();

        public SubjectsSpecializedUPRepo(HttpClient httpClient, IHostingEnvironment hostingEnvironment, ISpecializedUPRepo specRepo)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _hostingEnvironment = hostingEnvironment;
            _specRepo = specRepo;
        }

        public async Task<bool> Create(Guid specializedId, SubjectsSpecializedCreateVM createVm)
        {
            var content = JsonSerializer.Serialize(createVm);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            var postResult = await _httpClient.PostAsync($"/api/SubjectsSpecializedUPs/{specializedId}", bodyContent);

            if (postResult.IsSuccessStatusCode)
                return true;

            return false;
        }

        public Task<bool> Delete(Guid specializedId, Guid IdSubject)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SubjectsSpecializedDtos>> GetAllAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<List<SubjectsSpecializedDtos>>("/api/SubjectsSpecializedUPs/getall");
            return result;
        }

        public Task<SubjectsSpecializedDtos> GetbyId(Guid specializedId, Guid IdSubject)
        {
            throw new NotImplementedException();
        }

        public async Task<PageList<SubjectsSpecializedDtos>> GetPagingParamets(Guid specializedId, SubjectsSpecializedCPListSearch searchDTO)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = searchDTO.PageNumber.ToString()
            };

            if (!string.IsNullOrEmpty(searchDTO.Name))
            {
                queryStringParam.Add("Name", searchDTO.Name.ToString());
            }

            string url = QueryHelpers.AddQueryString($"/api/SubjectsSpecializedUPs/getall/{specializedId}", queryStringParam);
            var result = await _httpClient.GetFromJsonAsync<PageList<SubjectsSpecializedDtos>>(url);
            return result;
        }

        public Task<bool> Update(Guid specializedId, Guid IdSubject, SubjectsSpecializedUpdateVM update)
        {
            throw new NotImplementedException();
        }

        public async Task<Dictionary<SpecializedUP, List<SubjectsSpecializedDtos>>> GetSubOfSpecGroupBy()
        {
            var subspecList = await GetAllAsync();

            Dictionary<SpecializedUP, List<SubjectsSpecializedDtos>> subOfSpec = new Dictionary<SpecializedUP, List<SubjectsSpecializedDtos>>();

            if (subspecList != null)
            {
                var groupBySpec = subspecList.GroupBy(x => _ApplicationDbContext.SpecializedUPs.ToList().FirstOrDefault(c => c.Id == x.SpecializedId));
                foreach (var group in groupBySpec)
                {
                    var listItem = new List<SubjectsSpecializedDtos>();
                    foreach (var item in group)
                    {
                        listItem.Add(item);
                    }
                    subOfSpec.Add(group.Key, listItem);
                }
            }

            return subOfSpec;
        }

        public async Task<List<SpecializedUP>> GetAllSpecUP()
        {
            return await _ApplicationDbContext.SpecializedUPs.ToListAsync();
        }

    }
}