using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace FPLSP.Data
{
    public class CustomClaimsForUser
    {
        private readonly UserManager<UserSignIn> _userManager;
        public CustomClaimsForUser(UserManager<UserSignIn> userManager)
        {
            _userManager = userManager;
        }

        public async Task<List<Claim>> GetListClaimForUser(UserSignIn userSignIn)
        {

            var claims = await _userManager.GetClaimsAsync(userSignIn);
            return claims.ToList();
        }
        public async Task<string> IsCRUDUser(UserSignIn userSignIn)
        {

            var resClaims = await GetListClaimForUser(userSignIn);
            foreach (var x in resClaims)
            {
                if (x.Type == "IsUserCanCRUD")
                {
                    return x.Value.ToString();
                }
            }

            return "false";
        }

        public async Task<string> CanViewCabinProject(UserSignIn userSignIn)
        {

            var resClaims = await GetListClaimForUser(userSignIn);
            foreach (var x in resClaims)
            {
                if (x.Type == "CanViewCabinProject")
                {
                    return x.Value.ToString();
                }
            }

            return "false";
        }
        public async Task<string> CanViewFPLSPProject(UserSignIn userSignIn)
        {

            var resClaims = await GetListClaimForUser(userSignIn);
            foreach (var x in resClaims)
            {
                if (x.Type == "CanViewFPLSPProject")
                {
                    return x.Value.ToString();
                }
            }

            return "false";
        }
        public async Task<string> CanViewFPLExam(UserSignIn userSignIn)
        {

            var resClaims = await GetListClaimForUser(userSignIn);
            foreach (var x in resClaims)
            {
                if (x.Type == "CanViewFPLExam")
                {
                    return x.Value.ToString();
                }
            }

            return "false";
        }
    }
}
