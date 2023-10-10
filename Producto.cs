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

        public Producto(long id, string descripcion, string costo, double precioVenta, double stock)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Costo = costo;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;

        }

    }
}
