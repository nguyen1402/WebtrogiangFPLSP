using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.Specialized;

namespace FPLSP.Repositories.Interfaces
{
    public interface ISpecializedUPRepo
    {
        Task<PageList<SpecializedDto>> Gets(Guid idBo, SpecializedListSearch parameters);
        Task<SpecializedDto> GetbyId(Guid idBo, Guid id);
        Task<List<SpecializedDto>> GetAllAsync(Guid idspec);
        Task<SpecializedUP> GetByIdSpec(Guid id);
        Task<List<SpecializedDto>> GetAll();
        Task<List<SpecializedDto>> Locthoelever(int lever);
        Task<int> Create(Guid id, SpecializedVM models_create);
        Task<int> Update(Guid idBo, Guid id, SpecializedVM models_update);
        Task<int> Delete(Guid idBo, Guid id);
    }
}
