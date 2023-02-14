using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.StudentCP
{
    public class UpdateStudentCPVm
    {
        [Required(ErrorMessage = "Không được bỏ trống Tên Sinh Viên")]
        public string StudentName { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Mật khẩu")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Số điện thoại")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Địa chỉ")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống CCCD/CMT")]
        public string IdentityCardNumber { get; set; }
        public DateTime IssuedOn { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Dân tộc")]
        public string Ethnic { get; set; }
        [Required(ErrorMessage = "Chưa thêm ảnh")]
        public string ImageUrl { get; set; }
        //
        [Required(ErrorMessage = "Không được bỏ trống Mô tả")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Tên Bố")]
        public string FathersName { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Tên Mẹ")]
        public string MotherName { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Quê quán")]
        public string HomeTown { get; set; }
        public int Status { get; set; }
    }
}
