using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.ContentOfExamsCP;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IContentOfExamCPServices
    {
        Task<PageList<ContentOfExamCP>> GetCoeCpList(CoeListSearchVm coeListSearchVm);
        Task<List<ContentOfExamCP>> GetCoeCpListAll();
        Task<PageList<ContentOfExamCP>> GetCoeCpListByExamId(Guid Id, CoeListSearchVm coeListSearchVm);
        Task<ContentOfExamCP> CreateCoeCp(ContentOfExamCP examLinkCP);
        Task<ContentOfExamCP> UpdateCoeCp(Guid id, CoeUpdateVm coeUpdateVm);
        Task<ContentOfExamCP> DeleteCoeCp(Guid id);

        Task<ContentOfExamCP> GetCoeCPById(Guid id);
    }
}
