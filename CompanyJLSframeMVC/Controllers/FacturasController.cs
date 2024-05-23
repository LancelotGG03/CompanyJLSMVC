using CompanyJLSframeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyJLSframeMVC.Controllers
{
    public class FacturasController : Controller
    {
        // GET: Facturas
        public ActionResult Index()
        {
            List<Facturas> lista = new List<Facturas>();
            Facturas Fac1 = new Facturas();

            Fac1.Códigodefacturas = 00000001;
            Fac1.Fecha = "23/05/2024";

            lista.Add(Fac1);

            return View(lista);
        }
    }
}