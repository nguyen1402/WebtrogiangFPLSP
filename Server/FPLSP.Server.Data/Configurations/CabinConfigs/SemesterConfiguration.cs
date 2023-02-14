using FPLSP.Server.Domain.Entities.CabinProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CabinConfigs
{
    public class SemesterConfiguration : IEntityTypeConfiguration<Semester>
    {
        public void Configure(EntityTypeBuilder<Semester> builder)
        {



            builder.ToTable("Semester");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.NameofSemester).HasColumnName("NameofSemester").IsRequired();
            builder.Property(c => c.IndexOfSemester).HasColumnName("IndexOfSemester").IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

        }


    }
}
