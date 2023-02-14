using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class BookMarkConfiguration : IEntityTypeConfiguration<BookMarkClass>
    {
        public void Configure(EntityTypeBuilder<BookMarkClass> builder)
        {
            builder.ToTable("BookMarkClass");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.Property(c => c.Priority).HasColumnName("Priority").IsRequired();
            builder.Property(c => c.IsBookMark).HasColumnName("IsBookMark").IsRequired();



            builder.HasOne<SubjectClassUP>(c => c.SubjectClassUP)
          .WithMany(c => c.bookMarkClasses)
          .HasForeignKey(c => new { c.IdSubject, c.IdClass })
          .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne<UserSignIn>(c => c.UserSignIn)
            .WithMany(c => c.BookMarkClasses)
            .HasForeignKey(c => c.IdUser)
            .OnDelete(DeleteBehavior.Restrict);









        }

    }
}
