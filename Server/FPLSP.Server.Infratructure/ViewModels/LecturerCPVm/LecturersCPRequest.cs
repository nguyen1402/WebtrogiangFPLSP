using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.LecturerCPVm
{
    public class LecturersCPRequest
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Mã giảng viên không được để trống")]
        [StringLength(10, ErrorMessage = "Độ dài mã giảng viên không được vượt quá 10 ký tự")]
        public string LecturersCode { get; set; }
        [Required(ErrorMessage = "Tên giảng viên không được để trống")]
        [StringLength(50, ErrorMessage = "Độ dài tên giảng viên không được vượt quá 50 ký tự")]
        public string LecturersName { get; set; }
        [Required(ErrorMessage = "Giới tính không được để trống")]
        public bool Gender { get; set; }
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        [DataType(DataType.Date, ErrorMessage = "Ngày sinh không đúng định dạng")]
        public DateTime Dob { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [StringLength(10, ErrorMessage = "Độ dài số điện thoại không được vượt quá 10 ký tự")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(100, ErrorMessage = "Độ dài địa chỉ không được vượt quá 100 ký tự")]
        public string Address { get; set; }
        [Required(ErrorMessage = "CMT/CCCD không được để trống")]
        [StringLength(12, ErrorMessage = "Độ dài CMT/CCCD không được vượt quá 12 ký tự")]
        public string IdentityCard { get; set; }
        [Required(ErrorMessage = "Ngày cấp không được để trống")]
        [DataType(DataType.Date, ErrorMessage = "Ngày cấp không đúng định dạng")]
        public DateTime IssuedOn { get; set; }
        [Required(ErrorMessage = "Dân tộc không được để trống")]
        [StringLength(20, ErrorMessage = "Độ dài dân tộc không được vượt quá 20 ký tự")]
        public string Ethnic { get; set; }
        [Required(ErrorMessage = "Ảnh không được để trống")]
        //[RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Vui lòng nhập đúng định dạng ảnh")]
        [StringLength(100, ErrorMessage = "Độ dài link ảnh không được vượt quá 100 ký tự")]
        public string ImageUrl { get; set; }
        //
        [Required(ErrorMessage = "Năm kinh nghiệm không được để trống")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Vui lòng nhập số năm kinh nghiệm hợp lệ")]
        public int YearsOfExperience { get; set; }

        [Required(ErrorMessage = "Quê quán không được để trống")]
        [StringLength(100, ErrorMessage = "Độ dài quê quán không được vượt quá 100 ký tự")]
        public string HomeTown { get; set; }
        [Required(ErrorMessage = "Mô tả không được để trống")]
        [StringLength(100, ErrorMessage = "Độ dài mô tả không được vượt quá 100 ký tự")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Trạng thái không được để trống")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Vui lòng nhập số trạng thái hợp lệ")]
        public int Status { get; set; }
        //chức vụ
        //[Required(ErrorMessage = "Chức vụ không được để trống")]
        public Guid? RoleId { get; set; }

        //cơ sở đào tạo
        [Required(ErrorMessage = "Cơ sở không được để trống")]
        public Guid TrainingFacilitiesId { get; set; }
        public List<Guid>? ListSpecialized { get; set; }
    }
}
