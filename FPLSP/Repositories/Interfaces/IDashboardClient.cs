using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Dtos.DashboardDtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.Specialized;

namespace FPLSP.Repositories.Interfaces
{
    public interface IDashboardClient
    {
        Task<int> GetAllStudentUPNotUser();
        Task<int> GetAllLectureNotUser(Guid idTran);
        Task<int> GetAllSpec();


        Task<List<TrainingFacilitiesForDashBoardDto>> GetInforTraningFacilitiesForDashboard();
        Task<PageList<SpecializedDto>> GetAllSpecByIdTran(Guid idTran, SpecializedListSearch parameters);
    }
}
