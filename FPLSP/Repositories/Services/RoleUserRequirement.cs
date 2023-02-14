using Microsoft.AspNetCore.Authorization;

namespace FPLSP.Repositories.Services
{
    public class RoleUserRequirement : IAuthorizationRequirement
    {
        public string Email { get; }
        public RoleUserRequirement(string email)
        {
            Email = email;
        }
    }
}
