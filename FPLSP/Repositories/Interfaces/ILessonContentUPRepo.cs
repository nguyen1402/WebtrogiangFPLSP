using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.ViewModels.LessonContentUP;

namespace FPLSP.Repositories.Interfaces
{
    public interface ILessonContentUPRepo
    {
        Task<List<LessonContentUPViewModel>> GetAll(); //Lấy toàn bộ danh sách
        Task<PageList<LessonContentUPViewModel>> GetList(LessonContentUPListSearch search); //Lấy danh sách theo trang
        Task<LessonContentUPViewModel> GetById(string id); //Tìm kiếm đối tượng dựa vào ID
        Task<bool> Create(LessonContentUPCreateRequest request); //Tạo mới và trả về true nếu thành công
        Task<bool> Update(Guid Id, LessonContentUPUpdateRequest request); //Cập nhật và trả về true nếu thành công
        Task<bool> Delete(Guid Id); //Xóa và trả về true nếu thành công
        Task<bool> RemoveAll(List<Guid> listIdSubject);
    }
}
