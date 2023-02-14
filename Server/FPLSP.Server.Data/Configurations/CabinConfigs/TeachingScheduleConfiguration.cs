using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CabinConfigs
{
    public class TeachingScheduleConfiguration : IEntityTypeConfiguration<TeachingSchedule>
    {
        public void Configure(EntityTypeBuilder<TeachingSchedule> builder)
        {



            builder.ToTable("TeachingSchedule");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ImportTime).HasColumnName("ImportTime").IsRequired();
            builder.Property(c => c.IdAdminImport).HasColumnName("IdAdminImport").IsRequired();
            builder.Property(c => c.IndexOfTeachingSchedule).HasColumnName("IndexOfTeachingSchedule").IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.Property(c => c.Remote).HasColumnName("Remote").IsRequired();
            builder.Property(c => c.Note).HasColumnName("Note").IsRequired();
            //
            builder.HasOne<SubjectClassUP>(c => c.SubjectClassUP)
           .WithMany(c => c.TeachingSchedules)
           .HasForeignKey(c => new { c.SubjectId, c.ClassId })
           .OnDelete(DeleteBehavior.Restrict);
            //
            builder.HasOne<Shift>(c => c.Shift)
          .WithMany(c => c.TeachingSchedules)
          .HasForeignKey(c => c.IdShift)
          .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<SemesterBlock>(c => c.SemesterBlock)
        .WithMany(c => c.TeachingSchedules)
        .HasForeignKey(c => new { c.IdBlock, c.IdSemester })
        .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<TrainingFacilitiesCP>(c => c.TrainingFacilitiesCPs)
          .WithMany(c => c.teachingSchedules)
          .HasForeignKey(c => c.IdTrainingFacility)
          .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne<LecturersCP>(c => c.LecturersCP)
        .WithMany(c => c.TeachingSchedules)
        .HasForeignKey(c => c.IdLecturter)
        .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
