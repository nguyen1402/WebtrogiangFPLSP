using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.CoreParts
{
    public class KindoOfQuestionCPConfiguration : IEntityTypeConfiguration<KindoOfQuestionCP>
    {

        public void Configure(EntityTypeBuilder<KindoOfQuestionCP> builder)
        {


            builder.ToTable("KindoOfQuestionCP");
            builder.HasKey(x => x.Id);

            builder.Property(c => c.QuestionTypeName).HasColumnName("QuestionTypeName").HasMaxLength(30).IsRequired();




        }
    }
}
