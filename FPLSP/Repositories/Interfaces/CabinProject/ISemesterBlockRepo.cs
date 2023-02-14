using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;

namespace FPLSP.Repositories.Interfaces.CabinProject
{
    public interface ISemesterBlockRepo
    {
        Task<List<SemesterBlockDto>> GetAll();
        Task<SemesterBlockVM> GetById(string IdBlock, string IdSemester);
        Task<bool> CreateSemesterBlock(SemesterBlockVM semester);
        Task<bool> DeleteSemesterBlock(string IdBlock, string IdSemester);
        Task<bool> UpdateSemesterBlock(SemesterBlockVM semester);
        Task<PageList<SemesterBlockDto>> GetPageList(SemesterBlockSearch semesterBlockSearch);
    }
}
