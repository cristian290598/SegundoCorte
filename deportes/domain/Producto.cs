using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deportes.domain
{
    public class Producto
    {
        public Guid id { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }

    }
}
