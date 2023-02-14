using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.ViewModels.LessonContentUP;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface ILessonContentUPServices
    {
        Task<IQueryable<LessonContentUPViewModel>> GetAll(); //Lấy toàn bộ danh sách
        Task<PageList<LessonContentUPViewModel>> GetLessonContentUPs(LessonContentUPListSearch search); //Lấy danh sách theo trang
        Task<LessonContentUPViewModel> GetById(Guid id); //Tìm kiếm đối tượng dựa vào ID
        Task<LessonContentUPViewModel> Create(LessonContentUPCreateRequest request); //Tạo mới và trả về 1 đối tượng vừa tạo
        Task<int> Update(Guid id, LessonContentUPUpdateRequest request); //Cập nhật và trả về số lượng bản ghi bị ảnh hưởng
        Task<int> Delete(Guid id); //Xóa và trả về số lượng bản ghi bị ảnh hưởng
        Task<bool> RemoveAll(List<Guid> lstLesson);
    }
}
