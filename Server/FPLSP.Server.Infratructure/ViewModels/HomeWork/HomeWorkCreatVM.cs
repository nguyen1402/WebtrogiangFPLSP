using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.HomeWork
{
    public class HomeWorkCreatVM : IValidatableObject
    {
        [Required(ErrorMessage = "Không được bỏ trống Link")]
        public string LinkHomeWork { get; set; }
        public Guid? IdClass { get; set; }
        public Guid? IdSubject { get; set; }
        public Guid? IdLesson { get; set; }
        public string? IdUser { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            var property = new[] { "LinkHomeWork" };
            string b = LinkHomeWork;
            var myRegex = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.IgnoreCase);

            var results = myRegex.IsMatch(b);
            if (results == false)
            {
                yield return new ValidationResult("Định dạng link đang sai ! Ví dụ( http://yahoo.com )", property);
            }
        }
    }
}
