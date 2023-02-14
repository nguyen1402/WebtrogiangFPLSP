using IdentityModel;
using IdentityServer4.Models;
using static IdentityModel.OidcConstants;
using GrantTypes = IdentityServer4.Models.GrantTypes;

namespace FPLSP.Server.Data.Configurations
{
    public class IdentitySeedingData
    {
        public static IEnumerable<IdentityResource> IdentityResources =>

         new[]
         {
             new IdentityResources.OpenId(),
             new IdentityResources.Profile(),

             new IdentityResource
             {
                 Name="role",
                 UserClaims= new List<string>{"role"}
             },
                new IdentityResource("roles", new[] { "role","Admin","Student","Viewer","Editor" }) //Add this line
         };

        public static IEnumerable<ApiScope> ApiScopes =>

        new[]
        {
            new ApiScope("IdentityFPLSP.read"),
            new ApiScope("IdentityFPLSP.write"),
            new ApiScope
         {
             Name = "myAPI",
             DisplayName = "my API",
             Enabled = true,
             UserClaims =
             {   JwtClaimTypes.Name,
                 JwtClaimTypes.Email,
                 JwtClaimTypes.Subject,
                 JwtClaimTypes.Role,
                 JwtClaimTypes.Address,
                 JwtClaimTypes.Confirmation,
                 JwtClaimTypes.EmailVerified,
                 JwtClaimTypes.Id,
                 JwtClaimTypes.Profile
             }
         },

        };
        //
        public static IEnumerable<ApiResource> ApiResources =>

       new[]
       {
            new ApiResource("IdentityFPLSP")
            {
                Scopes= new List<string> { "IdentityFPLSP.read", "IdentityFPLSP.write", },
                ApiSecrets=new List<Secret>{new Secret("ScopeSecret".Sha256())},
                UserClaims=new List<string>{"role"}
            },

       };
        public static IEnumerable<Client> Clients =>

       new[]
       {
            //client sịn phêt
            new Client
            {
                ClientId = "Tana.client",
                ClientName = "Le An Thuyen",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("ClientSecret1".Sha256()) },
                AllowedScopes = { "IdentityFPLSP.read", "IdentityFPLSP.write" }
            },
             //client sịn thường
            new Client
            {
                ClientId = "Thuyenla",
                ClientName = "Le An Thuyen",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("ClientSecret1".Sha256()) },
                RedirectUris={"https://localhost:6001/signin"},
                FrontChannelLogoutUri="https://localhost:6001/logout",
                AllowOfflineAccess=true,
                RequirePkce=true,

                RequireConsent=true,
                AllowPlainTextPkce=false,
                AllowedScopes = { "IdentityFPLSP.read", "openid","profile","roles"},

            }
       };
    }
}
