using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConSultass.Clases;

namespace ConSultass.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        //Get: Login
        public ActionResult Ingreso()
        {
            return View("Ingreso");
        }

        [HttpPost]
        public ActionResult Ingreso(string usuario, string password, string perfil)
        {
            Boolean respuesta;
            Validacion validacion = new Validacion();

            respuesta = validacion.Login(usuario, password, perfil);
            if (respuesta == true)
            {
                return View("Index");
            }
            return View(ViewBag);
        }
    }
}