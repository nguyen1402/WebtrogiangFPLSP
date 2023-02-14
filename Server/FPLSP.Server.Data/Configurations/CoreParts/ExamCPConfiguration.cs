using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts;

public class ExamCPConfiguration : IEntityTypeConfiguration<ExamCP>
{
    public void Configure(EntityTypeBuilder<ExamCP> builder)
    {
        builder.ToTable("ExamCP");
        builder.HasKey(x => x.Id);
        builder.Property(c => c.ExamCode).HasColumnName("ExamCode").HasMaxLength(10).IsRequired();
        builder.Property(c => c.ExamName).HasColumnName("ExamName").HasMaxLength(50).IsRequired();
        builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
        builder.HasOne<SubjectCP>(c => c.subjectCP)
            .WithMany(c => c.ExamCPs)
            .HasForeignKey(c => c.SubjectId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}