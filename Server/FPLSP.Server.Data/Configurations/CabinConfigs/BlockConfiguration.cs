using FPLSP.Server.Domain.Entities.CabinProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CabinConfigs
{
    public class BlockConfiguration : IEntityTypeConfiguration<Block>
    {
        public void Configure(EntityTypeBuilder<Block> builder)
        {

            builder.ToTable("Block");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.NameOfBlock).HasColumnName("NameOfBlock").IsRequired();
            builder.Property(c => c.IndexOfBlock).HasColumnName("IndexOfBlock").IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();


        }

    }
}
