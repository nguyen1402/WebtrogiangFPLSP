using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts
{
    public class LectuterSpecializedCPConfiguration : IEntityTypeConfiguration<LectuterSpecializedCP>
    {
        public void Configure(EntityTypeBuilder<LectuterSpecializedCP> builder)
        {
            builder.ToTable("LectuterSpecializedCP");
            builder.HasKey(c => new { c.SpecializedId, c.LectuterId });
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.HasOne<LecturersCP>(c => c.LecturersCP)
                .WithMany(c => c.LectuterSpecializedCPs)
                .HasForeignKey(c => c.LectuterId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<SpecializedCP>(c => c.SpecializedCP)
                .WithMany(c => c.LectuterSpecializedCPs)
                .HasForeignKey(c => c.SpecializedId)
                .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
