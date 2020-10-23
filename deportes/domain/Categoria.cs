using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deportes.domain
{
    public class Categoria
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }

        public Producto Producto { get; set; }
        private Guid idProducto;
    }
}
