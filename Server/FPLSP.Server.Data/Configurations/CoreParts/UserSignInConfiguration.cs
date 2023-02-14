using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts
{
    public class UserSignInConfiguration : IEntityTypeConfiguration<UserSignIn>
    {
        public void Configure(EntityTypeBuilder<UserSignIn> builder)
        {


        }


    }
}
