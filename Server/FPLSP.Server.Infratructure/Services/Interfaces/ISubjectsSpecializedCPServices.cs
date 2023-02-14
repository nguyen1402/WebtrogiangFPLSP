using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.SubjectsSpecializedVM;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface ISubjectsSpecializedCPServices
    {
        Task<PageList<SubjectsSpecializedDtos>> GetPagingParamets(Guid specializedId, SubjectsSpecializedCPListSearch parameters);
        Task<SubjectsSpecializedDtos> GetbyId(Guid specializedId, Guid IdSubject);
        Task<List<SubjectsSpecializedDtos>> GetAllAsync();
        Task<int> Create(Guid specializedId, SubjectsSpecializedCreateVM create);
        Task<int> Update(Guid specializedId, Guid IdSubject, SubjectsSpecializedUpdateVM update);
        Task<int> Delete(Guid specializedId, Guid IdSubject);
    }
}
