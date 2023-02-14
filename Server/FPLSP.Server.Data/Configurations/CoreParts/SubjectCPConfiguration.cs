using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts;

public class SubjectCPConfiguration : IEntityTypeConfiguration<SubjectCP>
{
    public void Configure(EntityTypeBuilder<SubjectCP> builder)
    {
        builder.ToTable("SubjectCP");
        builder.HasKey(x => x.Id);
        builder.Property(c => c.SubjectCode).HasColumnName("SubjectCode").HasMaxLength(10).IsRequired();
        builder.Property(c => c.SubjectName).HasColumnName("SubjectName").HasMaxLength(100).IsRequired();
        builder.Property(c => c.CreatedDay).HasColumnName("CreatedDay").IsRequired();
        builder.Property(c => c.StartDay).HasColumnName("StartDay").IsRequired();
        builder.Property(c => c.EndDay).HasColumnName("EndDay").IsRequired();
        builder.Property(c => c.TotalOfSub).HasColumnName("TotalOfSub").IsRequired();
        builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
        builder.Property(c => c.Image).HasColumnName("Image").HasMaxLength(100).IsRequired();
    }
}