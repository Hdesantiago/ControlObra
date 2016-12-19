using Modelos;
using Modelos.BusinessLogic;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamControl.Controllers
{
    public class EmpresaController : Controller
    {
        //
        // GET: /Empresa/
        private EmpresaLogic T_Empresa = new EmpresaLogic();
        private UsuarioPermiso T_permiso = new UsuarioPermiso();
        public ActionResult Index()
        {

                      return View(T_Empresa.Listar());
        }

        public ActionResult Nuevo()
        {

            return View();
        }
        public ActionResult Guardar(Empresa Emp, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                var vExiste = T_Empresa.Obtener(Emp.Emp_Cia);
                if (vExiste == null)
                {
                    if (image != null)
                    {
                        byte[] data = new byte[image.ContentLength];
                        image.InputStream.Read(data, 0, image.ContentLength);
                        Emp.Emp_Imagen = data;
                    }
                    T_Empresa.Guardar(Emp);
                    return RedirectToAction("Index", "Empresa");
                }
                else
                {
                    ViewBag.Existe = "S";
                    return View("~/Views/Empresa/Nuevo.cshtml", Emp);
                }
            }
            else
            {
                return View("~/Views/Empresa/Nuevo.cshtml", Emp);
            }
        }
        public ActionResult Eliminar(int id)
        {
            T_Empresa.Eliminar(id);
            return RedirectToAction("Index", "Empresa");
        }
        public ActionResult Modificar(int id)
        {
            return View(T_Empresa.Obtener(id));
        }
        public ActionResult Actualizar(Empresa Emp, HttpPostedFileBase image)
        {

            if (image != null)
            {
                byte[] data = new byte[image.ContentLength];
                image.InputStream.Read(data, 0, image.ContentLength);
                Emp.Emp_Imagen = data;
            }
            T_Empresa.Actualizar(Emp);
            return RedirectToAction("Index", "Empresa");
        }

    }

}
