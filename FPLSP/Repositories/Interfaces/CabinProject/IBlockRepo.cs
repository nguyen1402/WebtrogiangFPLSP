using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;

namespace FPLSP.Repositories.Interfaces.CabinProject
{
    public interface IBlockRepo
    {
        Task<List<BlockDto>> GetAll();
        Task<bool> CreateBlock(BlockVM blockVM);
        Task<bool> DeleteBlock(string Id);
        Task<bool> UpdateBlock(BlockVM blockVmM);
        Task<BlockVM> GetDetails(string Id);
    }
}
