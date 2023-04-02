using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Config
{
    public class YazarConfiguration : IEntityTypeConfiguration<Yazar>
    {
        public void Configure(EntityTypeBuilder<Yazar> builder)
        {
            builder.Property(x => x.Ad)
                .HasMaxLength(256);
        }
    }
}
