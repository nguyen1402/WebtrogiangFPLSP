using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class StudentQuizUPConfigarution : IEntityTypeConfiguration<StudentQuizUP>
    {
        public void Configure(EntityTypeBuilder<StudentQuizUP> builder)
        {
            builder.ToTable("StudentQuizUP");
            builder.HasKey(c => new { c.StudentId, c.QuizId });
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.Property(c => c.ScoreQuizOfStudent).HasColumnName("Score").HasDefaultValue(0);
            builder.HasOne<QuizUP>(c => c.QuizUP)
                .WithMany(c => c.StudentQuizUps)
                .HasForeignKey(c => c.QuizId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<StudentUP>(c => c.StudentUp)
                .WithMany(c => c.StudentQuizUPs)
                .HasForeignKey(c => c.StudentId)
                .OnDelete(DeleteBehavior.Restrict);






        }
    }
}
