using FPLSP.Data;
using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using System.Collections.Generic;
using System.Security.Claims;

namespace FPLSP.Repositories.Services
{

    public class UserIdentityRepo : IUserIdentityRepo
    {
        private readonly HttpClient _httpClient;
        private readonly UserManager<UserSignIn> _userManager;
        private readonly PageList<UserInListRoles> _pageList = new PageList<UserInListRoles>();
        public UserIdentityRepo(HttpClient httpClient, UserManager<UserSignIn> userManager)
        {
            _httpClient = httpClient;
            _userManager = userManager;
        }
        public async Task<bool> AddRolesToUser(UserUpdateRolesHasClaims userUpdateRoles)
        {

            //mapping dữ liệu vào đốu tượng không có claims
            UserUpdateRoles userUpdate = new UserUpdateRoles()
            {
                ID = userUpdateRoles.ID,
                Name = userUpdateRoles.Name,
                RoleNames = userUpdateRoles.RoleNames,
            };

            var user = await _userManager.FindByNameAsync(userUpdateRoles.Name);
            //vì không truyền được claims qua nên phải add claim vào user sau khi phương thức trên thành công
            var claimsuser = await _userManager.GetClaimsAsync(user);

            foreach (var ditcunhamay in claimsuser)
            {
                if (ditcunhamay.Type == "CanViewCabinProject")
                {
                    await _userManager.RemoveClaimAsync(user, ditcunhamay);
                }
                if (ditcunhamay.Type == "CanViewFPLSPProject")
                {
                    await _userManager.RemoveClaimAsync(user, ditcunhamay);
                }
                if (ditcunhamay.Type == "CanViewFPLExam")
                {
                    await _userManager.RemoveClaimAsync(user, ditcunhamay);
                }
            }

            if (userUpdateRoles.claims.Count() != 0)
            {
                foreach (var loneconmenhamay in userUpdateRoles.claims)
                {
                    if (loneconmenhamay.Type == "CanViewCabinProject")
                    {
                        var claimadding = new Claim("CanViewCabinProject", "true");
                        var res = await _userManager.AddClaimAsync(user, claimadding);

                    }
                    if (loneconmenhamay.Type == "CanViewFPLSPProject")
                    {
                        var claimadding = new Claim("CanViewFPLSPProject", "true");
                        var res = await _userManager.AddClaimAsync(user, claimadding);
                    }
                    if (loneconmenhamay.Type == "CanViewFPLExam")
                    {
                        var claimadding = new Claim("CanViewFPLExam", "true");
                        var res = await _userManager.AddClaimAsync(user, claimadding);
                    }
                }
            }
            var results = await _httpClient.PostAsJsonAsync("/api/Users", userUpdate);





            return results.IsSuccessStatusCode;








        }

        public async Task<PageList<UserInListRoles>> GetAllUser(UserRoleSearch userRoleSearch)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = userRoleSearch.PageNumber.ToString(),
                ["role"] = userRoleSearch.Role,
                ["name"] = userRoleSearch.Name,
                ["statusNotRole"] = userRoleSearch.StatusNotRole.ToString()
            };
            string url = QueryHelpers.AddQueryString("/api/Users/getPageList", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<UserInListRoles>>(url);

            foreach (var adding in result.Items.ToList())
            {
                var getclaims = await _userManager.GetClaimsAsync(adding);
                //chỉ cần lấy ra các claims này thôi
                foreach (var claims in getclaims.ToList().Where(c => c.Type == "CanViewFPLSPProject" || c.Type == "CanViewCabinProject" || c.Type == "CanViewFPLExam"))
                {
                    adding.ListRedirectClaims.Add(claims);
                }

            }


            return result;
        }


        public async Task<UserInListRoles> GetRoleUser(string email)
        {
            UserInListRoles userInListRoles = new UserInListRoles();
            var results = await _httpClient.GetFromJsonAsync<UserInListRoles>($"/api/Users/role/{email}");

            var getclaims = await _userManager.GetClaimsAsync(results);
            //chỉ cần lấy ra các claims này thôi
            foreach (var claims in getclaims.ToList().Where(c => c.Type == "CanViewFPLSPProject" || c.Type == "CanViewCabinProject" || c.Type == "CanViewFPLExam"))
            {
                results.ListRedirectClaims.Add(claims);
            }
            return results;
        }
        public async Task<List<UserInListRoles>> GetAllListUser()
        {

            var results = await _httpClient.GetFromJsonAsync<List<UserInListRoles>>($"/api/Users/GetAllListUser");
            foreach (var item in results)
            {
                var getclaims = await _userManager.GetClaimsAsync(item);
                //chỉ cần lấy ra các claims này thôi
                foreach (var claims in getclaims.ToList().Where(c => c.Type == "CanViewFPLSPProject" || c.Type == "CanViewCabinProject" || c.Type == "CanViewFPLExam"))
                {
                    item.ListRedirectClaims.Add(claims);
                }
            }

            return results;
        }
        public async Task<bool> CheckUserChageIdTrain(string idUser, Guid idTrain)
        {

            var results = await _httpClient.DeleteAsync($"/api/Users/CheckUserChageIdTrain/{idUser}/{idTrain}");

            if (results.IsSuccessStatusCode) return true;
            return false;
        }
        public async Task<bool> DeleteUserNorRole(string idUser)
        {

            var results = await _httpClient.DeleteAsync($"/api/Users/DeleteUserNorRole/{idUser}");

            if (results.IsSuccessStatusCode) return true;
            return false;
        }

        public async Task<UserInListRoles> GetUserRoleById(string Id)
        {
            var results = await _httpClient.GetFromJsonAsync<UserInListRoles>($"/api/Users/{Id}");
            var getclaims = await _userManager.GetClaimsAsync(results);
            //chỉ cần lấy ra các claims này thôi
            foreach (var claims in getclaims.ToList().Where(c => c.Type == "CanViewFPLSPProject" || c.Type == "CanViewCabinProject" || c.Type == "CanViewFPLExam"))
            {
                results.ListRedirectClaims.Add(claims);
            }
            return results;
        }
    }
}
