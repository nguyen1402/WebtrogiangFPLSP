using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.LessonContentUP
{
    public class LessonContentUPUpdateRequest // Yêu cầu cập nhật LessonContentUP
    {
        public string Content { get; set; }
        [StringLength(500, ErrorMessage = "Độ dài mô tả nội dung bài học không được vượt quá 500 ký tự")]
        public string Descriptions { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mã nội dung bài học")]
        [StringLength(10, ErrorMessage = "Độ dài mã nội dung bài học không được vượt quá 10 ký tự")]
        public string LessonContentCode { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên nội dung bài học")]
        [StringLength(50, ErrorMessage = "Độ dài tên nội dung bài học không được vượt quá 50 ký tự")]
        public string LessonContentName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trạng thái")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Vui lòng nhập số trạng thái hợp lệ")]
        public int Status { get; set; }
        public Guid? LessonId { get; set; }
        public Guid? ResuorceLinkId { get; set; }
    }
}
