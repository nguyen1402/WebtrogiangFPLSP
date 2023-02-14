using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class LessonUPConfigarution : IEntityTypeConfiguration<LessonUP>
    {
        public void Configure(EntityTypeBuilder<LessonUP> builder)
        {
            builder.ToTable("LessonUP");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.LessonName).HasColumnName("LessonName").IsRequired();
            builder.Property(c => c.LessonCode).HasColumnName("LessonCode").HasMaxLength(10).IsRequired();
            builder.Property(c => c.Descriptions).HasColumnName("Descriptions").HasMaxLength(100).IsRequired();
            builder.Property(c => c.IsCompleted).HasColumnName("IsCompleted").IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

            builder.HasOne<SubjectUP>(c => c.SubjectUp).WithMany(c => c.LessonUps)
                .HasForeignKey(c => c.SubjectId).OnDelete(DeleteBehavior.Cascade);


        }
    }
}
