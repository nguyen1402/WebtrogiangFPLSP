
using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.Specialized;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class SpecializedUPRepo : ISpecializedUPRepo
    {
        private readonly HttpClient _httpClient;
        public SpecializedUPRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<int> Create(Guid id, SpecializedVM models_create)
        {
            var url = Path.Combine("/api/SpecializedUPs", id.ToString());
            var result = await _httpClient.PostAsJsonAsync(url, models_create);
            if (result.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<int> Delete(Guid idBo, Guid id)
        {
            var url = Path.Combine("/api/SpecializedUPs", idBo.ToString(), id.ToString());
            var result = await _httpClient.DeleteAsync(url);
            if (result.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<List<SpecializedDto>> GetAll()
        {
            var url = Path.Combine("/api/SpecializedUPs/getall/tatca");
            var result = await _httpClient.GetFromJsonAsync<List<SpecializedDto>>(url);
            return result;
        }
        public async Task<SpecializedUP> GetByIdSpec(Guid id)
        {
            var url = Path.Combine($"/api/SpecializedUPs/spec/{id}");
            var result = await _httpClient.GetFromJsonAsync<SpecializedUP>(url);
            return result;
        }

        public async Task<List<SpecializedDto>> GetAllAsync(Guid idspec)
        {
            var url = Path.Combine("/api/SpecializedUPs/tatca", idspec.ToString());
            var result = await _httpClient.GetFromJsonAsync<List<SpecializedDto>>(url);
            return result;
        }

        public async Task<SpecializedDto> GetbyId(Guid idBo, Guid id)
        {
            var url = Path.Combine("/api/SpecializedUPs", idBo.ToString(), id.ToString());
            var result = await _httpClient.GetFromJsonAsync<SpecializedDto>(url);

            return result;
        }

        public async Task<PageList<SpecializedDto>> Gets(Guid idBo, SpecializedListSearch parameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = parameters.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(parameters.Name))
                queryStringParam.Add("name", parameters.Name);
            if (!string.IsNullOrEmpty(parameters.Status.ToString()))
                queryStringParam.Add("Status", parameters.Status.ToString());
            if (!string.IsNullOrEmpty(parameters.Code))
                queryStringParam.Add("Code", parameters.Code);
            string url = QueryHelpers.AddQueryString("/api/SpecializedUPs/all/" + idBo.ToString(), queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<SpecializedDto>>(url);

            return result;
        }

        public async Task<List<SpecializedDto>> Locthoelever(int lever)
        {
            var url = Path.Combine("/api/SpecializedUPs/loc/tatcalever/" + lever.ToString());
            var result = await _httpClient.GetFromJsonAsync<List<SpecializedDto>>(url);
            return result;
        }

        public async Task<int> Update(Guid idBo, Guid id, SpecializedVM models_update)
        {
            var url = Path.Combine("/api/SpecializedUPs", idBo.ToString(), id.ToString());
            var result = await _httpClient.PutAsJsonAsync(url, models_update);
            if (result.IsSuccessStatusCode) return 1;
            return 0;
        }
    }
}
