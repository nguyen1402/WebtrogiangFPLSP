using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.ExamLinks;

namespace FPLSP.Repositories.Interfaces
{
    public interface IExamLinkCPRepo
    {
        Task<PageList<ExamLinkDto>> GetExamLinkCPList(ExamLinkListSearchVm examLinkListSearch);
        Task<PageList<ExamLinkDto>> GetExamLinkCPListByExamId(Guid Id, ExamLinkListSearchVm examLinkListSearch);

        Task<ExamLinkCP> GetExamLinkCPById(Guid Id);
        Task<bool> CreateExamLinkCP(ExamLinkCreateVm examLinkCreateVm);
        Task<bool> UpdateExamLinkCP(Guid id, ExamLinkUpdateVm examLinkUpdateVm);
        Task<bool> DeleteExamLinkCP(Guid id);
        Task<List<ExamLinkCP>> GetExamLinkCP();
    }
}
