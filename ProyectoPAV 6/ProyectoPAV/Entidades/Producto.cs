using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Entidades
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string Nombre { get; set; }
        public TipoProd TipoProducto { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public int Borrado { get; set; }
    }
}
