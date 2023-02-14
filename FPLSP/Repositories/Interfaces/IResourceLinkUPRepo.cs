using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.ResourceLinkUP;

namespace FPLSP.Repositories.Interfaces
{
    public interface IResourceLinkUPRepo
    {
        Task<List<ResourceLinkUPViewModel>> GetAll(); //Lấy toàn bộ danh sách
        Task<PageList<ResourceLinkUPDto>> GetList(ResourceLinkUPListSearch search); //Lấy danh sách theo trang
        Task<ResourceLinkUPViewModel> GetById(string id); //Tìm kiếm đối tượng dựa vào ID
        Task<bool> Create(ResourceLinkUPCreateRequest request); //Tạo mới và trả về true nếu thành công
        Task<bool> Update(Guid Id, ResourceLinkUPViewModel request); //Cập nhật và trả về true nếu thành công
        Task<bool> Delete(Guid Id); //Xóa và trả về true nếu thành công
        Task<bool> DeleteList(int method, List<Guid> listIdLink); //Xóa 1 list 
    }
}
