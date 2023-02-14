using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.Exams;

namespace FPLSP.Repositories.Interfaces
{
    public interface IExamCPServicesRepo
    {
        Task<PageList<ExamCPDto>> GetExamCPList(ExamListSearchVm ExamListSearchVm);
        Task<List<ExamCPDto>> GetAllExamCPListAsync();
        Task<PageList<ExamCPDto>> GetExamCPListBySubjectId(Guid SubjectId, ExamListSearchVm ExamListSearchVm);
        Task<ExamCP> GetExamCPById(Guid ExamId);
        Task<bool> CreateExamCP(ExamCreateVm ExamCP);
        Task<bool> UpdateExamCP(Guid id, ExamUpdateVm ExamUpdateVm);
        Task<bool> DeleteExamCP(Guid id);
    }
}
