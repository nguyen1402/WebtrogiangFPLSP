using FPLSP.Server.Domain.Entities.CabinProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CabinConfigs
{
    public class SemesterBlockConfiguration : IEntityTypeConfiguration<SemesterBlock>
    {
        public void Configure(EntityTypeBuilder<SemesterBlock> builder)
        {
            builder.ToTable("SemesterBlock");
            builder.HasKey(c => new { c.IdBlock, c.IdSemester });
            builder.Property(c => c.StartTime).HasColumnName("StartTime").HasColumnType("date").IsRequired();
            builder.Property(c => c.EndTime).HasColumnName("EndTime").HasColumnType("date").IsRequired();
            builder.Property(c => c.IndexOfSemesterBlock).HasColumnName("IndexOfSemesterBlock").IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();



            builder.HasOne<Semester>(c => c.Semester)
           .WithMany(c => c.SemesterBlocks)
           .HasForeignKey(c => c.IdSemester)
           .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Block>(c => c.Block)
       .WithMany(c => c.SemesterBlocks)
       .HasForeignKey(c => c.IdBlock)
       .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
