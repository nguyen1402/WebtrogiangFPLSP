using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts;

public class LessonCPConfiguration : IEntityTypeConfiguration<LessonCP>
{
    public void Configure(EntityTypeBuilder<LessonCP> builder)
    {


        builder.ToTable("LessonCP");
        builder.HasKey(x => x.Id);

        builder.Property(c => c.LessonCode).HasColumnName("LessonCode").HasMaxLength(10).IsRequired();
        builder.Property(c => c.LessonName).HasColumnName("LessonName").IsRequired();
        builder.Property(c => c.Descriptions).HasColumnName("Descriptions").HasMaxLength(100).IsRequired();
        builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

        builder.HasOne<SubjectCP>(entity => entity.SubjectCP)
                .WithMany(c => c.LessonCPs)
                .HasForeignKey(c => c.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);


    }
}