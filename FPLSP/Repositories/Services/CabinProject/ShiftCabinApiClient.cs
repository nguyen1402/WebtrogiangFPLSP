using FPLSP.Repositories.Interfaces.CabinProject;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.ShiftOfCabin;

namespace FPLSP.Repositories.Services.CabinProject
{
    public class ShiftCabinApiClient : IShiftOfCabinApiClient
    {
        private HttpClient _httpClient;

        public ShiftCabinApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        /// <summary>
        /// Thêm mới Ca dạy theo thông tin đối tượng được truyền vào
        /// </summary>
        /// <param name="shiftOfCabinVM">thông tin đối tượng được truyền vào</param>
        /// <returns>Trả về true nếu thêm mới thành công,false nếu thất bại</returns>
        public async Task<bool> Add(ShiftOfCabinCreateVM shiftOfCabinVM)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/ShiftOfCabins", shiftOfCabinVM);
            return result.IsSuccessStatusCode;
        }
        /// <summary>
        /// Xóa Ca theo id bằng id được truyền vào
        /// </summary>
        /// <param name="Id">id Ca</param>
        /// <returns>Trả về true nếu thành công, false nếu thất bại </returns>
        public async Task<bool> Delete(Guid Id)
        {
            var result = await _httpClient.DeleteAsync($"/api/ShiftOfCabins{Id}");
            return result.IsSuccessStatusCode;
        }
        /// <summary>
        /// Lấy ra danh sách tất cả Ca dạy
        /// </summary>
        /// <returns>Trả về danh sách tất cả ca dạy</returns>
        public async Task<List<ShiftOfCabinVM>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<ShiftOfCabinVM>>("/api/ShiftOfCabins/all");
            return result;
        }

        public async Task<List<ShiftOfCabinFullVM>> GetAllInformationOfShiftOfCabin()
        {
            var result = await _httpClient.GetFromJsonAsync<List<ShiftOfCabinFullVM>>("/api/ShiftOfCabins/allForDashboard");
            if (result == null)
            {
                return new List<ShiftOfCabinFullVM>();
            }
            return result;
        }

        public async Task<List<ShiftOfCabinFullVM>> GetAllInformationOfShiftOfCabinIsNotDeleted()
        {
            var result = await _httpClient.GetFromJsonAsync<List<ShiftOfCabinFullVM>>("/api/ShiftOfCabins/allNotDeletedForDashboard");
            return result;
        }

        /// <summary>
        /// Lấy ra ca dạy có id bằng id được truyền vào
        /// </summary>
        /// <param name="Id">id ca dạy</param>
        /// <returns>Trả về ca dạy có id bằng id được truyền vào</returns>
        public async Task<ShiftOfCabinVM> GetById(Guid Id)
        {
            var result = await _httpClient.GetFromJsonAsync<ShiftOfCabinVM>($"/api/ShiftOfCabins/{Id}");
            return result;
        }
        /// <summary>
        /// Lấy ra danh sách ca dạy theo keyword search
        /// </summary>
        /// <param name="search">keyword search</param>
        /// <returns>rả về danh sách ca dạy theo keyword search</returns>
        public async Task<PageList<ShiftOfCabinVM>> GetForSearch(ShiftOfCabinSearch search)
        {
            var result = await _httpClient.GetFromJsonAsync<PageList<ShiftOfCabinVM>>("/api/ShiftOfCabins/search");
            return result;
        }/// <summary>
        /// Cập nhật ca dạy với id bằng id được truyền vào và theo thông tin đói tượng được truền vào
        /// </summary>
        /// <param name="Id">id ca dạy</param>
        /// <param name="shiftOfCabinVM">thông tin đối tượng</param>
        /// <returns>Trả về true nếu thành công, false nếu thất bại</returns>

        public async Task<bool> Update(Guid Id, ShiftOfCabinUpdateVM shiftOfCabinVM)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/ShiftOfCabins/{Id}", shiftOfCabinVM);
            return result.IsSuccessStatusCode;
        }
    }
}
