
using Modelos.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamControl.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        private UsuarioPermisoLogic T_Permiso = new UsuarioPermisoLogic();

        public ActionResult Index()
        {
            int v_Sesion = Convert.ToInt32(Session["UsuarioID"]);
            var v_Datos = T_Permiso.Obtener(v_Sesion);
            if (v_Datos != null)
            {
                
                Session["MenuAlmacen"] = v_Datos.Alta_Almacen;
                Session["MenuCostos"] = v_Datos.Alta_CCosto;
                Session["MenuCliente"] = v_Datos.Alta_Cliente;
                Session["MenuEmpresa"] = v_Datos.Alta_Empresa;
                Session["MenuFamilia"]= v_Datos.Alta_Familia;
                Session["MenuObra"]= v_Datos.Alta_Obra;
                Session["MenuProveedor"] = v_Datos.Alta_Proveedor;
                Session["MenuSubfamilia"] = v_Datos.Alta_Subfamilia;
                ViewData["UMedida"] = v_Datos.Alta_UMedida;
            }
            else
            {
                ViewData["Almacen"] = "N";
                ViewData["Costo"] = "N";
                ViewData["Cliente"] = "N";
                ViewData["Empresa"] = "N";
                ViewData["Familia"] = "N";
                ViewData["Obra"] = "N";
                ViewData["Proveedor"] = "N";
                ViewData["Subfamilia"] = "N";
                ViewData["UMedida"] = "N";
            }
            


            return View();
        }

        public ActionResult LogOut()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Default", new { area = "" });
        }
    }
}