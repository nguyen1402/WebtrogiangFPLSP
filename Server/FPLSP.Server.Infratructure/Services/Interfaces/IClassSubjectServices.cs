using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IClassSubjectServices
    {
        Task<PageList<ClassSubjectUPDto>> GetPagingParamets(Guid subjectId, Guid lecuId, Guid specializedId, SubjectServicesCPListSearch parameters);
        Task<ClassSubjectUPDto> GetbyId(Guid specializedId, Guid lecturerid);

        Task<ListIdQuiz> GetListIdQuiz(Guid subjectId);
        //Task<List<LectuterSpecializedCPDto>> GetAllAsync();
        Task<int> Create(SubjectClassVM classUp);
        //Task<int> Update(Guid specializedId, Guid lecturerid, LectuterSpecializedCPUpdateVM update);
        Task<int> Delete(Guid idclass);

        Task<List<ClassUp>> GetClassUPBySubjectID(Guid subjectId);

        Task<List<SubjectClassUP>> GetAllSubjectClass();

        Task<ClassUp> GetClassUPbyId(Guid idClass);
    }
}
