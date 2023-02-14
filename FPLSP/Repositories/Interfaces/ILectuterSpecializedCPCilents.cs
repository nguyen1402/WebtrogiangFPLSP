using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.LectuterSpecializedCP;

namespace FPLSP.Repositories.Interfaces
{
    public interface ILectuterSpecializedCPCilents
    {
        Task<PageList<LectuterSpecializedCPDto>> Gets(Guid specializedId, LectuterSpecializedCPListSearch parameters);
        Task<LectuterSpecializedCPDto> GetbyId(Guid specializedId, Guid lecturerid);
        Task<List<LectuterSpecializedCPDto>> GetAllAsync();
        Task<int> Create(Guid specializedId, LectuterSpecializedCPCreateVM create);
        Task<int> Update(Guid specializedId, Guid lecturerid, LectuterSpecializedCPUpdateVM update);
        Task<int> Delete(Guid specializedId, Guid lecturerid);
    }
}
