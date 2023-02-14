using System.Security.Claims;

namespace FPLSP.Data
{
    public class UserUpdateRolesHasClaims
    {
        public string ID { set; get; }
        public string Name { set; get; }

        public string[] RoleNames { set; get; }
        public List<Claim> claims { set; get; }
    }
}
