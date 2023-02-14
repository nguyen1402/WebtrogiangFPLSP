using FPLSP.Server.Domain.Dtos.QuizCPDtos;
using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Domain.Dtos
{
    public class SubjectDto : IValidatableObject
    {
        public Guid Id { get; set; }
        //public Guid? Idspec { get; set; }

        public string SubjectCode { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Tên Môn")]
        public string SubjectName { get; set; }
        public int TotalOfSub { get; set; }
        public int Soluongdethi { get; set; }
        public DateTime CreatedDay { get; set; }
        [Required]
        public DateTime StartDay { get; set; } = DateTime.Now;
        [Required]
        public DateTime EndDay { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Bạn chưa chọn ảnh")]
        [RegularExpression("(https?:\\/\\/.*\\.(?:png|jpg))", ErrorMessage = "Bạn chưa chọn ảnh")]
        public string Image { get; set; }
        public int Status { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDemo { get; set; }
        public int countLesson { get; set; }
        public int countQuiz { get; set; }
        //public List<string> chuyennganh { get; set; }
        //public List<LessonDto> listlesson { get; set; }
        //public List<SubjectQuizCPDtos> listquizs { get; set; }
        public bool IsChecked { get; set; } = false;
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var property = new[] { "EndDay" };
            var total = new[] { "TotalOfSub" };
            var image = new[] { "Image" };
            TimeSpan date = EndDay - StartDay;
            if (date.Days < 20)
            {
                yield return new ValidationResult("Ngày kết thúc phải lớn hơn ngày bắt đầu ít nhất 20 ngày", property);
            }
            if (TotalOfSub < 10 || TotalOfSub > 29)
            {
                yield return new ValidationResult("Số buổi phải từ 10 đến 29", total);
            }
        }

    }
}
