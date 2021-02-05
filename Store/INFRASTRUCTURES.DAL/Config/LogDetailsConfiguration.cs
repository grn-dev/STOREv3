using CORE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace INFRASTRUCTURES.DAL.Config
{
    public class LogDetailsConfiguration: IEntityTypeConfiguration<LogDetails>
    { 
        public void Configure(EntityTypeBuilder<LogDetails> builder)
        { 
            builder.Property(c => c.IP).HasMaxLength(15);
            //builder.Property(c => c.description).HasMaxLength(30);
        }
    }
}
