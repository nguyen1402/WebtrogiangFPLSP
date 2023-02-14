using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class LectuterSpecializedUPConfiguration : IEntityTypeConfiguration<LectuterSpecializedUP>
    {
        public void Configure(EntityTypeBuilder<LectuterSpecializedUP> builder)
        {
            builder.ToTable("LectuterSpecializedUP");
            builder.HasKey(c => new { c.SpecializedId, c.LectuterId });
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.HasOne<LecturersCP>(c => c.LecturersCP)
                .WithMany(c => c.LectuterSpecializedUPs)
                .HasForeignKey(c => c.LectuterId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<SpecializedUP>(c => c.SpecializedUP)
                .WithMany(c => c.LectuterSpecializedUPs)
                .HasForeignKey(c => c.SpecializedId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
