using deportes.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deportes.Infraestucture.EntityConfiguration
{
    public class CategoriaEntityConfiguration : IEntityTypeConfiguration<Categoria>

    {
        public void Configure(EntityTypeBuilder<Categoria> CategoriaConfiguration)
        {
            CategoriaConfiguration.HasKey(c => c.Id);

            CategoriaConfiguration.Property(c => c.Nombre)
                .IsRequired(true);

            CategoriaConfiguration.Property<Guid>("Idproducto")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("ProductoId")
                .IsRequired(true);
            CategoriaConfiguration.HasOne(d => d.Producto)
                .WithMany()
                .HasForeignKey("IdProducto");
        }
    }
}
