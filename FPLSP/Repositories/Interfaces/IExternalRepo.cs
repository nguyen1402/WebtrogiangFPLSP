using FPLSP.Data;
using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace FPLSP.Repositories.Interfaces
{
    public interface IExternalRepo
    {
        Task<ExternalModel> Challenge(string scheme, string returnUrl);
        Task<(UserSignIn user, string provider, string providerUserId, IEnumerable<Claim> claims)> FindUserFromExternalProvider(AuthenticateResult result);
        UserSignIn AutoProvisionUser(string provider, string providerUserId, IEnumerable<Claim> claims);
        void ProcessLoginCallback(AuthenticateResult externalResult, List<Claim> localClaims, AuthenticationProperties localSignInProps);
        Task<string> Callback();


    }
}
