using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CabinConfigs
{
    public class CabinConfiguration : IEntityTypeConfiguration<Cabin>
    {

        public void Configure(EntityTypeBuilder<Cabin> builder)
        {

            builder.ToTable("Cabin");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CabinName).HasColumnName("CabinName").IsRequired();
            builder.Property(c => c.IndexOfCabin).HasColumnName("IndexOfCabin").IsRequired();
            builder.Property(c => c.CreateTime).HasColumnName("CreateTime").IsRequired();
            builder.Property(c => c.BuildingName).HasColumnName("BuildingName").IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

            builder.HasOne<TrainingFacilitiesCP>(c => c.TrainingFacilitiesCPs)
           .WithMany(c => c.Cabins)
           .HasForeignKey(c => c.IdTrainingFacility)
           .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
