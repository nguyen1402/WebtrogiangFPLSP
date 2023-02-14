using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class SpecializedSubjectUPConfiguration : IEntityTypeConfiguration<SpecializedSubjectUP>
    {
        public void Configure(EntityTypeBuilder<SpecializedSubjectUP> builder)
        {

            builder.ToTable("SpecializedSubjectUP");

            builder.HasKey(c => new { c.SpecializedId, c.SubjectId });
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

            builder.HasOne<SpecializedUP>(c => c.specializedUP)
                .WithMany(c => c.SpecializedSubjectUPs)
                .HasForeignKey(c => c.SpecializedId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<SubjectUP>(c => c.SubjectUP)
           .WithMany(c => c.SpecializedSubjectUPs)
           .HasForeignKey(c => c.SubjectId)
           .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
