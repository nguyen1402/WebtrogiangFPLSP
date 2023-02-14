using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.LessonUP
{
    public class LessonUPUpdateRequest // Yêu cầu cập nhật LessonUP
    {
        [Required(ErrorMessage = "Vui lòng nhập tên bài học")]
        [StringLength(100, ErrorMessage = "Độ dài tên bài học không được vượt quá 100 ký tự")]
        public string LessonName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mã bài học")]
        [StringLength(10, ErrorMessage = "Độ dài mã bài học không được vượt quá 10 ký tự")]
        public string LessonCode { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mô tả bài học")]
        [StringLength(100, ErrorMessage = "Độ dài mô tả bài học không được vượt quá 100 ký tự")]
        public string Descriptions { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn trạng thái hoàn thành")]
        [Range(0, 1, ErrorMessage = "Trạng thái không hợp lệ")]
        public bool IsCompleted { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trạng thái")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Vui lòng nhập số trạng thái hợp lệ")]
        public int Status { get; set; }
        public Guid? SubjectId { get; set; }
    }
}
