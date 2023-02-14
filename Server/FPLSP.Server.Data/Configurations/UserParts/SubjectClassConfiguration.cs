using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class SubjectClassConfiguration : IEntityTypeConfiguration<SubjectClassUP>
    {
        public void Configure(EntityTypeBuilder<SubjectClassUP> builder)
        {
            builder.ToTable("SubjectClassUP");
            builder.HasKey(c => new { c.SubjectId, c.ClassId });
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.Property(c => c.JoinCode).HasColumnName("JoinCode").HasMaxLength(10).IsRequired();
            builder.Property(c => c.HomeroomLecturer).HasColumnName("HomeroomLecturer").IsRequired();
            builder.Property(c => c.StudentAmount).HasColumnName("StudentAmount").IsRequired();
            builder.Property(c => c.SpecializedOfClass).HasColumnName("SpecializedOfClass").IsRequired();
            builder.HasOne<ClassUp>(c => c.ClassUp)
                .WithMany(c => c.SubjectClassUPs)
                .HasForeignKey(c => c.ClassId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<SubjectUP>(c => c.SubjectUP)
                .WithMany(c => c.SubjectClassUPs)
                .HasForeignKey(c => c.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
