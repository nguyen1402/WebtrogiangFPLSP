using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {

        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.ToTable("News");
            builder.HasKey(c => new { c.Id });
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.Property(c => c.Title).HasColumnName("Title").IsRequired();
            builder.Property(c => c.Content).HasColumnName("Content").IsRequired();
            builder.Property(c => c.Image).HasColumnName("Image");
            builder.Property(c => c.Title).HasColumnName("Title").IsRequired();

            builder.Property(c => c.CratedTime).HasColumnName("CratedTime").IsRequired();
            builder.Property(c => c.Priority).HasColumnName("Priority").IsRequired();


            builder.HasOne<SubjectClassUP>(c => c.SubjectClassUP)
                .WithMany(c => c.News)
                .HasForeignKey(c => new { c.IdSubject, c.IdClass })
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<LessonUP>(c => c.LessonUP)
              .WithMany(c => c.News)
              .HasForeignKey(c => c.IdLesson)
              .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<UserSignIn>(c => c.UserSignIn)
            .WithMany(c => c.News)
            .HasForeignKey(c => c.IdUser)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<TypeOfNewFeed>(c => c.TypeOfNewFeed)
           .WithMany(c => c.News)
           .HasForeignKey(c => c.IdTypeOfNewFeed)
           .OnDelete(DeleteBehavior.Restrict);

        }


    }
}
