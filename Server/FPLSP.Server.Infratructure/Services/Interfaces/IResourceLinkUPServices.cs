using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.ResourceLinkUP;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IResourceLinkUPServices
    {
        Task<IQueryable<ResourceLinkUPViewModel>> GetAll(); //Lấy toàn bộ danh sách
        Task<PageList<ResourceLinkUPDto>> GetResourceLinkUPs(ResourceLinkUPListSearch search); //Lấy danh sách theo trang
        Task<ResourceLinkUPViewModel> GetById(Guid id); //Tìm kiếm đối tượng dựa vào ID
        Task<ResourceLinkUPViewModel> Create(ResourceLinkUPCreateRequest request); //Tạo mới và trả về 1 đối tượng vừa tạo
        Task<int> Update(Guid id, ResourceLinkUPViewModel request); //Cập nhật và trả về số lượng bản ghi bị ảnh hưởng
        Task<int> Delete(Guid id); //Xóa và trả về số lượng bản ghi bị ảnh hưởng
        Task<bool> DeleteList(List<Guid> listIdLink, int method); //Xóa 1 list
    }
}
