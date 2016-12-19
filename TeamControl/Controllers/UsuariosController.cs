using Modelos;
using Modelos.BusinessLogic;
using Modelos.Entidades;
using Modelos.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamControl.Controllers
{
    public class UsuariosController : Controller
    {
        private UsuarioLogic T_Usuario = new UsuarioLogic();
        //private OpcionesLogic T_Opciones = new OpcionesLogic();
        private EmpresaLogic T_Empresa = new EmpresaLogic();
        private UsuarioPermiso T_permiso = new UsuarioPermiso();
        private UsuarioPermisoLogic T_usuariopermiso = new UsuarioPermisoLogic();

        public ActionResult Index()
        {
            return View(T_Usuario.Listar());
        }

        public ActionResult Nuevo()
        {
            ViewBag.Empresa = T_Empresa.Listar();
            return View();
        }

        public ActionResult Guardar(Usuario Usr)
        {
            // Usr.Us_Empresa = Request.Form["Empresa"].Substring(0,3);

            Usr.Us_Fum = DateTime.Now;
            var v_Pass = Usr.Us_Password;
            var vOp1 = Request.Form["Op1"];
            var vOp2 = Request.Form["Op2"];
            var vOp3 = Request.Form["Op3"];
            var vOp4 = Request.Form["Op4"];
            var vOp5 = Request.Form["Op5"];
            var vOp6 = Request.Form["Op6"];
            var vOp7 = Request.Form["Op7"];
            var vOp8 = Request.Form["Op8"];

            if (vOp1 == "on") { vOp1 = "S"; } else { vOp1 = "N"; }
            if (vOp2 == "on") { vOp2 = "S"; } else { vOp2 = "N"; }
            if (vOp3 == "on") { vOp3 = "S"; } else { vOp3 = "N"; }
            if (vOp4 == "on") { vOp4 = "S"; } else { vOp4 = "N"; }
            if (vOp5 == "on") { vOp5 = "S"; } else { vOp5 = "N"; }
            if (vOp6 == "on") { vOp6 = "S"; } else { vOp6 = "N"; }
            if (vOp7 == "on") { vOp7 = "S"; } else { vOp7 = "N"; }
            if (vOp8 == "on") { vOp8 = "S"; } else { vOp8 = "N"; }



            if (ModelState.IsValid)
            {               
                var vUsuarios = T_Usuario.Obtener(Usr.Us_Usuario, v_Pass, Usr.Us_Empresa);
                if (vUsuarios == null)
                {
                    T_Usuario.Guardar(Usr);
                    var vUsr = T_Usuario.Obtener(Usr.Us_Usuario, v_Pass, Usr.Us_Empresa);
                    T_permiso.Us_id = vUsr.Us_Id;
                    T_permiso.Us_Usuario = vUsr.Us_Usuario;
                    T_permiso.Us_Empresa = vUsr.Us_Empresa;
                    T_permiso.Alta_UMedida = vOp1;
                    T_permiso.Alta_Familia = vOp2;
                    T_permiso.Alta_CCosto = vOp3;
                    T_permiso.Alta_Subfamilia = vOp4;
                    T_permiso.Alta_Obra = vOp5;
                    T_permiso.Alta_Cliente = vOp6;
                    T_permiso.Alta_Proveedor = vOp7;
                    T_permiso.Alta_Almacen = vOp8;
                    T_usuariopermiso.Guardar(T_permiso);
                    return RedirectToAction("Index", "Usuarios");
                }
                else
                {
                    ViewBag.Existe = "S";
                    return View("~/Views/Usuarios/Nuevo.cshtml", Usr);
                }

                
            }
            else

            {
                ViewBag.Empresa = T_Empresa.Listar();
                return View("~/Views/Usuarios/Nuevo.cshtml", Usr);

            }
        }

        public ActionResult Eliminar(int id)
        {
            T_Usuario.Eliminar(id);
            T_usuariopermiso.Eliminar(id);
            return RedirectToAction("Index", "Usuarios");

        }

        public ActionResult Modificar(int id)
        {
            var v_Usr = T_usuariopermiso.Obtener(id);

            ViewData["UMedida"] = v_Usr.Alta_UMedida;
            ViewData["Almacen"] = v_Usr.Alta_Almacen;
            ViewData["Costo"] = v_Usr.Alta_CCosto;
            ViewData["Cliente"] = v_Usr.Alta_Cliente;
            ViewData["Empresa"] = v_Usr.Alta_Empresa;
            ViewData["Familia"] = v_Usr.Alta_Familia;
            ViewData["Obra"] = v_Usr.Alta_Obra;
            ViewData["Proveedor"] = v_Usr.Alta_Proveedor;
            ViewData["SubFamilia"] = v_Usr.Alta_Subfamilia;
            ViewData["Usuario"] = v_Usr.Alta_Usuario;

            ViewBag.Empresa = T_Empresa.Listar();           
            return View(T_Usuario.Obtener2(id));
        }

        public ActionResult Actualizar(Usuario Usr)
        {
            var v_Pass = Usr.Us_Password.TrimEnd();
            var vOp1 = Request.Form["Op1"];
            var vOp2 = Request.Form["Op2"];
            var vOp3 = Request.Form["Op3"];
            var vOp4 = Request.Form["Op4"];
            var vOp5 = Request.Form["Op5"];
            var vOp6 = Request.Form["Op6"];
            var vOp7 = Request.Form["Op7"];
            var vOp8 = Request.Form["Op8"];

            if (vOp1 == "on") { vOp1 = "S"; } else { vOp1 = "N"; }
            if (vOp2 == "on") { vOp2 = "S"; } else { vOp2 = "N"; }
            if (vOp3 == "on") { vOp3 = "S"; } else { vOp3 = "N"; }
            if (vOp4 == "on") { vOp4 = "S"; } else { vOp4 = "N"; }
            if (vOp5 == "on") { vOp5 = "S"; } else { vOp5 = "N"; }
            if (vOp6 == "on") { vOp6 = "S"; } else { vOp6 = "N"; }
            if (vOp7 == "on") { vOp7 = "S"; } else { vOp7 = "N"; }
            if (vOp8 == "on") { vOp8 = "S"; } else { vOp8 = "N"; }

            SeguridadMD5 M_Seguridad = new SeguridadMD5();
            v_Pass = M_Seguridad.Desencriptar(v_Pass);
            Usr.Us_Password = v_Pass;

            T_Usuario.Actualizar(Usr);
         
            var vUsr = T_Usuario.Obtener(Usr.Us_Usuario, v_Pass, Usr.Us_Empresa);
            T_permiso.Us_id = vUsr.Us_Id;
            T_permiso.Us_Usuario = vUsr.Us_Usuario;
            T_permiso.Us_Empresa = vUsr.Us_Empresa;
            T_permiso.Alta_UMedida = vOp1;
            T_permiso.Alta_Familia = vOp2;
            T_permiso.Alta_CCosto = vOp3;
            T_permiso.Alta_Subfamilia = vOp4;
            T_permiso.Alta_Obra = vOp5;
            T_permiso.Alta_Cliente = vOp6;
            T_permiso.Alta_Proveedor = vOp7;
            T_permiso.Alta_Almacen = vOp8;
            T_usuariopermiso.Actualizar(T_permiso);

            return RedirectToAction("Index", "Usuarios");
        }










    }
}