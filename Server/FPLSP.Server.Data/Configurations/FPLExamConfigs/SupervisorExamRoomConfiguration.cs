using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.FPLExam;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.FPLExamConfigs
{
    public class SupervisorExamRoomConfiguration : IEntityTypeConfiguration<SupervisorExamRoom>
    {

        public void Configure(EntityTypeBuilder<SupervisorExamRoom> builder)
        {
            builder.ToTable("SupervisorExamRoom");
            builder.HasKey(x => new { x.IdLecturter, x.SecretKey, x.IdExaminationRoom });


            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

            builder.Property(c => c.Note).HasColumnName("Note").IsRequired(false);
            builder.Property(c => c.IsMainSupervisor).HasColumnName("IsMainSupervisor").IsRequired();


            builder.HasOne<LecturersCP>(c => c.LecturersCP)
            .WithMany(c => c.SupervisorExamRooms)
            .HasForeignKey(c => c.IdLecturter)
            .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne<ExaminationRoomDetail>(c => c.ExaminationRoomDetail)
                     .WithMany(c => c.SupervisorExamRooms)
                     .HasForeignKey(c => new { c.SecretKey, c.IdExaminationRoom })
                     .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
