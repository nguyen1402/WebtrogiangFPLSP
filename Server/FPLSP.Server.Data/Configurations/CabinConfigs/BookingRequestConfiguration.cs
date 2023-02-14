using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.UserParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CabinConfigs
{
    public class BookingRequestConfiguration : IEntityTypeConfiguration<BookingRequest>
    {
        public void Configure(EntityTypeBuilder<BookingRequest> builder)
        {

            builder.ToTable("BookingRequest");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.IndexOfBookingRequest).HasColumnName("IndexOfBookingRequest").IsRequired();
            builder.Property(c => c.SendingTime).HasColumnName("SendingTime").IsRequired();
            builder.Property(c => c.ContenOfFeedBack).HasColumnName("ContenOfFeedBack").IsRequired(false);
            builder.Property(c => c.FeedBackTime).HasColumnName("FeedBackTime").IsRequired();
            builder.Property(c => c.StartTime).HasColumnName("StartTime").IsRequired();
            builder.Property(c => c.EndTime).HasColumnName("EndTime").IsRequired();

            builder.Property(c => c.ContentOfRequest).HasColumnName("ContentOfRequest").IsRequired();

            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            //
            builder.HasOne<SubjectClassUP>(c => c.SubjectClassUP)
              .WithMany(c => c.BookingRequests)
              .HasForeignKey(c => new { c.SubjectId, c.ClassId })
              .OnDelete(DeleteBehavior.Restrict);
            //


        }

    }
}
