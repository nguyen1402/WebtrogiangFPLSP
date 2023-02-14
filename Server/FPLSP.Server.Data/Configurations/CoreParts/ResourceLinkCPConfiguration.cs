using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts;

public class ResourceLinkCPConfiguration : IEntityTypeConfiguration<ResourceLink>
{
    public void Configure(EntityTypeBuilder<ResourceLink> builder)
    {
        builder.ToTable("ResourceLinkCP");
        builder.HasKey(x => x.Id);
        builder.Property(c => c.Path).HasColumnName("Path").IsRequired();
        builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
        builder.Property(c => c.DateCreated).HasColumnName("DateCreated").IsRequired();
        builder.Property(c => c.Descriptions).HasColumnName("Descriptions").HasMaxLength(100).IsRequired();

    }
}