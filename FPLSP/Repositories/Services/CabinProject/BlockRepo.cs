using FPLSP.Repositories.Interfaces.CabinProject;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;

namespace FPLSP.Repositories.Services.CabinProject
{
    public class BlockRepo : IBlockRepo
    {

        public HttpClient _httpClient;
        public BlockRepo(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<bool> CreateBlock(BlockVM blockVM)
        {

            var answer = await _httpClient.PostAsJsonAsync("api/Blocks/", blockVM);
            if (answer.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteBlock(string Id)
        {
            var answer = await _httpClient.DeleteAsync($"api/Blocks/{Id}");
            if (answer.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<List<BlockDto>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<BlockDto>>("api/Blocks");
        }

        public async Task<BlockVM> GetDetails(string Id)
        {
            return await _httpClient.GetFromJsonAsync<BlockVM>($"api/Blocks/{Id}");
        }

        public async Task<bool> UpdateBlock(BlockVM blockVM)
        {
            var block = await _httpClient.PutAsJsonAsync($"api/Blocks/", blockVM);
            if (block.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }


    }
}
