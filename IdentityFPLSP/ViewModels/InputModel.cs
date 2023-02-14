using System.ComponentModel.DataAnnotations;

namespace IdentityFPLSP.ViewModels
{
    public class InputModel
    {
        [Required]
        [EmailAddress]

        public string Email { get; set; }
    }
}
