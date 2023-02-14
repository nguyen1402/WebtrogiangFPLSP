using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.Exams
{
    public class ExamUpdateVm : IValidatableObject
    {
        [Required(ErrorMessage = "Không được bỏ trống Mã Đề Thi")]
        [RegularExpression(@"^[A-Z''-'\d/s/]{1,10}$",
            ErrorMessage = "Mã đề thi phải in hoa, không được có kí tự đặc biệt, tối đa 10 kí tự")]
        public string ExamCode { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống Tên Đề Thi")]
        public string ExamName { get; set; }

        public int Status { get; set; }

        public Guid? SubjectId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var property = new[] { "ExamName" };
            if (ExamName.Length > 30)
            {
                yield return new ValidationResult("Tên Đề tối đa 30 kí tự", property);
            }
        }
    }
}
