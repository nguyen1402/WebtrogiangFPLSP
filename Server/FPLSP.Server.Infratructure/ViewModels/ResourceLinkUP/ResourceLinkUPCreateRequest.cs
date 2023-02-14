using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.ResourceLinkUP
{
    public class ResourceLinkUPCreateRequest // Yêu cầu tạo mới ResourceLinkUP
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tiêu đề")]
        [StringLength(50, ErrorMessage = "Độ dài tiêu đề không được vượt quá 50 ký tự")]
        public string ResourcesTitle { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập đường dẫn")]
        [StringLength(500, ErrorMessage = "Độ dài đường dẫn không được vượt quá 500 ký tự")]
        [RegularExpression(@"(?:https?:\/\/)?(?:www\.)?youtu\.?be(?:\.com)?\/?.*(?:watch|embed)?(?:.*v=|v\/|\/)([\w\-_]+)\&?",
         ErrorMessage = "Yêu cầu truyền vào link youtube")]
        public string Path { get; set; }
        [StringLength(100, ErrorMessage = "Độ dài mô tả không được vượt quá 100 ký tự")]
        public string Descriptions { get; set; }
        public int Status { get; set; }
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
