using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.Lesson;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface ILessonCPServices
    {
        Task<PageList<LessonDto>> GetLessons(Guid subjectId, LessonListSearch parameters);
        Task<LessonDto> GetbyId(Guid id);
        Task<List<LessonDto>> GetAllAsync(Guid subjectId);
        Task<List<LessonDto>> GetAllLesson();
        Task<int> CreateLesson(Guid subjectId, LessonCreateVM lesson);
        Task<int> UpdateLesson(Guid id, LessonUpdateVM lesson_update);
        Task<int> DeleteLesson(Guid id);
        Task<bool> RemoveListLessonCP(List<Guid> listIdLesson);
    }
}
