using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class VentaData
    {
        private readonly DbContext _dbContext;

        public VentaData(DbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public Venta ObtenerVenta(int id)
        {
            return _dbContext.Set<Venta>().FirstOrDefault(v => v.Id == id);
        }

        public List<Venta> ListarVentas()
        {
            return _dbContext.Set<Venta>().ToList();
        }

        public void CrearVenta(Venta nuevaVenta)
        {
            if (nuevaVenta == null)
                throw new ArgumentNullException(nameof(nuevaVenta));

            _dbContext.Set<Venta>().Add(nuevaVenta);
            _dbContext.SaveChanges();
        }

        public void ModificarVenta(Venta ventaModificada)
        {
            if (ventaModificada == null)
                throw new ArgumentNullException(nameof(ventaModificada));

            _dbContext.Entry(ventaModificada).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void EliminarVenta(int id)
        {
            var venta = _dbContext.Set<Venta>().FirstOrDefault(v => v.Id == id);
            if (venta != null)
            {
                _dbContext.Set<Venta>().Remove(venta);
                _dbContext.SaveChanges();
            }
        }
    }
}
