using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts;

public class RoleCPConfiguration : IEntityTypeConfiguration<RoleCP>
{
    public void Configure(EntityTypeBuilder<RoleCP> builder)
    {
        builder.ToTable("RoleCP");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.RoleCode).HasColumnName("RoleCode").HasDefaultValue("CV0").HasMaxLength(10).IsRequired();
        builder.Property(c => c.RoleName).HasColumnName("RoleName").HasDefaultValue("SinhVien").HasMaxLength(30).IsRequired();
        builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

    }
}