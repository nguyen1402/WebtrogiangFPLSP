using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.SubjectsSpecializedVM;

namespace FPLSP.Repositories.Interfaces
{
    public interface ISubjectsSpecializedUPRepo
    {
        Task<PageList<SubjectsSpecializedDtos>> GetPagingParamets(Guid specializedId, SubjectsSpecializedCPListSearch parameters);
        Task<SubjectsSpecializedDtos> GetbyId(Guid specializedId, Guid IdSubject);
        Task<List<SubjectsSpecializedDtos>> GetAllAsync();
        Task<Dictionary<SpecializedUP, List<SubjectsSpecializedDtos>>> GetSubOfSpecGroupBy();
        Task<bool> Create(Guid specializedId, SubjectsSpecializedCreateVM create);
        Task<bool> Update(Guid specializedId, Guid IdSubject, SubjectsSpecializedUpdateVM update);
        Task<bool> Delete(Guid specializedId, Guid IdSubject);
        Task<List<SpecializedUP>> GetAllSpecUP();
    }
}
