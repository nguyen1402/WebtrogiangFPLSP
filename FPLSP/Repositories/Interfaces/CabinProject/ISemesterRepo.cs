using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;

namespace FPLSP.Repositories.Interfaces.CabinProject
{
    public interface ISemesterRepo
    {
        Task<List<SemesterDto>> GetAll();
        Task<bool> CreateSemester(SemesterVM semesterVM);
        Task<bool> DeleteSemester(string Id);
        Task<bool> UpdateSemester(SemesterVM semesterVM);
        Task<SemesterVM> GetDetails(string Id);
    }
}
