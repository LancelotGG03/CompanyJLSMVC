using CompanyJLSframeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyJLSframeMVC.Controllers
{
    public class BodegaController : Controller
    {
        // GET: Bodega
        public ActionResult Index()
        {
            List<Bodega> lista = new List<Bodega> ();
            Bodega Prod1 = new Bodega ();

            Prod1.idProducto = 1;
            Prod1.NombreProducto = "Tomates";
            Prod1.Fechadevencimiento = "23/05/2024";
            Prod1.Nombreproveedor = "Fruver Pepito";
            Prod1.Telefonoproveedor = "3214567896";
            Prod1.Cantidadeninventario = "15";
            Prod1.Correo = "fruverpepito@gmail.com";

            lista.Add (Prod1);
//
            return View(lista);
        }
    }
}