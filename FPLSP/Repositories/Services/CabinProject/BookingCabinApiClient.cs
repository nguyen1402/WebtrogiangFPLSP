using FPLSP.Repositories.Interfaces.CabinProject;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingCabin;

namespace FPLSP.Repositories.Services.CabinProject
{
    public class BookingCabinApiClient : IBookingCabinApiClient
    {
        private HttpClient _httpClient;

        public BookingCabinApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        /// <summary>
        /// Thêm mới thông tin chọn phòng với đối tượng được truyền vào 
        /// </summary>
        /// <param name="bookingCabinVM">thông tin đối tượng được truyền vào</param>
        /// <returns>Trả về true nếu thành công, false nếu thất bại</returns>
        public async Task<bool> Add(BookingCabinCreateVM bookingCabinVM)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/BookingCabins", bookingCabinVM);
            return result.IsSuccessStatusCode;
        }
        /// <summary>
        /// Xóa phòng được chọn theo id bằng id được truyền vào
        /// </summary>
        /// <param name="IdCabin">id cabin</param>
        /// <param name="SubjectId">id môn học</param>
        /// <param name="ClassId">id lớp học</param>
        /// <param name="IdShift">id ca học</param>
        /// <returns>Trả về true nếu thành công, false nếu thất bại</returns>
        public async Task<bool> Delete(Guid Id, Guid IdCabin, Guid SubjectId, Guid ClassId, Guid IdShift)
        {
            var result = await _httpClient.DeleteAsync($"/api/BookingCabins/{Id}/{IdCabin}/{SubjectId}/{ClassId}/{IdShift}");
            return result.IsSuccessStatusCode;
        }
        /// <summary>
        /// Lấy ra danh sách tất cả cabin được chọn 
        /// </summary>
        /// <returns>Trả về danh sách tất cả cabin được chọn</returns>
        public async Task<List<BookingCabinVM>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<BookingCabinVM>>("/api/BookingCabins/all");
            return result;
        }
        /// <summary>
        /// Lấy ra phòng được chọn theo id bằng id được truyền vào
        /// </summary>
        /// <param name="IdCabin">id cabin</param>
        /// <param name="SubjectId">id môn học</param>
        /// <param name="ClassId">id lớp học</param>
        /// <param name="IdShift">id ca học</param>
        /// <returns>Trả về phòng được chọn theo id bằng id được truyền vào</returns>
        public async Task<BookingCabinVM> GetById(Guid Id, Guid IdCabin, Guid SubjectId, Guid ClassId, Guid IdShift)
        {
            var result = await _httpClient.GetFromJsonAsync<BookingCabinVM>($"/api/BookingCabins/{Id}/{IdCabin}/{SubjectId}/{ClassId}/{IdShift}");
            return result;
        }
        /// <summary>
        /// Lấy danh sách theo keyword search
        /// </summary>
        /// <param name="search">keyword search</param>
        /// <returns>Trả về danh sách cabin được chọn theo keyword search</returns>
        public async Task<PageList<BookingCabinVM>> GetForSearch(BookingCabinSearch search)
        {
            var result = await _httpClient.GetFromJsonAsync<PageList<BookingCabinVM>>("/api/BookingCabins/search");
            return result;
        }
        /// <summary>
        /// Cập nhật phòng được chọn với id bằng id được truyền vào và theo thông tin đối tượng truyền vào
        /// </summary>
        /// <param name="IdCabin">id cabin</param>
        /// <param name="SubjectId">id môn học</param>
        /// <param name="ClassId">id lớp học</param>
        /// <param name="IdShift">id ca dạy</param>
        /// <param name="bookingCabinVM">thông tin đối tượng</param>
        /// <returns>Trả về true nếu thành công, false nếu thất bại</returns>
        public async Task<bool> Update(Guid Id, Guid IdCabin, Guid SubjectId, Guid ClassId, Guid IdShift, BookingCabinUpdateVM bookingCabinVM)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/BookingCabins/{Id}/{IdCabin}/{SubjectId}/{ClassId}/{IdShift}", bookingCabinVM);
            return result.IsSuccessStatusCode;
        }

        public async Task<List<BookingCabinVM>> GetListById(Guid SubjectId, Guid ClassId, Guid IdShift)
        {
            var result = await _httpClient.GetFromJsonAsync<List<BookingCabinVM>>("/api/BookingCabins/all");
            return result.Where(c => c.Status != 1 && c.SubjectId == SubjectId && c.ClassId == ClassId && c.IdShift == IdShift).ToList();
        }

        public async Task<bool> UndoDelete(Guid Id)
        {
            var result = await _httpClient.DeleteAsync($"/api/BookingCabins/{Id}");
            return result.IsSuccessStatusCode;
        }
    }
}
