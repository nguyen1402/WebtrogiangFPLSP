using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class SpecializedUPConfigarution : IEntityTypeConfiguration<SpecializedUP>
    {

        public void Configure(EntityTypeBuilder<SpecializedUP> builder)
        {
            builder.ToTable("SpecializedUP");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.SpecializedCode).HasColumnName("SpecializedCode").HasColumnType("nchar(10)").IsRequired();
            builder.Property(c => c.SpecializationName).HasColumnName("SpecializationName").HasMaxLength(50).IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.Property(c => c.Level).HasColumnName("Level").IsRequired();
            builder.Property(c => c.SpecialityId).HasColumnName("SpecialityId");

            builder.HasOne(c => c.SpecializedUp)
             .WithMany(c => c.InverseReportsToNavigation)
             .HasForeignKey(c => c.SpecialityId)
             .OnDelete(DeleteBehavior.ClientSetNull)
             .HasConstraintName("FK_ChuyenNganh_ChuyenNganhhep");


        }
    }
}
