using IdentityServerHost.Quickstart.UI;

namespace FPLSP.Repositories.Interfaces
{
    public interface ILoginRepo
    {
        Task<LoginViewModel> BuildLoginViewModelAsync(string returnUrl);
        Task<LoginViewModel> BuildLoginViewModelAsync(LoginInputModel model);
        Task<LoggedOutViewModel> BuildLoggedOutViewModelAsync(string logoutId);
        Task<LoginViewModel> Login(string returnUrl);




    }
}
