using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class AnswerUPConfigarution : IEntityTypeConfiguration<AnswerUP>
    {
        public void Configure(EntityTypeBuilder<AnswerUP> builder)
        {
            builder.ToTable("AnswerUP");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Answer).HasColumnName("Answer").HasMaxLength(500).IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

            builder.HasOne<QuizQuestionUP>(c => c.QuizQuestionUp).WithMany(c => c.AnswerUps)
                .HasForeignKey(c => c.QuizQuestionId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
