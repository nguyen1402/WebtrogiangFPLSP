using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class QuizQuestionsUPConfigarution : IEntityTypeConfiguration<QuizQuestionUP>
    {
        public void Configure(EntityTypeBuilder<QuizQuestionUP> builder)
        {


            builder.ToTable("QuestionUP");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.QuestionName).HasColumnName("QuestionName").HasMaxLength(100).IsRequired();
            builder.Property(c => c.QuestionCode).HasColumnName("QuestionCode").HasMaxLength(10).IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

            builder.HasOne<QuestionType>(c => c.QuestionTypes).WithMany(c => c.QuizQuestionUPs)
                .HasForeignKey(c => c.QuestionTypeId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
