using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.Seguridad;
using System.Data.Entity;

namespace Modelos.BusinessLogic
{
    public class UsuarioLogic
    {
        private SeguridadMD5 M_Seguridad = new SeguridadMD5();
        public List<Usuario> Listar()
        {
            try
            {
                using (var ctx = new DbTeam())
                {
                    return ctx.Usuario.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario Obtener(string strUsuario, string strPass, string strEmpresa)
        {
            try
            {
                strPass = M_Seguridad.Encriptar(strPass);
                using (var ctx = new DbTeam())
                {
                    return ctx.Usuario.Where(x => x.Us_Usuario == strUsuario && x.Us_Password == strPass && x.Us_Empresa == strEmpresa).SingleOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario Consegir(string strUsuarios)
        {
            try
            {
                using (var ctx = new DbTeam())
                {
                    return ctx.Usuario.Where(x => x.Us_Usuario == strUsuarios).SingleOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario Obtener2(int id)
        {
            try
            {
                using (var ctx = new DbTeam())
                {
                    return ctx.Usuario.Where(x=>x.Us_Id==id).SingleOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }  
        }
           

        public void Guardar(Usuario Usr)
        {

            try
            {
                Usr.Us_Password = M_Seguridad.Encriptar(Usr.Us_Password);
                using (var ctx = new DbTeam())
                {
                    if (ctx.Usuario.Count() == 0)
                        Usr.Us_Id = 1;
                    else
                        Usr.Us_Id = ctx.Usuario.Max(x => x.Us_Id) + 1;
                    ctx.Usuario.Add(Usr);
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
                    var vBase = ctx.Usuario.Where(x => x.Us_Id == id).SingleOrDefault();
                    ctx.Usuario.Remove(vBase);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Actualizar(Usuario Usr)
        {
            try
            {
                Usr.Us_Password = M_Seguridad.Encriptar(Usr.Us_Password.Trim());
                using (var ctx = new DbTeam())
                {
                    ctx.Entry(Usr).State = EntityState.Modified;
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