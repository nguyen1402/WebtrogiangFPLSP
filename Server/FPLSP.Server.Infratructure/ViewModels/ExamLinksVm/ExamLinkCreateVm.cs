using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.ExamLinks
{
    public class ExamLinkCreateVm : IValidatableObject
    {
        public Guid Id { get; set; }
        public Guid? ExamId { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống Mã Link Đề Thi")]
        [RegularExpression(@"^[A-Z''-'\d/s/]{1,10}$",
        ErrorMessage = "Mã link đề thi phải in hoa, không được có kí tự đặc biệt, tối đa 10 kí tự")]
        public string ExamLinkCode { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống đường dẫn")]
        [RegularExpression(@"(http|ftp|https)://[\w-]+(\.[\w-]+)+([\w.,@?^=%&:/~+#-]*[\w@?^=%&/~+#-])?", ErrorMessage = "Nhập đúng đinh dạng url")]
        public string Path { get; set; }
        [DataType(DataType.DateTime, ErrorMessage = "Nhập đúng định dạng thời gian")]
        public DateTime CreatedDay { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Nhập đúng định dạng thời gian")]
        public DateTime ExpirationDate { get; set; } = DateTime.Now;
        public int Status { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var property = new[] { "ExpirationDate" };
            if (ExpirationDate < CreatedDay)
            {
                yield return new ValidationResult("Ngày Kết thúc phải lớn hơn hoặc bằng hiện tại", property);
            }

        }
    }

}
