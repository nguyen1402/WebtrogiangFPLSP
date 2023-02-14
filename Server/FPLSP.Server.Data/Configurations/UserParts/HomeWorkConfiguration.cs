using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class HomeWorkConfiguration : IEntityTypeConfiguration<HomeWork>
    {
        public void Configure(EntityTypeBuilder<HomeWork> builder)
        {
            builder.ToTable("HomeWork");
            builder.HasKey(c => new { c.Id });

            builder.Property(c => c.LinkHomeWork).HasColumnName("LinkHomeWork").IsRequired();


            builder.HasOne<SubjectClassUP>(c => c.SubjectClassUP)
                .WithMany(c => c.HomeWorks)
                .HasForeignKey(c => new { c.IdSubject, c.IdClass })
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<UserSignIn>(c => c.UserSignIn)
            .WithMany(c => c.HomeWorks)
            .HasForeignKey(c => c.IdUser)
            .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne<LessonUP>(c => c.LessonUP)
            .WithMany(c => c.HomeWorks)
            .HasForeignKey(c => c.IdLesson)
            .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
