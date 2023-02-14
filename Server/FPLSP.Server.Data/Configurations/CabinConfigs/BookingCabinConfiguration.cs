using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.UserParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CabinConfigs
{
    public class BookingCabinConfiguration : IEntityTypeConfiguration<BookingCabin>
    {
        public void Configure(EntityTypeBuilder<BookingCabin> builder)
        {

            builder.ToTable("BookingCabin");
            builder.HasKey(c => new { c.Id, c.SubjectId, c.ClassId, c.IdCabin, c.IdShift });
            builder.Property(c => c.CheckinImage).HasColumnName("CheckinImage").IsRequired(false);
            builder.Property(c => c.CheckinTime).HasColumnName("CheckinTime").IsRequired();
            builder.Property(c => c.CheckoutTime).HasColumnName("CheckoutTime").IsRequired();
            builder.Property(c => c.IdLectuter).HasColumnName("IdLectuter").IsRequired();
            builder.Property(c => c.IndexOfBookingCabin).HasColumnName("IndexOfBookingCabin").IsRequired();
            builder.Property(c => c.Note).HasColumnName("Note").IsRequired(false);
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            //
            builder.HasOne<SubjectClassUP>(c => c.SubjectClassUP)
              .WithMany(c => c.BookingCabins)
              .HasForeignKey(c => new { c.SubjectId, c.ClassId })
              .OnDelete(DeleteBehavior.Restrict);
            //cabin
            builder.HasOne<Cabin>(c => c.Cabin)
           .WithMany(c => c.BookingCabins)
           .HasForeignKey(c => c.IdCabin)
           .OnDelete(DeleteBehavior.Restrict);
            //Shift
            builder.HasOne<Shift>(c => c.Shift)
           .WithMany(c => c.BookingCabins)
           .HasForeignKey(c => c.IdShift)
           .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
