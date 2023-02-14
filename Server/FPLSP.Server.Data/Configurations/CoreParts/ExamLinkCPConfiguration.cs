using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts;

public class ExamLinkCPConfiguration : IEntityTypeConfiguration<ExamLinkCP>
{
    public void Configure(EntityTypeBuilder<ExamLinkCP> builder)
    {
        builder.ToTable("ExamLinkCP");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.ExamLinkCode).HasColumnName("ExamLinkCode").HasMaxLength(10).IsRequired();
        builder.Property(c => c.Path).HasColumnName("Path").HasMaxLength(100).IsRequired();
        builder.Property(c => c.CreatedDay).HasColumnName("CreatedDay").IsRequired();
        builder.Property(c => c.ExpirationDate).HasColumnName("ExpirationDate").IsRequired();
        builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

        builder.HasOne<ExamCP>(c => c.examCP)
               .WithMany(c => c.examLinkCPs)
               .HasForeignKey(c => c.ExamId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}