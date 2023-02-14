using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class SubmitHomeWorkConfiguration : IEntityTypeConfiguration<SubmitHomeWork>
    {
        public void Configure(EntityTypeBuilder<SubmitHomeWork> builder)
        {
            builder.ToTable("SubmitHomeWork");
            builder.HasKey(c => new { c.Id });
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.Property(c => c.StartedDate).HasColumnName("StartedDate").IsRequired();
            builder.Property(c => c.EndTime).HasColumnName("EndTime").IsRequired();
            builder.Property(c => c.SubmitTime).HasColumnName("SubmitTime").IsRequired(false);
            builder.Property(c => c.SubmitLink).HasColumnName("SubmitLink");


            builder.HasOne<SubjectClassUP>(c => c.SubjectClassUP)
                .WithMany(c => c.submitHomeWorks)
                .HasForeignKey(c => new { c.IdSubject, c.IdClass })
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<StudentUP>(c => c.StudentUP)
            .WithMany(c => c.submitHomeWorks)
            .HasForeignKey(c => c.IdStudent)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<LessonUP>(c => c.LessonUP)
            .WithMany(c => c.submitHomeWorks)
            .HasForeignKey(c => c.IdLesson)
            .OnDelete(DeleteBehavior.Cascade);

        }


    }
}
