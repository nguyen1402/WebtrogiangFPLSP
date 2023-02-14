using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.LessonUP;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface ILessonUPServices
    {
        Task<IQueryable<LessonUPViewModel>> GetAll(); //Lấy toàn bộ danh sách
        Task<PageList<LessonUPViewModel>> GetLessonUPs(LessonUPListSearch search); //Lấy danh sách theo trang
        Task<LessonUPViewModel> GetById(Guid id); //Tìm kiếm đối tượng dựa vào ID
        Task<LessonUPViewModel> Create(LessonUPCreateRequest request); //Tạo mới và trả về 1 đối tượng vừa tạo
        Task<int> Update(Guid id, LessonUPUpdateRequest request); //Cập nhật và trả về số lượng bản ghi bị ảnh hưởng
        Task<int> Delete(Guid id); //Xóa và trả về số lượng bản ghi bị ảnh hưởng
        Task<bool> RemoveListLessonUP(List<Guid> listIdLesson);
        Task<IQueryable<LessonContentCP>> GetAllLessonContentCP();
        Task<IQueryable<LessonCP>> GetAllLessonCP();
        Task<IQueryable<ResourceLink>> GetAllResourceLinkCP();
    }
}
