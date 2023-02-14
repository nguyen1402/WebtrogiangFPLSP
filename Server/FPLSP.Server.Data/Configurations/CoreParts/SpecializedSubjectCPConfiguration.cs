using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts
{
    public class SpecializedSubjectCPConfiguration : IEntityTypeConfiguration<SpecializedSubjectCP>
    {
        public void Configure(EntityTypeBuilder<SpecializedSubjectCP> builder)
        {

            builder.ToTable("SpecializedSubjectCP");

            builder.HasKey(c => new { c.SpecializedId, c.SubjectId });
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

            builder.HasOne<SpecializedCP>(c => c.specializedCP)
                .WithMany(c => c.SpecializedSubjectCPs)
                .HasForeignKey(c => c.SpecializedId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<SubjectCP>(c => c.SubjectCP)
           .WithMany(c => c.SpecializedSubjectCPs)
           .HasForeignKey(c => c.SubjectId)
           .OnDelete(DeleteBehavior.Restrict);


        }


    }
}
