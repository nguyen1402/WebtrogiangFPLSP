using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts;

public class LectureCPConfiguration : IEntityTypeConfiguration<LecturersCP>
{
    public void Configure(EntityTypeBuilder<LecturersCP> builder)
    {
        builder.ToTable("Lecturers");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.LecturersCode).HasColumnName("LecturersCode").HasMaxLength(10);
        builder.Property(c => c.LecturersName).HasColumnName("LecturersName").HasMaxLength(50);
        builder.Property(c => c.Gender).HasColumnName("Gender");
        builder.Property(c => c.Dob).HasColumnName("Dob");
        builder.Property(c => c.Email).HasColumnName("Email").HasMaxLength(250).IsRequired();
        builder.Property(c => c.PhoneNumber).HasColumnName("PhoneNumber").HasMaxLength(10);
        builder.Property(c => c.Address).HasColumnName("Address").HasMaxLength(100);
        builder.Property(c => c.IdentityCard).HasColumnName("IdentityCard").HasMaxLength(12);
        builder.Property(c => c.IssuedOn).HasColumnName("IssuedOn");
        builder.Property(c => c.Ethnic).HasColumnName("Ethnic").HasMaxLength(20);
        builder.Property(c => c.ImageUrl).HasColumnName("ImageUrl").HasMaxLength(100);
        builder.Property(c => c.YearsOfExperience).HasColumnName("YearsOfExperience");
        builder.Property(c => c.HomeTown).HasColumnName("HomeTown").HasMaxLength(100);
        builder.Property(c => c.Description).HasColumnName("Description").HasMaxLength(100);
        builder.Property(c => c.PassWord).HasColumnName("PassWord").HasMaxLength(30);
        builder.Property(c => c.Status).HasColumnName("Status");

        builder.HasOne<RoleCP>(c => c.RoleCPs)
            .WithMany(c => c.Lecturers)
            .HasForeignKey(c => c.RoleId)
            .OnDelete(DeleteBehavior.Cascade);



        builder.HasOne<TrainingFacilitiesCP>(c => c.trainingFacilitiesCP)
            .WithMany(c => c.lecturersCPs)
            .HasForeignKey(c => c.TrainingFacilitiesId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}