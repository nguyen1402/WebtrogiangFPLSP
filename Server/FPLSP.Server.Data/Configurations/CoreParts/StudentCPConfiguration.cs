using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts;

public class StudentCPConfiguration : IEntityTypeConfiguration<StudentCP>
{
    public void Configure(EntityTypeBuilder<StudentCP> builder)
    {
        builder.ToTable("StudentCP");
        builder.HasKey(c => c.Id);

        builder.Property(c => c.StudentCode).HasColumnName("StudentCode").HasMaxLength(10).IsRequired();
        builder.Property(c => c.StudentName).HasColumnName("StudentName").HasMaxLength(50).IsRequired();
        builder.Property(c => c.Gender).HasColumnName("Gender").IsRequired();
        builder.Property(c => c.DateOfBirth).HasColumnName("DateOfBirth").IsRequired();
        builder.Property(c => c.Email).HasColumnName("Email").HasMaxLength(250).IsRequired();
        builder.Property(c => c.PhoneNumber).HasColumnName("PhoneNumber").HasMaxLength(10).IsRequired();
        builder.Property(c => c.Address).HasColumnName("Address").HasMaxLength(100).IsRequired();
        builder.Property(c => c.IdentityCardNumber).HasColumnName("IdentityCardNumber").HasMaxLength(9).IsRequired();
        builder.Property(c => c.IssuedOn).HasColumnName("IssuedOn").IsRequired();
        builder.Property(c => c.Ethnic).HasColumnName("Ethnic").HasMaxLength(20).IsRequired();
        builder.Property(c => c.ImageUrl).HasColumnName("ImageUrl").HasMaxLength(100).IsRequired();
        builder.Property(c => c.FathersName).HasColumnName("FathersName").HasMaxLength(50).IsRequired();
        builder.Property(c => c.MotherName).HasColumnName("MotherName").HasMaxLength(50).IsRequired();
        builder.Property(c => c.HomeTown).HasColumnName("HomeTown").HasMaxLength(100).IsRequired();
        builder.Property(c => c.Description).HasColumnName("Description").HasMaxLength(100).IsRequired();
        builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

        builder.HasOne<TrainingFacilitiesCP>(c => c.trainingFacilitiesCP)
            .WithMany(c => c.studentCPs).HasForeignKey(c => c.TrainingFacilitiesId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}