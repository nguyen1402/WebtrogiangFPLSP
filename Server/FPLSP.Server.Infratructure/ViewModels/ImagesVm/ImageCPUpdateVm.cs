using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.ImagesCP
{
    public class ImageCPUpdateVm
    {
        public Guid CoeId { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống đường dẫn")]
        public string Path { get; set; }
        public string Descriptions { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống trạng thái")]
        public int Status { get; set; }
    }
}
