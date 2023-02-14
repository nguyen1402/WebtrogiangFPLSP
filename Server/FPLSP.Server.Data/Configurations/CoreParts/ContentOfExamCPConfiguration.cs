using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts;

public class ContentOfExamCPConfiguration : IEntityTypeConfiguration<ContentOfExamCP>
{
    public void Configure(EntityTypeBuilder<ContentOfExamCP> builder)
    {
        builder.ToTable("ContentOfExamCP");
        builder.HasKey(x => x.Id);

        builder.Property(c => c.CoeCode).HasColumnName("CoeCode").HasMaxLength(10).IsRequired();
        builder.Property(c => c.Level).HasColumnName("Level").HasMaxLength(1).IsRequired();
        builder.Property(c => c.CreatedTime).HasColumnName("CreatedTime").IsRequired();
        builder.Property(c => c.DateStarted).HasColumnName("DateStarted").IsRequired();
        builder.Property(c => c.EndDate).HasColumnName("EndDate").IsRequired();
        builder.Property(c => c.TotalOfQuestions).HasColumnName("TotalOfQuestions").HasColumnType("INTEGER").IsRequired();
        builder.Property(c => c.QuestionType).HasColumnName("QuestionType").HasColumnType("INTEGER").IsRequired();
        builder.Property(c => c.Content).HasColumnName("Content").HasMaxLength(100).IsRequired();
        builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

        builder.HasOne<ExamCP>(c => c.ExamCP)
            .WithMany(c => c.contentOfExamCPs)
            .HasForeignKey(c => c.ExamId)
            .OnDelete(DeleteBehavior.Cascade);

    }
}