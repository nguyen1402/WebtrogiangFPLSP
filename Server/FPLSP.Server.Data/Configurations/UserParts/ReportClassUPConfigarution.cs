using FPLSP.Server.Domain.Entities.UserParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class ReportClassUPConfigarution : IEntityTypeConfiguration<ReportClassUP>
    {
        public void Configure(EntityTypeBuilder<ReportClassUP> builder)
        {
            builder.ToTable("ReportClassUP");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Describe).HasColumnName("Describe").HasMaxLength(100).IsRequired();
            builder.Property(c => c.ReportAmount).HasColumnName("ReportAmount").HasColumnType("int").IsRequired();
            builder.Property(c => c.ReportLevel).HasColumnName("ReportLevel").HasColumnType("int").IsRequired();
            builder.Property(c => c.ReportDate).HasColumnName("ReportDate").IsRequired();
            builder.Property(c => c.Question).HasColumnName("Question").HasMaxLength(500).IsRequired();
            builder.Property(c => c.Answer).HasColumnName("Answer").HasMaxLength(500).IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

            builder.HasOne<ClassUp>(c => c.ClassUp)
                .WithMany(c => c.ReportClassUps)
                .HasForeignKey(c => c.ClassId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
