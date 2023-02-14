using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.Subject;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface ISubjectServices
    {
        Task<PageList<SubjectDto>> GetSubjects(Guid specid, SubjectCPSearch subjectParameters);
        Task<IQueryable<SubjectCP>> GetAllSubjectAsync();
        Task<int> CreateSubject(SubjectCreateVM subject);
        Task<int> UpdateSubject(Guid id, SubjectUpdateVM subject);
        Task<int> DeleteSubject(Guid id);
        Task<SubjectDto> GetSubjectbyId(Guid id);
        Task<bool> RemoveListSubjectCP(List<Guid> listIdReport);
        Task<List<SubjectDto>> GetAllSubjectByIdSpecialzed(Guid idspecialzed);
        Task<SubjectUpdateVM> GetUpdateSubjectbyId(Guid id);
    }
}
