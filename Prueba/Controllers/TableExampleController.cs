using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessProject.Business;
using BusinessProject.Models;

namespace Prueba.Controllers
{
    public class TableExampleController : Controller
    {
        // GET: TableExample
        public ActionResult Index()
        {
            TableExample();

            return View();
        }

        //Vista parcial
        public PartialViewResult TableExample()
        {
            //Instanciamos objeto del BL
            TableExampleBL oTableExample = new TableExampleBL();

            //Creamos la instancia de la Lista del objeto de la tabla a mostrar
            List<TableExampleML> Lista = new List<TableExampleML>();

            Lista = oTableExample.ListaTableExample();

            return PartialView(Lista);
        }
    }
}