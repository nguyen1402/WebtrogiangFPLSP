using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.ReportClassUP;

namespace FPLSP.Repositories.Interfaces
{
    public interface IReportClassUPRepo
    {
        Task<PageList<ReportUPDto>> GetPagingReportClassUPs(Guid classUPId, ReportClassUpSearch reportClassUpSearch);
        Task<List<ReportUPDto>> GetListReportClassUP();

        Task<bool> CreateReportClassUP(ReportUPViewModel report);

        Task<bool> UpdateReportClassUP(ReportUPViewModel report);

        Task<bool> RemoveReportClassUP(string id);
        Task<bool> RemoveListReportClassUP(List<Guid> listIdreport);

        Task<ReportUPViewModel> GetByIdReport(string id);

    }
}
