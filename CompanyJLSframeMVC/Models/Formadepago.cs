using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace CompanyJLSframeMVC.Models
{
    public class Formadepago
    {
        public int Numerodepago { get; set; }
        public string Efectivo { get; set; }
        public string Tarjeta { get; set; }
        public string Númerodetarjeta { get; set; }

    }
}