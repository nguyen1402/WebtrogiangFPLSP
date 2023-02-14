using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.VideoHistoryVm
{
    public class VideoHistoryUpdateRequest // Yêu cầu cập nhật Video History
    {
        [Required(ErrorMessage = "Vui lòng nhập mốc thời gian xem video")]
        [DataType(DataType.Date, ErrorMessage = "Vui lòng nhập đúng định dạng DateTime")]
        public DateTime TimeOfSaveHistory { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tổng thời gian đã xem video")]
        [DataType(DataType.Date, ErrorMessage = "Vui lòng nhập đúng định dạng DateTime")]
        public DateTime WatchedTime { get; set; }

        [Range(0, 1, ErrorMessage = "Trạng thái không hợp lệ")]
        public bool IsBookMarked { get; set; } = false;

        [Required(ErrorMessage = "Vui lòng nhập trạng thái")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Vui lòng nhập số trạng thái hợp lệ")]
        public int Status { get; set; }
    }
}
