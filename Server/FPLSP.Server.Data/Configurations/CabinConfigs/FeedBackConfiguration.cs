using FPLSP.Server.Domain.Entities.Cabin;
using FPLSP.Server.Domain.Entities.UserParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Data.Configurations.CabinConfigs
{
    public class FeedBackConfiguration : IEntityTypeConfiguration<FeedBack>
    {

        public void Configure(EntityTypeBuilder<FeedBack> builder)
        {

        
            builder.ToTable("FeedBack");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.IndexOfFeedBack).HasColumnName("IndexOfFeedBack").IsRequired();
            builder.Property(c => c.Note).HasColumnName("Note").IsRequired();
            builder.Property(c => c.FeedBackTime).HasColumnName("FeedBackTime").IsRequired();
            builder.Property(c => c.FeedBackTime).HasColumnName("FeedBackTime").IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            //
            builder.HasOne<SubjectClassUP>(c => c.SubjectClassUP)
            .WithMany(c => c.FeedBacks)
            .HasForeignKey(c => new { c.SubjectId, c.ClassId })
            .OnDelete(DeleteBehavior.Restrict);
            //
            builder.HasOne<StudentUP>(c => c.StudentUP)
         .WithMany(c => c.FeedBacks)
         .HasForeignKey(c =>c.IdStudent)
         .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
