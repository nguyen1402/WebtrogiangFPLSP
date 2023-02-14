using FPLSP.Server.Data.FPLSPDbContext;
using FPLSP.Server.Domain.Entities.CoresParts;
using IdentityModel;
using IdentityServer4.EntityFramework.DbContexts;
using IdentityServer4.EntityFramework.Storage;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Claims;

namespace FPLSP.Server.Data.Configurations
{
    public class ConfigSeed
    {
        private static readonly IPasswordHasher<UserSignIn> _passwordHasher = new PasswordHasher<UserSignIn>();
        public void EnsureSeedData(string connectionString)
        {
            var services = new ServiceCollection();
            services.AddLogging();
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(connectionString)
            );

            services
                .AddIdentity<UserSignIn, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddOperationalDbContext(
                options =>
                {
                    options.ConfigureDbContext = db =>
                        db.UseSqlServer(
                            connectionString

                        );
                }
            );
            services.AddConfigurationDbContext(
                options =>
                {
                    options.ConfigureDbContext = db =>
                        db.UseSqlServer(
                            connectionString

                        );
                }
            );

            var serviceProvider = services.BuildServiceProvider();

            using var scope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope();
            scope.ServiceProvider.GetService<PersistedGrantDbContext>().Database.Migrate();

            var context = scope.ServiceProvider.GetService<ConfigurationDbContext>();
            context.Database.Migrate();

            EnsureSeedData(context);

            var ctx = scope.ServiceProvider.GetService<ApplicationDbContext>();
            ctx.Database.Migrate();
            EnsureUsers(scope);
        }

        public void EnsureUsers(IServiceScope scope)
        {
            var userMgr = scope.ServiceProvider.GetRequiredService<UserManager<UserSignIn>>();

            var angella = userMgr.FindByNameAsync("angella").Result;
            if (angella == null)
            {
                angella = new UserSignIn
                {

                    UserName = "angella",
                    Email = "angella.freeman@email.com",
                    EmailConfirmed = true
                };
                var result = userMgr.CreateAsync(angella, "Pass123$").Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }

                result =
                    userMgr.AddClaimsAsync(
                        angella,
                        new Claim[]
                        {
                            new Claim(JwtClaimTypes.Name, "Angella Freeman"),
                            new Claim(JwtClaimTypes.GivenName, "Angella"),
                            new Claim(JwtClaimTypes.FamilyName, "Freeman"),
                            new Claim(JwtClaimTypes.Role, "Admin"),
                            new Claim(JwtClaimTypes.WebSite, "http://angellafreeman.com"),
                            new Claim("location", "somewhere")
                        }
                    ).Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }

            }
        }

        public void EnsureSeedData(ConfigurationDbContext context)
        {
            //if (!context.Clients.Any())
            //{
            //    foreach (var client in IdentitySeedingData.Clients.ToList())
            //    {
            //        context.Clients.Add(client.ToEntity());
            //    }

            //    context.SaveChanges();
            //}

            //if (!context.IdentityResources.Any())
            //{
            //    foreach (var resource in IdentitySeedingData.IdentityResources.ToList())
            //    {
            //        context.IdentityResources.Add(resource.ToEntity());
            //    }

            //    context.SaveChanges();
            //}

            //if (!context.ApiScopes.Any())
            //{
            //    foreach (var resource in IdentitySeedingData.ApiScopes.ToList())
            //    {
            //        context.ApiScopes.Add(resource.ToEntity());
            //    }

            //    context.SaveChanges();
            //}

            //if (!context.ApiResources.Any())
            //{
            //    foreach (var resource in IdentitySeedingData.ApiResources.ToList())
            //    {
            //        context.ApiResources.Add(resource.ToEntity());
            //    }

            //    context.SaveChanges();
            //}
        }
    }
}
