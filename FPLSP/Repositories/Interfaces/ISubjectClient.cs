using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.Subject;

namespace FPLSP.Repositories
{
    public interface ISubjectClient
    {
        Task<PageList<SubjectDto>> GetSubjects(Guid specid, SubjectCPSearch subjectParameters);
        Task<List<SubjectDto>> GetAllSubjectAsync();
        Task<SubjectDto> GetSubjectbyId(Guid id);
        Task<int> CreateSubject(SubjectCreateVM subject);
        Task<int> UpdateSubject(Guid id, SubjectUpdateVM subject_update);
        Task<int> DeleteSubject(Guid id);
        Task<string> UploadProductImage(MultipartFormDataContent content);
        Task<bool> RemoveListSubjectCP(List<Guid> listIdSubject);
        Task<List<SubjectDto>> GetAllSubjectByIdSpecialzed(Guid idspecialzed);
        Task<SubjectUpdateVM> GetUpdateSubjectbyId(Guid idupdate);
    }
}
