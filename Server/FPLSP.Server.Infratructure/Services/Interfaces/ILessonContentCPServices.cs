using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.LessonContentCP;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface ILessonContentCPServices
    {
        Task<PageList<LessonContentDto>> GetPagingParamets(Guid lessonId, LessonContentListSearch parameters);
        Task<LessonContentUpdateVM> GetbyId(Guid id);
        Task<List<LessonContentDto>> GetAllAsync(Guid lessonId);
        Task<List<LessonContentDto>> GetAllLessonContent();
        Task<int> Create(Guid lessonId, LessonContentCreateVM lesson);
        Task<int> Update(Guid id, LessonContentUpdateVM lesson_update);
        Task<int> Delete(Guid id);
        Task<bool> RemoveListLessonContentCP(List<Guid> listIdLesson);
    }
}
