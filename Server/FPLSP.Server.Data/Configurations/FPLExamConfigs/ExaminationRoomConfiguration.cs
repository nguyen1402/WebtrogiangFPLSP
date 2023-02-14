using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.FPLExam;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.FPLExamConfigs
{
    public class ExaminationRoomConfiguration : IEntityTypeConfiguration<ExaminationRoom>
    {

        public void Configure(EntityTypeBuilder<ExaminationRoom> builder)
        {
            builder.ToTable("ExaminationRoom");
            builder.HasKey(x => x.Id);

            builder.Property(c => c.ExaminationRoomName).HasColumnName("ExaminationRoomName").IsRequired(false);
            builder.Property(c => c.CreateTime).HasColumnName("CreateTime").IsRequired();
            builder.Property(c => c.IndexOfExaminationRoom).HasColumnName("IndexOfExaminationRoom").IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();


            builder.HasOne<TrainingFacilitiesCP>(c => c.TrainingFacilitiesCPs)
                .WithMany(c => c.examinationRooms)
                .HasForeignKey(c => c.IdTrainingFacility)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
