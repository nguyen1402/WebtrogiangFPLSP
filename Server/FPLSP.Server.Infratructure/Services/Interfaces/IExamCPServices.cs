using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.Exams;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IExamCPServices
    {
        Task<PageList<ExamCP>> GetExamCPList(ExamListSearchVm ExamListSearchVm);
        Task<List<ExamCPDto>> GetAllExamCPList();
        Task<PageList<ExamCP>> GetExamCPListBySubjectId(Guid SubjectId, ExamListSearchVm ExamListSearchVm);
        Task<ExamCP> CreateExamCP(ExamCP ExamCP);
        Task<ExamCP> UpdateExamCP(Guid id, ExamUpdateVm ExamUpdateVm);
        Task<ExamCP> DeleteExamCP(Guid id);

        Task<ExamCP> GetExamCPById(Guid ExamId);
    }
}
