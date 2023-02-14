using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.ReportClassUP;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IReportClassUPServices
    {
        Task<PageList<ReportUPDto>> GetPagingReportUPDto(Guid classUPId, ReportClassUpSearch repositoryParameters);
        Task<IQueryable<ReportUPDto>> GetListReportClassUP();

        Task<bool> CreateReportClassUP(ReportUPViewModel report);

        Task<bool> UpdateReportClassUP(ReportUPViewModel report);

        Task<bool> RemoveReportClassUP(Guid id);
        Task<bool> RemoveListReportClassUP(List<Guid> listIdReport);

        Task<ReportUPViewModel> GetByIdReport(Guid id);

        public Task<bool> RestoreReportClassUP(Guid id);
    }
}
