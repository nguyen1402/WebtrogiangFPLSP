using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Dtos.DashboardDtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.Specialized;

namespace FPLSP.Server.Infrastructure.Services.Interfaces;

public interface IDashboardService
{
    public Task<int> GetAllLectureNotUser(Guid idTran);
    public Task<int> GetAllStudentUPNotUser();
    public Task<List<TrainingFacilitiesForDashBoardDto>> GetAllDashBoard();
    Task<PageList<SpecializedDto>> GetAllSpecByIdTran(Guid idTran, SpecializedListSearch specializedParameters);
    Task<int> GetAllSpec();
}