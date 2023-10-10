using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class UsuarioData
    {
        private readonly DbContext _dbContext;

        public UsuarioData(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Usuario ObtenerUsuario(int id)
        {
            return _dbContext.Set<Usuario>().FirstOrDefault(u => u.Id == id);
        }

        public List<Usuario> ListarUsuarios()
        {
            return _dbContext.Set<Usuario>().ToList();
        }

        public void CrearUsuario(Usuario nuevoUsuario)
        {
            _dbContext.Set<Usuario>().Add(nuevoUsuario);
            _dbContext.SaveChanges();
        }

        public void ModificarUsuario(Usuario usuarioModificado)
        {
            _dbContext.Entry(usuarioModificado).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void EliminarUsuario(int id)
        {
            var usuario = _dbContext.Set<Usuario>().FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                _dbContext.Set<Usuario>().Remove(usuario);
                _dbContext.SaveChanges();
            }
        }
    }
}
