using DocumentFormat.OpenXml.Spreadsheet;
using FPLSP.Pages.RolePages;
using FPLSP.Server.Domain.Entities.CoresParts;
using IdentityModel;
using IdentityServer4.Extensions;
using IdentityServer4.Models;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace FPLSP.Repositories.Services
{
    public class CustomProfileService : IProfileService
    {
        protected UserManager<UserSignIn> _userManager;

        public CustomProfileService(UserManager<UserSignIn> userManager)
        {
            _userManager = userManager;
        }

        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            //>Processing
            var user = await _userManager.GetUserAsync(context.Subject);

            var claims = new List<Claim>
           {
            //new Claim("FullName", user.FullName),
            };

            context.IssuedClaims.AddRange(claims);
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            //>Processing
            var user = await _userManager.GetUserAsync(context.Subject);

            context.IsActive = (user != null);
        }
    }
}
