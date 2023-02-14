using FPLSP.Server.Domain.Entities.UserParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class StudentUPConfigarution : IEntityTypeConfiguration<StudentUP>
    {
        public void Configure(EntityTypeBuilder<StudentUP> builder)
        {
            builder.ToTable("StudentUP");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.StudentCode).HasColumnName("StudentCode").HasMaxLength(10);
            builder.Property(c => c.StudentName).HasColumnName("StudentName").HasMaxLength(50);
            builder.Property(c => c.Gender).HasColumnName("Gender");
            builder.Property(c => c.DateOfBirth).HasColumnName("DateOfBirth");
            builder.Property(c => c.Email).HasColumnName("Email").HasMaxLength(250);
            builder.Property(c => c.PhoneNumber).HasColumnName("PhoneNumber").HasMaxLength(10);
            builder.Property(c => c.Address).HasColumnName("Address").HasMaxLength(100);
            builder.Property(c => c.IdentityCardNumber).HasColumnName("IdentityCardNumber").HasMaxLength(12);
            builder.Property(c => c.IssuedOn).HasColumnName("IssuedOn");
            builder.Property(c => c.Ethnic).HasColumnName("Ethnic").HasMaxLength(20);
            builder.Property(c => c.ImageUrl).HasColumnName("ImageUrl").HasMaxLength(100);
            builder.Property(c => c.FathersName).HasColumnName("FathersName").HasMaxLength(50);
            builder.Property(c => c.MotherName).HasColumnName("MotherName").HasMaxLength(50);
            builder.Property(c => c.HomeTown).HasColumnName("HomeTown").HasMaxLength(100);
            builder.Property(c => c.Description).HasColumnName("Description").HasMaxLength(100);
            builder.Property(c => c.Status).HasColumnName("Status");


        }
    }
}
