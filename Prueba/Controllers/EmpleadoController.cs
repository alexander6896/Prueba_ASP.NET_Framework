using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessProject.Business;
using BusinessProject.Models;

namespace Prueba.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            Empleado();

            return View();
        }

        //Vista parcial
        public PartialViewResult Empleado()
        {
            List<EmpleadoML> oLista = new List<EmpleadoML>();

            EmpleadoBL oEmpleadoBL = new EmpleadoBL();

            oLista = oEmpleadoBL.EmpleadoLista();

            return PartialView(oLista);
        }
    }
}