using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class VideoHistoryConfiguration : IEntityTypeConfiguration<VideoHistory>
    {
        public void Configure(EntityTypeBuilder<VideoHistory> builder)
        {
            builder.ToTable("VideoHistory");
            builder.HasKey(c => new { c.IdStudent, c.IdLessonContent });
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.Property(c => c.IsBookMarked).HasColumnName("IsBookMarked").IsRequired();
            builder.Property(c => c.TimeOfSaveHistory).HasColumnName("TimeOfSaveHistory").IsRequired();
            builder.Property(c => c.WatchedTime).HasColumnName("WatchedTime").IsRequired();

            builder.HasOne<StudentUP>(c => c.StudentUP)
                .WithMany(c => c.VideoHistories)
                .HasForeignKey(c => c.IdStudent)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<LessonContentUP>(c => c.LessonContentUP)
                .WithMany(c => c.VideoHistories)
                .HasForeignKey(c => c.IdLessonContent)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
