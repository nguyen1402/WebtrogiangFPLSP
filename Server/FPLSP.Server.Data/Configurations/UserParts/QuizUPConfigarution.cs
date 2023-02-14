using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class QuizUPConfigarution : IEntityTypeConfiguration<QuizUP>
    {
        public void Configure(EntityTypeBuilder<QuizUP> builder)
        {
            builder.ToTable("QuizUP");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.QuizTitle).HasColumnName("QuizTitle").HasMaxLength(100).IsRequired();
            //builder.Property(c => c.QuizTime).IsRequired();
            builder.Property(c => c.StartDay).HasColumnName("StartDay").IsRequired();
            builder.Property(c => c.EndDay).HasColumnName("EndDay").IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.Property(c => c.QuizName).HasColumnName("QuizName").HasMaxLength(100).IsRequired();
            builder.Property(c => c.Descriptions).HasColumnName("Descriptions").HasMaxLength(100).IsRequired();


            builder.HasOne<SubjectUP>(c => c.SubjectUp)
                .WithMany(c => c.QuizUPs)
                .HasForeignKey(c => c.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
