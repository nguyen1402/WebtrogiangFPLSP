using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts;

public class SpecializedCPConfiguration : IEntityTypeConfiguration<SpecializedCP>
{
    public void Configure(EntityTypeBuilder<SpecializedCP> builder)
    {
        builder.ToTable("SpecializedCP");
        builder.HasKey(c => c.Id);

        builder.Property(c => c.SpecializedCode).HasColumnName("SpecializedCode").HasColumnType("nchar(10)").IsRequired();
        builder.Property(c => c.SpecializationName).HasColumnName("SpecializationName").HasMaxLength(50).IsRequired();
        builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
        builder.Property(c => c.Level).HasColumnName("Level").IsRequired();
        builder.Property(c => c.IdSpeciality).HasColumnName("IdSpeciality");

        // builder.HasOne(c => c.ChuyenNganhs).WithMany(c => c.InverseReportsToNavigation).HasConstraintName("FK_ChuyenNganh_ChuyenNganh");
        builder.HasOne(c => c.SpecializedCPs)
           .WithMany(c => c.InverseReportsToNavigation)
           .HasForeignKey(c => c.IdSpeciality)
           .OnDelete(DeleteBehavior.ClientSetNull)
           .HasConstraintName("FK_ChuyenNganh_ChuyenNganhs");






    }
}