using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.Specialized;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface ISpecializedUPServices
    {
        Task<PageList<SpecializedDto>> GetSpecializeds(Guid idBo, SpecializedListSearch specializedParameters);

        Task<SpecializedDto> GetbyId(Guid idBo, Guid id);
        Task<List<SpecializedDto>> GetAllAsync(Guid idspec);
        Task<List<SpecializedDto>> GetAll();
        Task<SpecializedUP> GetbyIdSpec(Guid id);
        Task<List<SpecializedDto>> LoctheoLever(int lever);
        Task<int> CreateSpecialized(Guid idBo, SpecializedVM specialized);

        Task<int> UpdateSpecialized(Guid idBo, Guid id, SpecializedVM specialized_update);
        Task<int> DeleteSpecialized(Guid idBo, Guid id);
    }
}
