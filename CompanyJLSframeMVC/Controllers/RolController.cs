using CompanyJLSframeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace CompanyJLSframeMVC.Controllers
{
    public class RolController : Controller
    {
        // GET: Rol
        public ActionResult Index()
        {
            List<Rol> lista  = new List<Rol>();
            Rol rol1 = new Rol();

            rol1.IdRol = 1028400263;
            rol1.NombreRol = "Admin";
            rol1.Descripción = "Controlar inventario";

            lista.Add(rol1);
            return View(lista);
        }
    }
}