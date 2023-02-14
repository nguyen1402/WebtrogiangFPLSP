using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop
{
    public class SubjectClassVM : IValidatableObject
    {
        public Guid ClassId { get; set; }
        public Guid? SubjectId { get; set; }
        public string? JoinCode { get; set; }

        public Guid HomeroomLecturer { get; set; }
        public Guid SpecializedOfClass { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống Tên Lớp")]
        public string ClassroomName { get; set; }// tên lớp học 

        //[Required(ErrorMessage = "Không được bỏ trống Mã Lớp")]
        //public string ClassroomCode { get; set; }// mã lớp học 

        [Required(ErrorMessage = "Không được bỏ trống Tòa Nhà")]
        public string Building { get; set; }// Tòa Nhà 


        [Range(30, 50, ErrorMessage = "Số lượng sinh viên từ 30 đến 50 !")]
        public int StudentAmount { get; set; } // số lượng sinh viên 

        public int StatusClass { get; set; }// trạng thái 
        public int StatusSubjectClass { get; set; }// trạng thái 
        public DateTime DateCreated { get; set; }
        [DataType(DataType.DateTime, ErrorMessage = "Nhập đúng định dạng thời gian")]
        public DateTime DateStarted { get; set; } = DateTime.Now;
        [DataType(DataType.DateTime, ErrorMessage = "Nhập đúng định dạng thời gian")]
        public DateTime EndDate { get; set; } = DateTime.Now;


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
