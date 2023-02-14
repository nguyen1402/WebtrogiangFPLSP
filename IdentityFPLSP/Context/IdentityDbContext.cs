using IdentityServer4.EntityFramework.DbContexts;
using IdentityServer4.EntityFramework.Entities;
using IdentityServer4.EntityFramework.Extensions;
using IdentityServer4.EntityFramework.Interfaces;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IdentityFPLSP.Context
{
    public class IdentityDbContext : ConfigurationDbContext<IdentityDbContext>
    {
        private readonly ConfigurationStoreOptions _storeOptions;
       
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options, ConfigurationStoreOptions storeOptions)
        : base(options, storeOptions)
        {
            _storeOptions = storeOptions;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureClientContext(_storeOptions);
            modelBuilder.ConfigureResourcesContext(_storeOptions);

            base.OnModelCreating(modelBuilder);


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {


                optionsBuilder.UseSqlServer("Data Source=66.42.55.38;Initial Catalog=FPLSP_Server_Final_Back_DEV;User ID=test;Password=E=lPJeY>-g/9QxzE;MultipleActiveResultSets=true");

            }
        }
        //public DbSet<ApiResourceProperty> apiResourceProperties { get; set; }
        //public DbSet<IdentityResourceProperty> identityResourceProperties { get; set; }
        //public DbSet<ApiResourceSecret> apiResourceSecrets { get; set; }
        //public DbSet<ApiScopeClaim> apiScopeClaims { get; set; }
        //public DbSet<IdentityResourceClaim> identityResourceClaims { get; set; }
        //public DbSet<ApiResourceClaim> apiResourceClaims { get; set; }
        //public DbSet<ClientGrantType> clientGrantTypes { get; set; }
        ////
        //public DbSet<ClientScope> clientScopes { get; set; }

        //public DbSet<ClientSecret> clientSecrets { get; set; }
        //public DbSet<ClientPostLogoutRedirectUri> clientPostLogoutRedirectUris { get; set; }
        //public DbSet<ClientIdPRestriction> clientIdPRestrictions { get; set; }
        //public DbSet<ClientRedirectUri> clientRedirectUris { get; set; }
        //public DbSet<ClientClaim> clientClaims { get; set; }
        //public DbSet<ClientProperty> clientProperties { get; set; }
        //public DbSet<ApiScopeProperty> apiScopeProperties { get; set; }
        //public DbSet<ApiResourceScope> apiResourceScopes { get; set; }
        //public DbSet<IdentityResource> IdentityResources { get; set; }
        //public DbSet<ApiScope> apiScopes { get; set; }
        //public DbSet<ApiResource> apiResources { get; set; }
        //public DbSet<Client> clients { get; set; }


        //public DbSet<ClientCorsOrigin> clientCorsOrigins { get; set; }


    }
}
