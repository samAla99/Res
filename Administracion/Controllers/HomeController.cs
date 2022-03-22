using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CapaEntidad;
using CapaCom;


namespace Administracion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Usuario()
        {
            return View();
        }

        public JsonResult ListarUsuarios()
        
        {
            List<Usuario> oLista = new List<Usuario>();
            oLista = new CN_Usuarios().Listar();

            return Json(oLista, JsonRequestBehavior.AllowGet);

        }

    }
}