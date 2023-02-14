using FPLSP.Server.Domain.Entities.UserParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class StudentClassUPConfiguration : IEntityTypeConfiguration<StudentClassUP>
    {
        public void Configure(EntityTypeBuilder<StudentClassUP> builder)
        {
            builder.ToTable("StudentClassUP");
            builder.HasKey(c => new { c.StudentId, c.ClassId, c.JoinCodeAsign });
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.Property(c => c.StatusOfStudent).HasColumnName("StatusOfStudent").IsRequired();
            builder.Property(c => c.JoinCodeAsign).HasColumnName("JoinCodeAsign").HasMaxLength(10).IsRequired();

            builder.HasOne<ClassUp>(c => c.ClassUp)
                .WithMany(c => c.StudentClassUPs)
                .HasForeignKey(c => c.ClassId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<StudentUP>(c => c.StudentUp)
                .WithMany(c => c.StudentClassUPs)
                .HasForeignKey(c => c.StudentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
