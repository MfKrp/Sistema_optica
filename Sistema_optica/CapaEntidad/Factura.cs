using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Factura
    {
        public int Nro_factura { get; set; }
        public DateTime Fecha_factura { get; set; }
        public UsuarioEmpleado Vendedor { get; set; }
        public Cliente cliente { get; set; }
        public Forma_pago Tipo_pago { get; set; }
    }
}
