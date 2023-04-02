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
    public class KitapConfiguration : IEntityTypeConfiguration<Kitap>
    {
        public void Configure(EntityTypeBuilder<Kitap> builder)
        {
            builder.Property(x => x.Ad)
                .HasMaxLength(400);
        }
    }
}
