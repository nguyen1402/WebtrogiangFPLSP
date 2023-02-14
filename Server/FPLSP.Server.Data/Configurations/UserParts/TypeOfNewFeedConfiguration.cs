using FPLSP.Server.Domain.Entities.UserParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPLSP.Server.Data.Configurations.UserParts
{
    public class TypeOfNewFeedConfiguration : IEntityTypeConfiguration<TypeOfNewFeed>
    {
        public void Configure(EntityTypeBuilder<TypeOfNewFeed> builder)
        {
            builder.ToTable("TypeOfNewFeed");
            builder.HasKey(c => new { c.Id });
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.Property(c => c.Title).HasColumnName("Title").IsRequired();
            builder.Property(c => c.Priority).HasColumnName("Priority").IsRequired();



        }
    }
}