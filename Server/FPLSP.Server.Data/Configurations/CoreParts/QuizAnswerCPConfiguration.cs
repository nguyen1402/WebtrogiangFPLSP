using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts
{
    public class QuizAnswerCPConfiguration : IEntityTypeConfiguration<QuizAnswerCP>
    {

        public void Configure(EntityTypeBuilder<QuizAnswerCP> builder)
        {


            builder.ToTable("QuizAnswerCP");
            builder.HasKey(x => x.Id);

            builder.Property(c => c.Answer).HasColumnName("Answer").HasMaxLength(200).IsRequired();
            builder.Property(c => c.IsCorrect).HasColumnName("IsCorrect").IsRequired();


            builder.HasOne<QuizQuestionCP>(entity => entity.QuizQuestionCP)
                    .WithMany(c => c.QuizAnswerCp)
                    .HasForeignKey(c => c.IdQuizQuestion)
                    .OnDelete(DeleteBehavior.Cascade);


        }

    }
}
