using FPLSP.Server.Domain.Entities.UserParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class ClassUPConfigarution : IEntityTypeConfiguration<ClassUp>
    {
        public void Configure(EntityTypeBuilder<ClassUp> builder)
        {
            builder.ToTable("ClassUp");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedNever();
            builder.Property(c => c.ClassroomName).HasColumnName("ClassroomName").HasMaxLength(50).IsRequired();

            builder.Property(c => c.Building).HasColumnName("Building").HasMaxLength(10).IsRequired();

            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();




        }
    }
}
