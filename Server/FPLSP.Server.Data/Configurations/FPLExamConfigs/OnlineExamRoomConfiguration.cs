using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.FPLExam;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.FPLExamConfigs
{
    public class OnlineExamRoomConfiguration : IEntityTypeConfiguration<OnlineExamRoom>
    {

        public void Configure(EntityTypeBuilder<OnlineExamRoom> builder)
        {
            builder.ToTable("OnlineExamRoom");
            builder.HasKey(x => new { x.IdUser, x.SecretKey, x.IdExaminationRoom });

            builder.Property(c => c.ChekinImage).HasColumnName("ChekinImage").IsRequired(false);
            builder.Property(c => c.Note).HasColumnName("Note").IsRequired(false);

            builder.HasOne<ExaminationRoomDetail>(c => c.ExaminationRoomDetail)
                       .WithMany(c => c.onlineExamRooms)
                       .HasForeignKey(c => new { c.SecretKey, c.IdExaminationRoom })
                       .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<UserSignIn>(c => c.UserSignIn)
                     .WithMany(c => c.onlineExamRooms)
                     .HasForeignKey(c => c.IdUser)
                     .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
