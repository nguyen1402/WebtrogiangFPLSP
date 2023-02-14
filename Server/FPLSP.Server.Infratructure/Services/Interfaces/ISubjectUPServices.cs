using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop;
using FPLSP.Server.Infrastructure.ViewModels.Subject;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface ISubjectUPServices
    {
        Task<PageList<SubjectDto>> GetSubjects(Guid idspecializedUP, SubjectListSearch subjectParameters);
        Task<PageList<LectuterSpecializedSubjectVM>> GetAllLectuterSpecializedSubject(SubjectListSearch subjectParameters, Guid lectuterId, Guid? idspec);
        Task<List<SubjectDto>> GetAllSubjectAsync();
        Task<PageList<SubjectDto>> GetAllSubjectAsync2(SubjectListSearchMonDeThi mon);
        Task<List<SubjectDto>> GetAllSubjectIsdemo();
        Task<bool> CreateSubject(Guid idspecializedUP, SubjectCreateVM subject);
        Task<bool> UpdateSubject(Guid Id, SubjectUpdateVM subject);
        Task<bool> DeleteSubject(Guid idspecializedUP, Guid id);
        Task<bool> DeleteListSubjectUP(List<Guid> idsubjectUP);
        Task<SubjectUP> GetSubjectbyId(Guid id);
        Task<List<SubjectUP>> GetAllSubjectbyIdLecture(Guid idLecture);
    }
}
