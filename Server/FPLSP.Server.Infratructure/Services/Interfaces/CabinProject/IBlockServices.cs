using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.Cabin;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject
{
    public interface IBlockServices
    {
        Task<IQueryable<BlockDto>> GetAll();
        Task<BlockVM> GetById(Guid Id);
        Task<bool> CreateBlock(BlockVM block);
        Task<bool> DeleteBlock(Guid Id);
        Task<bool> UpdateBlock(BlockVM block);
    }
}
