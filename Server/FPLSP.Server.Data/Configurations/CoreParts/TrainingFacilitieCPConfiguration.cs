using FPLSP.Server.Domain.Entities.CoresParts;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts;

public class TrainingFacilitieCPConfiguration : IEntityTypeConfiguration<TrainingFacilitiesCP>
{
    public void Configure(EntityTypeBuilder<TrainingFacilitiesCP> builder)
    {

        builder.ToTable("TrainingFacilitiesCP");
        builder.HasKey(c => c.Id);

        builder.Property(c => c.TrainingFacilitiesCode).HasColumnName("TrainingFacilitiesCode").HasMaxLength(10).IsRequired();
        builder.Property(c => c.TrainingInstitutionName).HasColumnName("TrainingInstitutionName").HasMaxLength(50).IsRequired();
        builder.Property(c => c.ImageUrl).HasColumnName("ImageUrl").HasMaxLength(200).IsRequired();
        builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
    }
}