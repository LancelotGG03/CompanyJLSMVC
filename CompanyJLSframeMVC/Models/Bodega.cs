using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyJLSframeMVC.Models
{
    public class Bodega
    {
        public int idProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Fechadevencimiento { get; set; }
        public string Nombreproveedor { get; set; }
        public string Telefonoproveedor { get; set; }
        public string Cantidadeninventario { get; set; }
        public string Correo {  get; set; }
    }
}