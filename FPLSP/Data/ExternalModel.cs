using Microsoft.AspNetCore.Authentication;

namespace FPLSP.Data
{
    public class ExternalModel
    {

        public string Scheme { get; set; }
        public AuthenticationProperties AuthenticationProperties { get; set; }
    }
}
