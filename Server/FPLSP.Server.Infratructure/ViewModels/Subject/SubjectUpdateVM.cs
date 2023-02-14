using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.Subject
{
    public class SubjectUpdateVM : IValidatableObject
    {
        [Required(ErrorMessage = "Không được bỏ trống Mã Môn")]
        [RegularExpression(@"^[A-Z''-'\d/s/]{1,10}$",
          ErrorMessage = "Mã Môn phải in hoa, không được có kí tự đặc biệt, tối đa 10 kí tự")]
        public string SubjectCode { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống Tên Môn")]
        public string SubjectName { get; set; }


        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }

        [RegularExpression(@"^[1-2][0-9]*$",
         ErrorMessage = "Số buổi phải từ 10 -> 29")]
        public int TotalOfSub { get; set; }
        public string Image { get; set; }
        public int Status { get; set; }
        public bool IsDemo { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var total = new[] { "TotalOfSub" };

            if (TotalOfSub < 10 || TotalOfSub > 29)
            {
                yield return new ValidationResult("Số buổi phải từ 10 đến 29", total);
            }
        }
    }
}
