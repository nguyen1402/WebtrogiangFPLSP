using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.ContentOfExamsCP
{
    public class CoeUpdateVm : IValidatableObject
    {
        public Guid? ExamId { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống Mã Nôi Dung Đề Thi")]
        [RegularExpression(@"^[A-Z''-'\d/s/]{1,10}$",
    ErrorMessage = "Mã nội dung đề thi phải in hoa, không được có kí tự đặc biệt, tối đa 10 kí tự")]
        public string CoeCode { get; set; }
        [RegularExpression(@"^[0-9]*$",
     ErrorMessage = "Mức độ từ 0 đến 9")]
        [Required(ErrorMessage = "Không được bỏ trống mức độ nội dung")]
        public int Level { get; set; }
        public DateTimeOffset DateStarted { get; set; }
        public DateTimeOffset EndDate { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống số lượng câu hỏi")]
        [Range(0, 50, ErrorMessage = "Số lượng câu hỏi phải lớn hơn 0 và nhỏ hơn 50 câu")]
        public int TotalOfQuestions { get; set; }
        public int QuestionType { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống Nôi Dung Đề Thi")]
        public string Content { get; set; }
        public int Status { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (EndDate < DateTime.Now)
            {
                yield return new ValidationResult("Ngày Kết thúc phải lớn hơn hoặc bằng hiện tại");
            }
            if (DateStarted > EndDate)
            {
                yield return new ValidationResult("Ngày bắt đầu phải lớn hơn ngày kết thúc");
            }
        }

    }
}
