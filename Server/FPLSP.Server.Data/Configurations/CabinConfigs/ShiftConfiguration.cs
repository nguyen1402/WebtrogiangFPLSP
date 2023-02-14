using FPLSP.Server.Domain.Entities.CabinProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CabinConfigs
{
    public class ShiftConfiguration : IEntityTypeConfiguration<Shift>
    {
        public void Configure(EntityTypeBuilder<Shift> builder)
        {

            builder.ToTable("ShiftOfCabin");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ShiftName).HasColumnName("ShiftName").IsRequired();
            builder.Property(c => c.IndexOfShift).HasColumnName("IndexOfShift").IsRequired();
            builder.Property(c => c.StartTime).HasColumnName("StartTime").HasColumnType("time(0)").IsRequired();
            builder.Property(c => c.EndTime).HasColumnName("EndTime").HasColumnType("time(0)").IsRequired();


            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

        }


    }
}
