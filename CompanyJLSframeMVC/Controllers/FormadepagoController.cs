using CompanyJLSframeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyJLSframeMVC.Controllers
{
    public class FormadepagoController : Controller
    {
        // GET: Formadepago
        public ActionResult Index()
        {
            List<Formadepago> list = new List<Formadepago>();
            Formadepago Pagotest = new Formadepago();

            Pagotest.Numerodepago = 1;
            Pagotest.Efectivo = "";
            Pagotest.Tarjeta = "SI";
            Pagotest.Númerodetarjeta = "0001000100010001";

            list.Add(Pagotest);

            return View(list);
        }
    }
}