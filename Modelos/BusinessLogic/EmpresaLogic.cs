using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelos.BusinessLogic
{
    public class EmpresaLogic
    {
        public List<Empresa> Listar()
        {
            try
            {
                using (var ctx = new DbTeam())
                {
                    return ctx.Empresa.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Empresa Emp)
        {
            try
            {
                using (var ctx = new DbTeam())
                {

                    if (ctx.Empresa.Count() == 0)
                    {
                        Emp.Emp_id = 1;
                    }
                    else
                    {
                        Emp.Emp_id = ctx.Empresa.Max(x => x.Emp_id) + 1;
                    }
                    ctx.Empresa.Add(Emp);
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
                    var vEmpresa = ctx.Empresa.Where(x => x.Emp_id == id).SingleOrDefault();
                    ctx.Empresa.Remove(vEmpresa);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Empresa Obtener(string strEmpresa)
        {
            try
            {
                using (var ctx = new DbTeam())
                {
                    return ctx.Empresa.Where(x => x.Emp_Cia.ToUpper() == strEmpresa.ToUpper()).SingleOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Empresa Obtener(int id)
        {
            try
            {
                using (var ctx = new DbTeam())
                {
                    return ctx.Empresa.Where(x => x.Emp_id == id).SingleOrDefault();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Actualizar(Empresa Emp)
        {
            try
            {
                using (var ctx = new DbTeam())
                {
                    ctx.Entry(Emp).State = EntityState.Modified;
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
