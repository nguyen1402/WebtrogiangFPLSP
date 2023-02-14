using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.Lesson;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Repositories.Interfaces
{
    public interface ILessonCPRepo
    {
        Task<PageList<LessonDto>> GetLessons(Guid Id, LessonListSearch parameters);
        Task<LessonDto> GetbyId(Guid id);
        Task<int> Create(Guid Id, LessonCreateVM lesson);
        Task<int> Update(Guid id, LessonUpdateVM lesson_update);
        Task<int> Delete(Guid id);
        Task<bool> RemoveListLessonCP(List<Guid> listIdSubject);
        Task<List<LessonDto>> GetAll(Guid id);
        Task<List<LessonDto>> GetAllLesson();
    }
}
