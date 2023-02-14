using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class LessonContentUPConfigarution : IEntityTypeConfiguration<LessonContentUP>
    {
        public void Configure(EntityTypeBuilder<LessonContentUP> builder)
        {
            builder.ToTable("LessonContentUP");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.LessonContentName).HasColumnName("LessonContentName").IsRequired();
            builder.Property(c => c.Content).HasColumnName("Content").HasMaxLength(500).IsRequired();
            builder.Property(c => c.Descriptions).HasColumnName("Descriptions").HasMaxLength(500);
            builder.Property(c => c.LessonContentCode).HasColumnName("LessonContentCode").HasMaxLength(10).IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

            builder.HasOne<LessonUP>(c => c.LessonUP).WithMany(c => c.LessonContentUps)
                .HasForeignKey(c => c.LessonId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne<ResourceLinkUP>(c => c.ResourceLinkUP).WithMany(c => c.LessonContentUP)
               .HasForeignKey(c => c.ResuorceLinkId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
