using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;

namespace FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam
{
    public interface IExamFileServices
    {
        Task<bool> AddMultipleExamFile(List<ExamStorageViewModel> examStorageViewModels);
        Task<List<ExamStorage>> GetAllExamFiles();
        Task<PageList<ExamStorageViewModel>> GetFileForPaging(ExamFileSearch examFileSearch);
        Task<bool> DeleteExamFile(Guid IdExamFile);
        Task<bool> UpdateExamFile(ExamStorageViewModel examStorageViewModel);
        Task<List<ExamStorage>> GetAllExamFilesForLectuterSubject(Guid Idlec, Guid IdSubject);
        Task<List<ExamStorage>> GetAllExamFilesForOnlySubject(Guid IdSubject);
        Task<List<ExamStorage>> GetAllExamFilesForLectuer(Guid IdLecturter);
        Task<bool> QuickChangeExamFile(Guid Id, int status);
        Task<bool> UpdateFastExamFile(Guid idExam);
        Task<List<ExamStorage>> GetAllExamFilesBySubjectId(Guid IdSubject);
    }
}
