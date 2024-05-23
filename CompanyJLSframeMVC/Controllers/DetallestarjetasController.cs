using CompanyJLSframeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyJLSframeMVC.Controllers
{
    public class DetallestarjetasController : Controller
    {
        // GET: Detallestarjetas
        public ActionResult Index()
        {
            List<Detallestarjetas> list = new List<Detallestarjetas>();
            Detallestarjetas Tarjprueba = new Detallestarjetas();

            Tarjprueba.Númerodetarjeta = "0001000100010001";
            Tarjprueba.NombreTitular = "PRUEBA";
            Tarjprueba.Fechadevencimiento = "27/03/2027";
            Tarjprueba.CVV = "123";

            list.Add(Tarjprueba);

            return View(list);
        }
    }
}