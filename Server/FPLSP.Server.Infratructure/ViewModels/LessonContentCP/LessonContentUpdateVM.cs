using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.LessonContentCP
{
    public class LessonContentUpdateVM
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống tên nội dung bài học")]
        public string LessonContentName { get; set; }
        public string LessonContentCode { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống nội dung bài học")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống mô tả nội dung bài học")]
        public string Descriptions { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống link nội dung bài học")]
        public string Path { get; set; }
        public int Status { get; set; }
        public int Index { get; set; }
        public string PathId()
        {
            if (Path == null)
            {
                return null;
            }
            var videoID = Path.Replace("https://www.youtube.com/embed/", "");
            videoID = videoID.Replace("https://www.youtube.com/watch?v=", "");
            videoID = videoID.Replace("https://youtu.be/", "");

            return videoID;
        }
    }
}
