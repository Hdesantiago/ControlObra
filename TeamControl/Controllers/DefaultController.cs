using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelos;
using Modelos.BusinessLogic;

namespace TeamControl.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        private UsuarioLogic T_Usuario = new UsuarioLogic();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Consulta(Usuario Usr)
        {

            if (ModelState.IsValid)
            {
                var vUsuario = T_Usuario.Obtener(Usr.Us_Usuario, Usr.Us_Password, Usr.Us_Empresa);
                if (vUsuario != null)
                {
                    //System.Web.HttpContext.Current.Application["Empresa"] = Usr.Us_Empresa;
                    //System.Web.HttpContext.Current.Application["Usuario"] = Usr.Us_Usuario;
                    Session["UsuarioID"] = vUsuario.Us_Id;
                    Session["Empresa"] = Usr.Us_Empresa;
                    Session["Usuario"] = Usr.Us_Usuario;

                    System.Web.Security.FormsAuthentication.SetAuthCookie(Usr.Us_Usuario, false);
                    return RedirectToAction("Index", "Inicio");
                }
                else
                {
                    if (Usr.Us_Usuario == "Admin")
                    {
                        var vConsultaUsr = T_Usuario.Consegir(Usr.Us_Usuario);
                        if (vConsultaUsr == null)
                        {
                            var v_Usuario = new Usuario();
                            v_Usuario.Us_Nombre = "Administrador";
                            v_Usuario.Us_Password = "T3am123";
                            v_Usuario.Us_Empresa = "1";
                            v_Usuario.Us_Fum = DateTime.Now;
                            v_Usuario.Us_Puesto = "Administrador";
                            v_Usuario.Us_Usuario = "Admin";

                            T_Usuario.Guardar(v_Usuario);
                            return RedirectToAction("Index", "Default");

                        }
                        else
                        {
                            ViewBag.Existe = "S";
                            return View("~/Views/Default/Index.cshtml", Usr);
                        }

                    }
                    ViewBag.Existe = "S";
                    return View("~/Views/Default/Index.cshtml", Usr);
                }
            }
            else
            {
                ViewBag.Existe = "S";
                return View("~/Views/Default/Index.cshtml", Usr);
            }



        }
    }
}