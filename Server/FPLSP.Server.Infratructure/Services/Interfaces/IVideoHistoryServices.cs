using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.VideoHistoryVm;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IVideoHistoryServices
    {
        Task<IQueryable<VideoHistoryViewModel>> GetAll(); //Lấy toàn bộ danh sách
        Task<PageList<VideoHistoryDto>> ListGetVideo(Guid IdStudent, Guid IdLesson, VideoHistoryListSearch search); //Lấy danh sách theo trang
        Task<VideoHistoryViewModel> GetById(Guid IdStudent, Guid IdLessonContent); //Tìm kiếm đối tượng dựa vào ID
        Task<bool> Create(VideoHistoryCreateRequest request); //Tạo mới và trả về 1 đối tượng vừa tạo
        Task<int> Update(Guid IdStudent, Guid IdLessonContent, VideoHistoryUpdateRequest request); //Cập nhật và trả về số lượng bản ghi bị ảnh hưởng
        Task<bool> UpdateListVideo(List<VideoHistoryDto> listvideo); //Cập nhật và trả về true nếu thành công
        Task<int> Delete(Guid IdStudent, Guid IdLessonContent); //Xóa và trả về số lượng bản ghi bị ảnh hưởng
    }
}
