using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class QuizQuestionQuizUPConfiguration : IEntityTypeConfiguration<QuizQuestionQuizUP>
    {

        public void Configure(EntityTypeBuilder<QuizQuestionQuizUP> builder)
        {
            builder.ToTable("QuizQuestionQuizUP");
            builder.HasKey(c => new { c.QuizQuestionId, c.QuizId });

            builder.HasOne<QuizQuestionUP>(c => c.QuizQuestionUP)
                .WithMany(c => c.QuizQuestionQuizUPs)
                .HasForeignKey(c => c.QuizQuestionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<QuizUP>(c => c.QuizUP)
                .WithMany(c => c.QuizQuestionQuizUPs)
                .HasForeignKey(c => c.QuizId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
