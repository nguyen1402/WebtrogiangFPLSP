using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.QuizCPVm
{
    public class UpdateQuizCPVm : IValidatableObject
    {
        [Required(ErrorMessage = "Không được bỏ trống tên Quiz")]
        public string QuizName { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống mô tả")]
        public string Descriptions { get; set; }
        public int MaxTurn { get; set; }
        public int Status { get; set; }
        public DateTimeOffset StartDay { get; set; }
        public DateTimeOffset EndDay { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var property = new[] { "EndDay" };
            var maxTurn = new[] { "MaxTurn" };
            TimeSpan date = EndDay - StartDay;

            if (date.Days < 0)
            {
                yield return new ValidationResult("Ngày kết thúc phải lớn hơn ngày bắt đầu 1 ngày", property);
            }
            if (MaxTurn < 1)
            {
                yield return new ValidationResult("Số lần làm phải lớn hơn 0", maxTurn);
            }
        }
    }
}
