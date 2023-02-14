using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels
{
    public class LecturersCPViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Lecturer Code Mustn't Be Blank")]
        [StringLength(10, ErrorMessage = "Độ dài mã giảng viên không được vượt quá 10 ký tự")]
        public string LecturersCode { get; set; }
        [Required(ErrorMessage = "Lecturer Name Mustn't Be Blank")]
        [StringLength(50, ErrorMessage = "Độ dài tên giảng viên không được vượt quá 50 ký tự")]
        public string LecturersName { get; set; }
        [Required(ErrorMessage = "Gender Mustn't Be Blank")]
        public bool Gender { get; set; }
        [Required(ErrorMessage = "Date Of Birth Mustn't Be Blank")]
        public DateTime Dob { get; set; }
        //[StringLength(250, ErrorMessage = "Độ dài email không được vượt quá 250 ký tự")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phonenumber Mustn't Be Blank")]
        [StringLength(10, ErrorMessage = "Độ dài số điện thoại không được vượt quá 10 ký tự")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Address Mustn't Be Blank")]
        [StringLength(100, ErrorMessage = "Độ dài địa chỉ không được vượt quá 100 ký tự")]
        public string Address { get; set; }
        [Required(ErrorMessage = "IdentityCard Mustn't Be Blank")]      
        public string IdentityCard { get; set; }
        [Required(ErrorMessage = "IssuedOn Mustn't Be Blank")]
        public DateTime IssuedOn { get; set; }
        [Required(ErrorMessage = "Ethnic Mustn't Be Blank")]
        [StringLength(20, ErrorMessage = "Độ dài tôn giáo không được vượt quá 20 ký tự")]
        public string Ethnic { get; set; }
        [Required(ErrorMessage = "ImageUrl Mustn't Be Blank")]
        //[RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Vui lòng nhập đúng định dạng ảnh")]
        [StringLength(100, ErrorMessage = "Độ dài link ảnh không được vượt quá 100 ký tự")]
        public string ImageUrl { get; set; }
        //
        [Required(ErrorMessage = "Years Of Experience Mustn't Be Blank")]
        //[RegularExpression("([0-9]+)", ErrorMessage = "Vui lòng nhập số năm kinh nghiệm hợp lệ")]
        public int YearsOfExperience { get; set; }

        [Required(ErrorMessage = "HomeTown Mustn't Be Blank")]
        [StringLength(100, ErrorMessage = "Độ dài quê quán không được vượt quá 100 ký tự")]
        public string HomeTown { get; set; }
        [Required(ErrorMessage = "Description Mustn't Be Blank")]
        [StringLength(100, ErrorMessage = "Độ dài mô tả không được vượt quá 100 ký tự")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Status Mustn't Be Blank")]
        //[RegularExpression("([0-9]+)", ErrorMessage = "Vui lòng nhập số trạng thái hợp lệ")]
        public int Status { get; set; }

        public Guid? idspec { get; set; }

        public string namechuyennganh { get; set; }
        //chức vụ
        [Required(ErrorMessage = "Role Mustn't Be Blank")]
        public Guid? RoleId { get; set; }

        //cơ sở đào tạo
        [Required(ErrorMessage = "Training Facility Mustn't Be Blank")]
        public Guid? TrainingFacilitiesId { get; set; }
        public List<Guid> ListSpecialized { get; set; }
        public bool IsChecked { get; set; } = false;
    }
}
