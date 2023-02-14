using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.ExamLinks;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IExamLinkCPServices
    {
        Task<PageList<ExamLinkCP>> GetExamLinkCPList(ExamLinkListSearchVm examLinkListSearch);
        Task<PageList<ExamLinkCP>> GetExamLinkCPListByExamId(Guid Id, ExamLinkListSearchVm examLinkListSearch);
        Task<ExamLinkCP> CreateExamLinkCP(ExamLinkCP examLinkCP);
        Task<ExamLinkCP> UpdateExamLinkCP(Guid id, ExamLinkUpdateVm examLinkUpdateVm);
        Task<ExamLinkCP> DeleteExamLinkCP(Guid id);

        Task<ExamLinkCP> GetExamLinkCPById(Guid ExamId);
        Task<List<ExamLinkCP>> GetExamLinkCPAll();
    }
}
