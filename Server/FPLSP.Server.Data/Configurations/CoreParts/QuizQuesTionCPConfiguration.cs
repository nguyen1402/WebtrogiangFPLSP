using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts
{
    public class QuizQuesTionCPConfiguration : IEntityTypeConfiguration<QuizQuestionCP>
    {

        public void Configure(EntityTypeBuilder<QuizQuestionCP> builder)
        {


            builder.ToTable("QuizQuestionCP");
            builder.HasKey(x => x.Id);

            builder.Property(c => c.QuestionCode).HasColumnName("QuestionCode").HasMaxLength(10).IsRequired();
            builder.Property(c => c.QuestionName).HasColumnName("QuestionName").HasMaxLength(50).IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();

            builder.HasOne<KindoOfQuestionCP>(entity => entity.KindoOfQuestionCP)
                    .WithMany(c => c.QuizQuestionCp)
                    .HasForeignKey(c => c.KindoOfQuestionId)
                    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
