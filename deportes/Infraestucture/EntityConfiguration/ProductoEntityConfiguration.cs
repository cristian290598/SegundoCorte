using deportes.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deportes.Infraestucture.EntityConfiguration
{
    public class ProductoEntityConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> productoConfiguration)
        {
            productoConfiguration.HasKey(p => p.id);

            productoConfiguration.Property(p => p.Nombre)
                .HasMaxLength(20)
                .IsRequired(true);
            productoConfiguration.Property(p => p.Precio)
                .HasMaxLength(1500000);
            
        }
    }
}
