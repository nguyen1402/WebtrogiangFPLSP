using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.VideoHistoryVm;

namespace FPLSP.Repositories.Interfaces
{
    public interface IVideoHistoryRepo
    {
        Task<List<VideoHistoryViewModel>> GetAll(); //Lấy toàn bộ danh sách
        Task<PageList<VideoHistoryDto>> GetListLink(Guid IdStudent, Guid IdLesson, VideoHistoryListSearch search); //Lấy danh sách theo trang
        Task<VideoHistoryViewModel> GetById(string IdStudent, string IdLessonContent); //Tìm kiếm đối tượng dựa vào ID
        Task<bool> Create(VideoHistoryCreateRequest request); //Tạo mới và trả về true nếu thành công
        Task<bool> Update(Guid IdStudent, Guid IdLessonContent, VideoHistoryUpdateRequest request); //Cập nhật và trả về true nếu thành công
        Task<bool> UpdateListVideo(List<VideoHistoryDto> listvideo); //Cập nhật và trả về true nếu thành công
        Task<bool> Delete(Guid IdStudent, Guid IdLessonContent); //Xóa và trả về true nếu thành công
    }
}
