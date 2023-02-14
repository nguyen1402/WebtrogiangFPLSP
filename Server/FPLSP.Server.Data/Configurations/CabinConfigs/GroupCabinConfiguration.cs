using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CabinConfigs
{
    public class GroupCabinConfiguration : IEntityTypeConfiguration<GroupCabin>
    {
        public void Configure(EntityTypeBuilder<GroupCabin> builder)
        {



            builder.ToTable("GroupCabin");
            builder.HasKey(c => new { c.IdCabin, c.IdSpec });
            builder.Property(c => c.GroupCabinName).HasColumnName("GroupCabinName").IsRequired();
            builder.Property(c => c.DateOfGrouping).HasColumnName("DateOfGrouping").IsRequired();
            builder.Property(c => c.StartTime).HasColumnName("StartTime").IsRequired();
            builder.Property(c => c.EndTime).HasColumnName("EndTime").IsRequired();
            builder.Property(c => c.IndexOfGroupCabin).HasColumnName("IndexOfGroupCabin").IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            //
            builder.HasOne<Cabin>(c => c.Cabin)
              .WithMany(c => c.GroupCabins)
              .HasForeignKey(c => c.IdCabin)
              .OnDelete(DeleteBehavior.Restrict);
            //Shift
            builder.HasOne<SpecializedUP>(c => c.SpecializedUP)
           .WithMany(c => c.GroupCabins)
           .HasForeignKey(c => c.IdSpec)
           .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
