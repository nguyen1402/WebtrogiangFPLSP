using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.TrainingFacilitiesCPVm
{
    public class TrainingFacilitiesCPRequest
    {
        [Required(ErrorMessage = "Vui lòng nhập mã cơ sở đào tạo")]
        [StringLength(10, ErrorMessage = "Độ dài mã cơ sở đào tạo không được vượt quá 10 ký tự")]
        public string TrainingFacilitiesCode { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên cơ sở đào tạo")]
        [StringLength(50, ErrorMessage = "Độ dài tên cơ sở đào tạo không được vượt quá 50 ký tự")]
        public string TrainingInstitutionName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập link ảnh")]
        //[RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Only Image files allowed.")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số cơ sở đào tạo")]
        [Range(1, int.MaxValue, ErrorMessage = "Vui lòng nhập số lớn hơn 0")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Vui lòng nhập số cơ sở đào tạo chính xác")]
        public int TrainingInstitution { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trạng thái")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Vui lòng nhập trạng thái hợp lệ")]
        public int Status { get; set; }
    }
}
