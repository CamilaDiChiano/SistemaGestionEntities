using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class ProductoVendido
    {
        public int Id { get; set; }
        public string IdProducto { get; set; }
        public double Stock { get; set; }
        public string IdVenta { get; set; }

        public ProductoVendido(int id, string idProducto, double stock, string idVenta)
        {
            this.Id = id;
            this.IdProducto = idProducto;
            this.Stock = stock;
            this.IdVenta = idVenta;

        }


    }
}
