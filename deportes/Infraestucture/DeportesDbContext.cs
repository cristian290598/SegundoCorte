using deportes.domain;
using deportes.Infraestucture.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deportes.Infraestucture
{
    public class DeportesDbContext : DbContext
    {
        public DeportesDbContext(DbContextOptions<DeportesDbContext>options): base(options)
        {
            
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto>Productos { get; set; }
        public object Categoria { get; internal set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductoEntityConfiguration());
            builder.ApplyConfiguration(new CategoriaEntityConfiguration());
        }
    }
}
