using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.LessonUP;

namespace FPLSP.Repositories.Interfaces
{
    public interface ILessonUPRepo
    {
        Task<List<LessonUPViewModel>> GetAll(); //Lấy toàn bộ danh sách
        Task<PageList<LessonUPViewModel>> GetList(LessonUPListSearch search); //Lấy danh sách theo trang
        Task<LessonUPViewModel> GetById(string id); //Tìm kiếm đối tượng dựa vào ID
        Task<bool> Create(LessonUPCreateRequest request); //Tạo mới và trả về true nếu thành công
        Task<bool> Update(Guid Id, LessonUPUpdateRequest request); //Cập nhật và trả về true nếu thành công
        Task<bool> Delete(Guid Id); //Xóa và trả về true nếu thành công

        Task<List<LessonContentCP>> GetAllLessonContentCP();
        Task<List<LessonCP>> GetAllLessonCP();
        Task<bool> RemoveListLessonUP(List<Guid> listIdSubject);
        Task<List<ResourceLink>> GetAllResourceLinkCP();
    }
}
