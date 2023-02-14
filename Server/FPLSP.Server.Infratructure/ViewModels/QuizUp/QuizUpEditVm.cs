using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.QuizUp
{
    public class QuizUpEditVm : IValidatableObject
    {
        [Required(ErrorMessage = "Không được bỏ trống tiêu đề Quiz")]
        public string QuizTitle { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống tên  Quiz")]
        public string QuizName { get; set; }
        [Required]
        public DateTimeOffset StartDay { get; set; } = DateTimeOffset.Now;
        [Required(ErrorMessage = "Không được bỏ trống tối đa lượt làm Quiz")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Chỉ được nhập số")]
        public int MaxTurn { get; set; }
        [Required]
        public DateTimeOffset EndDay { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset CreateTime { get; set; } = DateTimeOffset.Now;
        public Guid? SubjectId { get; set; }
        public bool IsDeleted { get; set; }
        [Required]
        public int Status { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống mô tả")]
        public string Descriptions { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var property = new[] { "EndDay" };
            var property2 = new[] { "StartDay" };
            var property3 = new[] { "Status" };
            var property4 = new[] { "MaxTurn" };
            TimeSpan timeSpan = EndDay - CreateTime;
            if (StartDay > EndDay)
            {
                yield return new ValidationResult("Ngày bắt đầu phải trước ngày kết thúc", property2);
            }
            if (timeSpan.Days < 0 && Status == 0)
            {
                yield return new ValidationResult("Trạng thái hoạt động quá thời gian kết thúc", property3);
            }
            if (MaxTurn <= 0)
            {
                yield return new ValidationResult("Số lượt làm phải lớn hơn 0", property4);
            }

        }
    }
}
