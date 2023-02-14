using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Security.Claims;

namespace IdentityFPLSP.Configurations.SeedWorking
{
    public class IdentitySeedingData
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
               new IdentityResource("roles", "User role(s)", new List<string> { "role" }),
                new IdentityResource
                {
                    Name = "role",
                    UserClaims = new List<string> { "role","admin","viewer" }
                }
            };
        }

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
               new ApiScope("IdentityFPLSP.read"),
                new ApiScope("IdentityFPLSP.write")
            };
        }

        public static IEnumerable<ApiResource> GetApis()
        {
            return new List<ApiResource>
            {
                new ApiResource("IdentityFPLSP")
                {
                    Scopes = new List<string> { "IdentityFPLSP.read", "IdentityFPLSP.write" },
                    ApiSecrets = new List<Secret> { new Secret("ScopeSecret".Sha256()) },
                     UserClaims =
                {
                    JwtClaimTypes.Name,
                    JwtClaimTypes.Email,
                    JwtClaimTypes.Subject,
                    JwtClaimTypes.Role,
                    JwtClaimTypes.Address,
                    JwtClaimTypes.Confirmation,
                    JwtClaimTypes.EmailVerified,
                    JwtClaimTypes.Id,
                    JwtClaimTypes.Profile
                }
                }
            };
        }
        public static List<TestUser> GetUsers() =>
    new List<TestUser>
    {
        new TestUser
        {
         //previous code
            Claims = new List<Claim>
            {
                new Claim("given_name", "Mick"),
                new Claim("family_name", "Mining"),
                new Claim("address", "Sunny Street 4"),
                new Claim("role", "Admin")
            }
        },
        new TestUser
        {
            //previous code
            Claims = new List<Claim>
            {
                new Claim("given_name", "Jane"),
                new Claim("family_name", "Downing"),
                new Claim("address", "Long Avenue 289"),
                new Claim("role", "Visitor")
            }
        }
   };
        public static IEnumerable<Client> GetClients()
        {

            return new List<Client>
            {
                // non-interactive
                //client CHO BLAZOr khác so với MVC
            new Client
            {
                ClientId = "Tana.client",

                    ClientName="Blazor Server App - Identity Claims",
                    ClientSecrets = { new Secret("ClientSecret1".Sha256()) },

                    AllowedGrantTypes = GrantTypes.Code,
                    RequireConsent = false,
                    RequirePkce = true,
                    RedirectUris={"https://localhost:6001/viewclass"},
                   FrontChannelLogoutUri="https://localhost:6001/logout",

                    AllowedScopes = {"IdentityFPLSP.read","IdentityFPLSP.write","roles" },

                    // include the refresh token
                   AllowOfflineAccess = true
            },
             //client sịn thường
            new Client
            {
                ClientId = "Thuyenla",
                ClientName = "Le An Thuyen",
                AllowedGrantTypes = GrantTypes.Code,
                ClientSecrets = { new Secret("ClientSecret1".Sha256()) },
                RedirectUris={"https://localhost:6001/signin"},
                FrontChannelLogoutUri="https://localhost:6001/logout",
                AllowOfflineAccess=true,
                RequirePkce=true,

                RequireConsent=true,
                AllowPlainTextPkce=false,
                AllowedScopes = { "IdentityFPLSP.read", "openid","profile","roles"},

            },
            };
        }
    }
}
