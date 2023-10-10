using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public static class ProductoData
    {
        public static Producto obtenerProducto(int id)
        {
            using (var context = new Contexto())
            {
                return context.Productos.FirstOrDefault(x => x.Id == id);
            }
        }

        public static List<Producto> ListarProductos()
        {
            using (var context = new Contexto())
            {
                return context.Productos.ToList();
            }
        }
        public static void CrearProducto(Producto producto)
        {
            using (var context = new Contexto())
            {
                context.Productos.Add(producto);
                context.SaveChanges();
            }
        }
        public static void modificarProducto(int id, Producto productoNuevo)
        {
            using (var context = new Contexto())
            {
                var productoActual = context.Productos.FirstOrDefault(x => x.Id == id);
                if (productoActual != null)
                {
                    productoActual.Descripcion = productoNuevo.Descripcion;
                    productoActual.Costo = productoNuevo.Costo;
                    productoActual.PrecioVenta = productoNuevo.PrecioVenta;
                    productoActual.Stock = productoNuevo.Stock;
                    context.SaveChanges();
                }
            }
        }
        public static void deleteProducto(int id)
        {
            using (var context = new Contexto())
            {
                var productoActual = context.Productos.FirstOrDefault(x => x.Id == id);
                if (productoActual != null)
                {
                    context.Productos.Remove(productoActual);
                    context.SaveChanges();
                }
            }
        }
    }

}
