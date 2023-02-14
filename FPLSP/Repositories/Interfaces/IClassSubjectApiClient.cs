using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop;
using FPLSP.Server.Infrastructure.ViewModels.SpesializedUP;

namespace FPLSP.Repositories.Interfaces
{
    public interface IClassSubjectApiClient
    {
        Task<PageList<ClassSubjectUPDto>> GetPagingParamets(Guid subjectId, Guid lecuId, Guid specializedId, SubjectServicesCPListSearch parameters);

        Task<int> Create(SubjectClassVM classUp);

        Task<int> Delete(Guid idclass, Guid idsubject);

        Task<ListIdQuiz> GetListIDQuiz(Guid subjectId);
        Task<List<ClassUp>> GetlstClassUP(Guid subjectId);
        Task<List<SubjectClassUP>> GetAllSubjectClass();

        Task<List<ClassUp>> GetAllClass();
        Task<ClassUp> GetClassUPByIdClass(Guid idClass);

        Task<List<SpecializedUPViewModel>> GetChuyenNganh(Guid idLec);

        Task<int> Soluongsinhvientronglop(Guid idClass, Guid subjectId);
    }
}
