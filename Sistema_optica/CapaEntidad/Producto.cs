using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int ID_producto { get; set; }
        public string Nombre { get; set; }
        public float Precio_unitario { get; set; }
        public string Descripcion { get; set; }
        public char Genero { get; set; }
        public string Color { get; set; }
        public bool EstadoProducto { get; set; }
        public int Stock { get; set; }
        public Estilo estiloProducto { get; set; }
        public Marca marcaProducto { get; set; }
        public Tipo_producto tipoProducto { get; set; }
        public bool Estado_producto { get; set; }
    }
}
