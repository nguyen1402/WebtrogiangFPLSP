using FPLSP.Server.Domain.Entities.CoresParts;
using IdentityServerHost.Quickstart.UI;

namespace FPLSP.Data
{
    public class MixedModel : LoginInputModel
    {
        public List<TrainingFacilitiesCP> LisTraining { get; set; }
        public LoginViewModel loginViewModel { get; set; }
    }
}
