using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class ResourceLinkConfigarution : IEntityTypeConfiguration<ResourceLinkUP>
    {
        public void Configure(EntityTypeBuilder<ResourceLinkUP> builder)
        {
            builder.ToTable("ResourceLinkUP");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ResourcesTitle).HasColumnName("ResourcesTitle").IsRequired();
            builder.Property(c => c.Path).HasColumnName("ResourcesUrl").IsRequired();
            builder.Property(c => c.DateCreated).HasColumnName("DateCreated").IsRequired();
            builder.Property(c => c.Descriptions).HasColumnName("Descriptions").HasMaxLength(100);
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
        }
    }
}
