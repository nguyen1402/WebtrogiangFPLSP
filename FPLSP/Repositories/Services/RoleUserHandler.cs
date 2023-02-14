using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace FPLSP.Repositories.Services
{
    public class RoleUserHandler : AuthorizationHandler<RoleUserRequirement>
    {
        private readonly UserManager<UserSignIn> _userManager;
        public RoleUserHandler()
        {

        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, RoleUserRequirement requirement)
        {
            var emailAddress = context.User.Identity.Name;
            Console.WriteLine(context.User.Identity.Name);
            // Nếu cho Admin cập nhật thì kiểm tra User có RoleClaim Admin
            if (emailAddress.EndsWith(requirement.Email))
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
                //if (context.User.IsInRole("Admin"))
                //{
                //    // Cho phép


                //}
            }
            else
            {
                Console.WriteLine("exep");
            }

            if (context.User.Identity?.IsAuthenticated != true)
            {

                return Task.CompletedTask;
            }

            //if (requirement.OwnerCanUpdate)
            //{
            //    var user = _userManager.GetUserAsync(context.User).Result;
            //    if (user.Id == resource.UserID)
            //    {
            //        _logger.LogInformation("Được phép cập nhật");
            //        context.Succeed(requirement);
            //        return Task.CompletedTask;
            //    }
            //}

            //_logger.LogInformation("Không được phép cập nhật");
            return Task.CompletedTask;
        }
    }
}
