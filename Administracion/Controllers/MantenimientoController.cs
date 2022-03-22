using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Administracion.Controllers
{
    public class MantenimientoController : Controller
    {
        // GET: Mantenimiento
        public ActionResult Categoria()
        {
            return View();
        }
        public ActionResult Tipo()
        {
            return View();
        }
        public ActionResult Producto()
        {
            return View();
        }
    }
}