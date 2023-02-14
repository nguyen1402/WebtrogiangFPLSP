using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.CabinProject
{
    public class SemesterBlockVM : IValidatableObject
	{
        public Guid IdBlock { get; set; }
        public Guid IdSemester { get; set; }
		[Required(ErrorMessage = "Không được bỏ trống kì")]
		public string? NameofSemester { get; set; }
		[Required(ErrorMessage = "Không được bỏ trống block")]
		public string? NameofBlock { get; set; }
        public DateTime StartTime { get; set; } = DateTime.Now;
        public DateTime EndTime { get; set; } = DateTime.Now;
        public int IndexOfSemesterBlock { get; set; }
        public bool? Checked { get; set; }
        public int Status { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
			var property = new[] { "EndTime" };
			var property2 = new[] { "StartTime" };
			if (StartTime > EndTime)
			{
				yield return new ValidationResult("Ngày bắt đầu phải trước ngày kết thúc", property2);
			}
            if (!(StartTime.DayOfWeek == DayOfWeek.Monday))
            {
                yield return new ValidationResult("Ngày bắt đầu kì học phải là thứ 2", property2);
            }
        }
    }
}
