using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.FPLExamConfigs
{
    public class SubjectTeacherConfiguration : IEntityTypeConfiguration<SubjectTeacher>
    {

        public void Configure(EntityTypeBuilder<SubjectTeacher> builder)
        {
            builder.ToTable("SubjectTeacher");
            builder.HasKey(x => new { x.IdTeacher, x.IdSubject });

            builder.Property(c => c.AddingTime).HasColumnName("AddingTime").IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();








            builder.HasOne<LecturersCP>(c => c.LecturersCP)
    .WithMany(c => c.SubjectTeachers)
    .HasForeignKey(c => c.IdTeacher)
    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<SubjectUP>(c => c.SubjectUP)
.WithMany(c => c.SubjectTeachers)
.HasForeignKey(c => c.IdSubject);




        }
    }
}
