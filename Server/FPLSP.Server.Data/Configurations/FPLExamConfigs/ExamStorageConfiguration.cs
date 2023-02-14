using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.FPLExamConfigs
{
    public class ExamStorageConfiguration : IEntityTypeConfiguration<ExamStorage>
    {
        public void Configure(EntityTypeBuilder<ExamStorage> builder)
        {
            builder.ToTable("ExamStorage");
            builder.HasKey(x => x.Id);

            builder.Property(c => c.CreateTime).HasColumnName("CreateTime").IsRequired();
            builder.Property(c => c.ExamFile).HasColumnName("ExamFile").IsRequired(false);
            builder.Property(c => c.IndexOfExamStorageFile).HasColumnName("IndexOfExamStorageFile").IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.Property(c => c.Note).HasColumnName("Note").IsRequired(false);



            builder.HasOne<SubjectUP>(c => c.SubjectUP)
         .WithMany(c => c.ExamStorages)
         .HasForeignKey(c => c.SubjectId)
         .OnDelete(DeleteBehavior.Restrict);
            //
            builder.HasOne<UserSignIn>(c => c.UserSignIn)
     .WithMany(c => c.ExamStorages)
     .HasForeignKey(c => c.IdUserUpLoad)
     .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
