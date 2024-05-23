using CompanyJLSframeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyJLSframeMVC.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            List<Persona> lista = new List<Persona>();
            Persona Adm1 = new Persona();

            Adm1.idpersona = 1028400263;
            Adm1.nombre = "Lance";
            Adm1.apellido = "Aguirre";
            Adm1.tipodedocumento = "CC";
            Adm1.correo = "languirre08@gmail.com";
            Adm1.telefono = "3003338467";
            Adm1.direccion = "";

            lista.Add(Adm1);


            return View(lista);
        }
    }
}