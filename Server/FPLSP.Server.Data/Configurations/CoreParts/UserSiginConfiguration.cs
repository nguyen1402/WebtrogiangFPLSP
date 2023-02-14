using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts
{
    public class UserSiginConfiguration : IEntityTypeConfiguration<UserSignIn>
    {
        public void Configure(EntityTypeBuilder<UserSignIn> builder)
        {
            builder.ToTable("UserSignIn");
            builder.HasKey(c => c.Id);
            builder.HasOne<TrainingFacilitiesCP>(c => c.TrainingFacilitiesCPs)
             .WithMany(c => c.UserSignIns)
             .HasForeignKey(c => c.IdTrainingFacility)
             .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
