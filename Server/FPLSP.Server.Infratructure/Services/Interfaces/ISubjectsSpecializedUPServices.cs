using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.SubjectsSpecializedVM;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface ISubjectsSpecializedUPServices
    {
        Task<PageList<SubjectsSpecializedDtos>> GetPagingParamets(List<Guid> specializedId, SubjectsSpecializedCPListSearch parameters);
        Task<SubjectsSpecializedDtos> GetbyId(Guid specializedId, Guid IdSubject);
        Task<List<SubjectsSpecializedDtos>> GetAllAsync();
        Task<bool> Create(Guid specializedId, SubjectsSpecializedCreateVM create);
        Task<bool> Update(Guid specializedId, Guid IdSubject, SubjectsSpecializedUpdateVM update);
        Task<bool> Delete(Guid specializedId, Guid IdSubject);

    }
}
