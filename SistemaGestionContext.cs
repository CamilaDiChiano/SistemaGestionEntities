using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Contexto : DbContext
    {
        internal object venta;

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<ProductoVendido> ProductosVendidos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=SistemaGestionEF;Trusted_Connection=True")
                ;
            }
            catch (Exception excepcion)
            {
                Console.WriteLine(excepcion);
            }
        }
    }
}