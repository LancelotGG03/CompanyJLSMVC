using CompanyJLSframeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyJLSframeMVC.Controllers
{
    public class PlatoController : Controller
    {
        // GET: Plato
        public ActionResult Index()
        {
            List<Plato> list = new List<Plato> ();
            Plato Plat1 = new Plato();

            Plat1.Codigoplato = 1;
            Plat1.Nombre = "Prueba";
            Plat1.Ingredientes = "Prueba";
            Plat1.Valor = "$35.000";

            list.Add (Plat1);

            return View(list);
        }
    }
}