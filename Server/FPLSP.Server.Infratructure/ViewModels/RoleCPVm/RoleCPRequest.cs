using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.RoleCPVm
{
    public class RoleCPRequest
    {
        [Required(ErrorMessage = "Mã chức vụ không được để trống")]
        [StringLength(10, ErrorMessage = "Độ dài mã chức vụ không được vượt quá 10 ký tự")]
        public string RoleCode { get; set; }
        [Required(ErrorMessage = "Trạng thái không được để trống")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Vui lòng nhập trạng thái hợp lệ")]
        public int Status { get; set; }
        [Required(ErrorMessage = "Tên chức vụ không được để trống")]
        [StringLength(30, ErrorMessage = "Độ dài tên chức vụ không được vượt quá 30 ký tự")]
        public string RoleName { get; set; }
    }
}
