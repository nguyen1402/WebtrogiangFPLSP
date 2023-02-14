using FPLSP.Server.Domain.Entities.Cabin;
using FPLSP.Server.Domain.Entities.UserParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Data.Configurations.CabinConfigs
{
    public class FeedbackOutsideConfiguration :  IEntityTypeConfiguration<FeedBackOutSide>
    {


        public void Configure(EntityTypeBuilder<FeedBackOutSide> builder)
        {


            builder.ToTable("FeedBackOutSide");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").ValueGeneratedOnAdd();


        }


    }
}
