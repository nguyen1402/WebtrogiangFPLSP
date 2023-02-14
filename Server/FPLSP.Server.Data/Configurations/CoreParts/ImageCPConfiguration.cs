using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts;

public class ImageCPConfiguration : IEntityTypeConfiguration<ImageCP>
{
    public void Configure(EntityTypeBuilder<ImageCP> builder)
    {

        builder.ToTable("ImageCP");
        builder.HasKey(entity => entity.Id);
        builder.Property(c => c.CoeId).HasColumnName("CoeId").HasMaxLength(10).IsRequired();
        builder.Property(c => c.Path).HasColumnName("Path").HasMaxLength(100).IsRequired();
        builder.Property(c => c.Descriptions).HasColumnName("Descriptions").HasMaxLength(100).IsRequired();
        builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
        builder.HasOne<ContentOfExamCP>(entity => entity.ContentOfExamCP)
                .WithMany(entity => entity.ImageCPs)
                .HasForeignKey(entity => entity.CoeId)
                .OnDelete(DeleteBehavior.Cascade);
    }
}