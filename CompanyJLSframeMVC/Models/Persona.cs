using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyJLSframeMVC.Models
{
    public class Persona
    {
        public int idpersona { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipodedocumento { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
    }
}