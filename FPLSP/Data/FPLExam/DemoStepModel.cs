using System.ComponentModel.DataAnnotations;

namespace FPLSP.Data.FPLExam
{
    public class DemoStepModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
