using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class TakeAnswerUPConfigarution : IEntityTypeConfiguration<TakeAnswerUP>
    {
        //a
        public void Configure(EntityTypeBuilder<TakeAnswerUP> builder)
        {
            //
            builder.ToTable("TakeAnswerUP");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.TakeAnswers).HasConversion(
            v => JsonConvert.SerializeObject(v),
            v => JsonConvert.DeserializeObject<Dictionary<Guid, Guid>>(v)).IsRequired();

            builder.HasOne<QuizQuestionUP>(c => c.QuizQuestionUP).WithMany(c => c.TakeAnswerUPs)
                .HasForeignKey(c => c.QuestionId).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<StudentQuizUP>(c => c.StudentQuizUp).WithMany(c => c.TakeAnswerUP)
            .HasForeignKey(c => new { c.StudentId, c.QuizId }).OnDelete(DeleteBehavior.Cascade);
        }
    }
}

