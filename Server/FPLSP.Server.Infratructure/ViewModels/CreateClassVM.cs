using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels
{
    public class CreateClassVM : IValidatableObject
    {
        public Guid Id { get; set; }
        //[Required(ErrorMessage = "Class Name Mustn't Be Blank")]
        //[RegularExpression(@"^[A-Z''-'\d/s/]{1,10}$",
        // ErrorMessage = "Invalid ClassroomName")]
        [Required(ErrorMessage = "Không được bỏ trống Tên Lớp")]
        public string ClassroomName { get; set; }// tên lớp học 

        [Required(ErrorMessage = "Không được bỏ trống Mã Lớp")]
        [RegularExpression(@"^FPT\d{1,7}$",
         ErrorMessage = "Mã lớp không hợp lệ. Cấu trúc: FPT<số>")]
        public string ClassroomCode { get; set; }// mã lớp học 

        //[RegularExpression(@"^[A-Z''-'/s/]",
        // ErrorMessage = "Place Address Invalid")]
        //[Required(ErrorMessage = "Không được bỏ trống Tòa Nhà")]
        public string Building { get; set; }// địa chỉ

        [Range(30, 50, ErrorMessage = "Số lượng sinh viên từ 30 đến 50 !")]
        public int StudentAmount { get; set; } = 0;

        public int Status { get; set; }// trạng thái 
        //
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateStarted { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;

        public string SubjectName { get; set; }

        public Guid HomeroomLecturerId { get; set; }

        public int ActualNumberOfStudent { get; set; }

        public string HomeroomLecturer { get; set; }

        public string SpecializedName { get; set; }


        public List<Guid?> subjectUP { get; set; }
        [Required()]
        public string JoinCode { get; set; }
        //Các bảng liên đới để truy vấn hiển thị ra lớp học

        public Guid? SubjectId { get; set; }
        public Guid? lecturersCPId { get; set; }
        public Guid? specializedUPId { get; set; }
        public List<Guid?> ListStudent { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var property = new[] { "EndDate" };
            TimeSpan date = EndDate - DateStarted;
            if (EndDate <= DateStarted)
            {
                yield return new ValidationResult("Ngày kết thúc phải lớn hơn ngày bắt đầu", property);
            }
        }
    }
}