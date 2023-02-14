using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.StudentsUPVm
{
    public class StudentUPCreateVm : IValidatableObject
    {
        [Required(ErrorMessage = "Không được bỏ trống Tên Sinh Viên")]
        [RegularExpression(@"^\D+$", ErrorMessage = "Không được nhập Số!")]
        public string StudentName { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.Today;
        //[Required(ErrorMessage = "Không được bỏ trống Email")]
        ////[RegularExpression(@"^([\w\.\-]+)@([fpt]+)((\.(\w){2,3})+)$", ErrorMessage = "Hãy nhập đúng định dạng Email của FPT")]
        //[RegularExpression(@"^([\w\.\-]+)@([fpt.edu.vn]+)$", ErrorMessage = "Hãy nhập đúng định dạng Email của FPT")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Không được bỏ trống Mật khẩu")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Số điện thoại")]
        [RegularExpression(@"((09|03|07|08|05)+([0-9]{8})\b)", ErrorMessage = "Hãy nhập đúng định dạng Số điện thoại")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Địa chỉ")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống CCCD/CMT")]
        [RegularExpression(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$", ErrorMessage = "Hãy nhập đúng định dạng Số CMND/CMT")]
        public string IdentityCardNumber { get; set; }
        public DateTime IssuedOn { get; set; } = DateTime.Today;
        [Required(ErrorMessage = "Không được bỏ trống Dân tộc")]
        [RegularExpression(@"^\D+$", ErrorMessage = "Không được nhập Số!")]
        public string Ethnic { get; set; }
        [Required(ErrorMessage = "Chưa thêm ảnh")]
        [RegularExpression(@"[^\'""<>]+?\.(jpg|jpeg|gif|png)", ErrorMessage = "Nhập đúng File Ảnh!")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Mô tả")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Tên Bố")]
        [RegularExpression(@"^\D+$", ErrorMessage = "Không được nhập Số!")]
        public string FathersName { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Tên Mẹ")]
        [RegularExpression(@"^\D+$", ErrorMessage = "Không được nhập Số!")]
        public string MotherName { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Quê quán")]
        public string HomeTown { get; set; }
        public int Status { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            var property = new[] { "PhoneNumber" };
            var property2 = new[] { "IdentityCardNumber" };
            var property3 = new[] { "DateOfBirth" };
            var property4 = new[] { "IssuedOn" };
           // var property5 = new[] { "Password" };
            int b = PhoneNumber.Length;
            if (b != 10)
            {
                yield return new ValidationResult("Hãy Nhập đúng số điện thoại!", property);
            }
            int a = IdentityCardNumber.Length;
            if (a != 9 && a != 12)
            {
                yield return new ValidationResult("CMT có 9 số, CCCD có 12 số", property2);
            }
            var temp1 = DateTime.Now;
            var c = temp1.Year - DateOfBirth.Year;
            if (c < 18)
            {
                yield return new ValidationResult("Hãy xem lại ngày sinh!", property3);
            }
            var d = IssuedOn.Year - DateOfBirth.Year;
            if (d < 14 && IssuedOn < DateTime.Now)
            {
                yield return new ValidationResult("Hãy xem lại ngày Cấp CMT/CCCD!", property4);
            }
            //var temp = Password.Length;
            //if (temp < 8)
            //{
            //    yield return new ValidationResult("Password phải từ 8 ký tự trở lên!", property5);
            //}

        }
    }
}
