using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class ProductoVendidoData
    {
        private readonly DbContext _dbContext;

        public ProductoVendidoData(DbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public ProductoVendido ObtenerProductoVendido(int id)
        {
            return _dbContext.Set<ProductoVendido>().FirstOrDefault(v => v.Id == id);
        }

        public List<Producto> ListarProductoVendido()
        {
            return _dbContext.Set<Producto>().ToList();
        }

        public static List<ProductoVendido> ListProductosVendidos()
        {
            using (var context = new Contexto())
            {
                return context.ProductosVendidos.ToList();
            }
        }

        public static void crearProductoVendido(ProductoVendido productoVendido)
        {
            using (var context = new Contexto())
            {
                context.ProductosVendidos.Add(productoVendido);
                context.SaveChanges();
            }
        }

        public static void ModificarProductoVendido(int id, ProductoVendido
productoVendidoNuevo)
        {
            using (var context = new Contexto())
            {
                var productoVendidoActual = context.ProductosVendidos.FirstOrDefault(x => x.Id
                == id);
                if (productoVendidoActual != null)
                {
                    productoVendidoActual.IdVenta = productoVendidoNuevo.IdVenta;
                    productoVendidoActual.Stock = productoVendidoNuevo.Stock;
                    productoVendidoActual.IdProducto = productoVendidoNuevo.IdProducto;
                    context.SaveChanges();
                }
            }
        }

        public static void eliminarProductoVendido(int id)
        {
            using (var context = new Contexto())
            {
                var productoVendidoActual = context.ProductosVendidos.FirstOrDefault(x => x.Id
                == id);
                if (productoVendidoActual != null)
                {
                    context.ProductosVendidos.Remove(productoVendidoActual);
                    context.SaveChanges();
                }

            }
        }
    }
}

