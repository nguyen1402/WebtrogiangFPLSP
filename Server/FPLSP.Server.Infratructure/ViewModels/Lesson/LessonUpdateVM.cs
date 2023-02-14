using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.Lesson
{
    public class LessonUpdateVM
    {
        public int Status { get; set; }
        public int Index { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống tên môn học")]
        public string LessonName { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống mô tả môn học")]
        public string Descriptions { get; set; }
    }
}
