using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.LessonContentCP;

namespace FPLSP.Repositories.Interfaces
{
    public interface ILessonContentCPRepo
    {
        Task<PageList<LessonContentDto>> GetLessons(Guid Id, LessonContentListSearch parameters);
        Task<LessonContentUpdateVM> GetbyId(Guid id);
        Task<int> Create(Guid Id, LessonContentCreateVM creat);
        Task<int> Update(Guid id, LessonContentUpdateVM update);
        Task<int> Delete(Guid id);
        Task<List<LessonContentDto>> GetAll(Guid? id);
        Task<List<LessonContentDto>> GetAllLessonContent();

        Task<bool> RemoveListLessonContentCP(List<Guid> listIdlessoncontent);
    }
}
