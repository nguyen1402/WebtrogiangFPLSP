using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.ResourceLink
{
    public class ResourceLinkCreateVM
    {
        [Required(ErrorMessage = "Không được bỏ trống link bài học")]
        public string Path { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống mô tả")]
        public string Descriptions { get; set; }

        public string ResourcesTitle { get; set; }
        [Required(ErrorMessage = "Bắt buộc phải chọn môn")]
        public Guid IdSubject { get; set; }
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
            //videoID = videoID.Substring(0, 11);

            return videoID;
        }
    }
}
