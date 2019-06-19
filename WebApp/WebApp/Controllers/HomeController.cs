using Contratos;
using Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LogicaImplementar;

namespace WebApp.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        private static IServicioWeb servicio = new Implementacion();

        public ActionResult Index()
        {
            ViewBag.Grupo = servicio.ObtenerNombreGrupo();
            
            return View();
        }        
    }
}