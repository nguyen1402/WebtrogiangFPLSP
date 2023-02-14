using FPLSP.Server.Domain.Entities.CoresParts;
using System.Security.Claims;

namespace FPLSP.Server.Infrastructure.ViewModels
{
    public class UserInListRoles : UserSignIn
    {
        public List<string> ListRoles { set; get; } = new List<string>();
        public List<Claim> ListRedirectClaims { set; get; } = new List<Claim>();
    }
}
