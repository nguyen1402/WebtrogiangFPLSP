using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts
{
    public class QuizQuestionQuizCPConfiguration : IEntityTypeConfiguration<QuizQuestionQuizCP>
    {

        public void Configure(EntityTypeBuilder<QuizQuestionQuizCP> builder)
        {
            builder.ToTable("QuizQuestionQuizCP");
            builder.HasKey(c => new { c.QuizQuestionId, c.QuizId });
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.HasOne<QuizQuestionCP>(c => c.QuizQuestionCP)
                .WithMany(c => c.QuizQuestionQuizCPs)
                .HasForeignKey(c => c.QuizQuestionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<QuizCP>(c => c.QuizCP)
                .WithMany(c => c.QuizQuestionQuizCPs)
                .HasForeignKey(c => c.QuizId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
