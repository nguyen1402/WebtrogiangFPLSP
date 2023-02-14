using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts;

public class QuizCPConfiguration : IEntityTypeConfiguration<QuizCP>
{
    public void Configure(EntityTypeBuilder<QuizCP> builder)
    {
        builder.ToTable("QuizCP");
        builder.HasKey(x => x.Id);
        builder.Property(c => c.QuizName).HasColumnName("QuizName").IsRequired();
        builder.Property(c => c.Descriptions).HasColumnName("Descriptions").IsRequired();

        builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
        builder.Property(c => c.MaxTurn).HasColumnName("MaxTurn").IsRequired();
        builder.Property(c => c.StartDay).HasColumnName("StartDay").IsRequired();
        builder.Property(c => c.EndDay).HasColumnName("EndDay").IsRequired();




        builder.HasOne<SubjectCP>(c => c.SubjectCP)
                .WithMany(c => c.QuizCps)
                .HasForeignKey(c => c.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);
    }
}