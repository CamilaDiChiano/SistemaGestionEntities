using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Producto
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }
        public string Costo { get; set;  }
        public double PrecioVenta { get; set; }
        public double Stock { get; set; }

    }
}
