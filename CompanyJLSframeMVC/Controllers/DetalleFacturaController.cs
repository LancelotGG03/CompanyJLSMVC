using CompanyJLSframeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyJLSframeMVC.Controllers
{
    public class DetalleFacturaController : Controller
    {
        // GET: DetalleFactura
        public ActionResult Index()
        { 
            List<DetalleFactura> list = new List<DetalleFactura>();
            DetalleFactura Fact1 = new DetalleFactura();

            Fact1.Codigo = 00000001;
            Fact1.Cantidad = "1";
            Fact1.Valor = "$35.000";
            Fact1.CodigoPlato = "1";

            list.Add(Fact1);

            return View(list);
        }
    }
}