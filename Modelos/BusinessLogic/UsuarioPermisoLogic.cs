using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.BusinessLogic
{
    public class UsuarioPermisoLogic
    {
        public List<UsuarioPermiso> Listar()
        {
            try
            {
                using (var ctx = new DbTeam())
                {
                    return ctx.UsuarioPermiso.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(UsuarioPermiso Usr)
        {
            try
            {
                using (var ctx= new DbTeam())
                {
                    ctx.UsuarioPermiso.Add(Usr);
                    ctx.SaveChanges();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using (var ctx = new DbTeam())
                {
                    var vUsr = ctx.UsuarioPermiso.Where(x => x.Us_id == id).SingleOrDefault();
                    ctx.UsuarioPermiso.Remove(vUsr);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public UsuarioPermiso Obtener(int id)
        {
            try
            {
                using (var ctx = new DbTeam())
                {
                    return ctx.UsuarioPermiso.Where(x => x.Us_id == id).SingleOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Actualizar(UsuarioPermiso Usr)
        {
            try
            {
                using (var ctx = new DbTeam())
                {
                    ctx.Entry(Usr).State=EntityState.Modified;
                    ctx.SaveChanges();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
