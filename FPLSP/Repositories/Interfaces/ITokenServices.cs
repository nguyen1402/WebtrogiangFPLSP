using IdentityModel.Client;

namespace FPLSP.Repositories.Interfaces
{
    public interface ITokenServices
    {
        Task<TokenResponse> GetToken(string scope);


    }
}
