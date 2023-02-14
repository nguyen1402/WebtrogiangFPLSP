using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.FPLExamConfigs
{
    public class ExaminationRoomDetailConfiguration : IEntityTypeConfiguration<ExaminationRoomDetail>
    {

        public void Configure(EntityTypeBuilder<ExaminationRoomDetail> builder)
        {
            builder.ToTable("ExaminationRoomDetail");
            builder.HasKey(x => new { x.SecretKey, x.IdExaminationRoom });

            builder.Property(c => c.IndexOfExaminationRoomDetail).HasColumnName("IndexOfExaminationRoomDetail").IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.Property(c => c.SecretKey).HasColumnName("SecretKey").IsRequired();

            builder.Property(c => c.Note).HasColumnName("Note").IsRequired(false);







            builder.HasOne<ExamStorage>(c => c.ExamStorage)
    .WithMany(c => c.ExaminationRoomDetails)
    .HasForeignKey(c => c.IdExamFile)
    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<SemesterBlock>(c => c.SemesterBlock)
.WithMany(c => c.ExaminationRoomDetails)
.HasForeignKey(c => new { c.IdBlock, c.IdSemester });

            builder.HasOne<ExaminationRoom>(c => c.ExaminationRoom)
         .WithMany(c => c.ExaminationRoomDetails)
         .HasForeignKey(c => c.IdExaminationRoom)
         .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<SubjectUP>(c => c.SubjectUP)
    .WithMany(c => c.ExaminationRoomDetails)
    .HasForeignKey(c => c.IdSubject)
    .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
