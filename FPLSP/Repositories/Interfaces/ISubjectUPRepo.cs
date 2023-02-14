using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop;
using FPLSP.Server.Infrastructure.ViewModels.Subject;

namespace FPLSP.Repositories.Interfaces
{
    public interface ISubjectUPRepo
    {
        Task<PageList<SubjectDto>> GetSubjects(Guid idspecializedUP, SubjectListSearch subjectParameters);
        Task<PageList<LectuterSpecializedSubjectVM>> GetAllLectuterSpecializedSubject(SubjectListSearch subjectParameters, Guid lectuterId, Guid? idspec);
        Task<List<SubjectDto>> GetAllSubjectAsync();
        Task<PageList<SubjectDto>> GetAllSubjectAsync2(SubjectListSearchMonDeThi mon);
        Task<SubjectDto> GetSubjectbyId(Guid id);
        Task<bool> CreateSubject(Guid idspecializedUP, SubjectCreateVM subject);
        Task<bool> UpdateSubject(Guid Id, SubjectUpdateVM subjectVM);
        Task<bool> DeleteSubject(Guid idspecializedUP, SubjectDto subject_delete);
        Task<bool> DeleteListSubject(List<Guid> idsubjectUP);
        Task<string> UploadProductImage(MultipartFormDataContent content);
        Task<List<SubjectUP>> GetAllSubjectbyIdLecture(Guid idLecture);
    }
}
