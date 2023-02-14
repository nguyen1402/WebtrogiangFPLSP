using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts;

public class ContentOfLessonCPConfiguration : IEntityTypeConfiguration<LessonContentCP>
{
    public void Configure(EntityTypeBuilder<LessonContentCP> builder)
    {

        builder.ToTable("LessonContentCP");
        builder.HasKey(x => x.Id);
        builder.Property(c => c.Content).HasColumnName("Content").IsRequired();
        builder.Property(c => c.LessonContentCode).HasColumnName("LessonContentCode").HasMaxLength(10).IsRequired();
        builder.Property(c => c.LessonContentName).HasColumnName("LessonContentName").IsRequired();
        builder.Property(c => c.Descriptions).HasColumnName("Descriptions").HasMaxLength(100).IsRequired();
        builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

        builder.HasOne<LessonCP>(entity => entity.LessonCP)
        .WithMany(c => c.LessonContentCPs)
        .HasForeignKey(c => c.IdLesson)
        .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne<ResourceLink>(entity => entity.ResourceLinks)
          .WithMany(entity => entity.LessonContentCPs)
          .HasForeignKey(entity => entity.ResourceLinkId)
          .OnDelete(DeleteBehavior.Cascade);
    }
}