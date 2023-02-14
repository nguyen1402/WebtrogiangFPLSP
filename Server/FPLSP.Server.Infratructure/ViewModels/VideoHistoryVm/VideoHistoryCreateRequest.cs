using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.VideoHistoryVm
{
    public class VideoHistoryCreateRequest // Yêu cầu tạo mới VideoHistory
    {

        [Range(0, 1, ErrorMessage = "Trạng thái không hợp lệ")]
        public bool IsBookMarked { get; set; } = false;

        [Required(ErrorMessage = "Vui lòng nhập trạng thái")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Vui lòng nhập số trạng thái hợp lệ")]
        public int Status { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ID StudentUP")]
        public Guid IdStudent { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ID LessonContentUP")]
        public Guid IdLessonContent { get; set; }
    }
}
