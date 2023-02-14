using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.Specialized
{
    public class SpecializedVM
    {
        //[Required(ErrorMessage = "Mã không được để trống")]
        //[RegularExpression(@"^\S*$", ErrorMessage = "Mã không được có khoảng trắng")]
        public Guid Id { get; set; }
        public string? SpecializedCode { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(50, ErrorMessage = "Độ dài tên không được vượt quá 50 ký tự")]
        public string SpecializationName { get; set; }
        [Required(ErrorMessage = "Trạng thái không được để trống")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Vui lòng nhập trạng thái hợp lệ")]
        public int Status { get; set; }
        [Required(ErrorMessage = "Ảnh không được để trống")]
        public string Image { get; set; }
    }
}
