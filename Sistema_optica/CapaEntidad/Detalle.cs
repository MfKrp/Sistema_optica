using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle
    {
        public int Id_detalle { get; set; }
        public float Precio_total { get; set; }
        public int Cantidad { get; set; }
        public Producto ID_producto { get; set; }
        public Factura ID_factura { get; set; }
    }
}
