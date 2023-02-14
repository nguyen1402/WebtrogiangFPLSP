using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.ContentOfExamsCP;

namespace FPLSP.Repositories.Interfaces
{
    public interface IContentOfExamCPRepo
    {
        Task<PageList<ContentOfExamCPDto>> GetCoeCPList(CoeListSearchVm ListSearch);
        Task<List<ContentOfExamCPDto>> GetCoeCPListAll();
        Task<PageList<ContentOfExamCPDto>> GetCoeCPListByExamId(Guid Id, CoeListSearchVm ListSearch);
        Task<ContentOfExamCP> GetCoeCPById(Guid Id);
        Task<bool> CreateCoeCP(CoeCreateVm CreateVm);
        Task<bool> UpdateCoeCP(Guid id, CoeUpdateVm UpdateVm);
        Task<bool> DeleteCoeCP(Guid id);
    }
}
