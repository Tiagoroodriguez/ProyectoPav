using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Entidades
{
    public class DetalleFactura
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public int numeroFactura { get; set; }
        public int cantidad { get; set; }
        public int importe { get; set; }
        public string descripcionProducto { get; set; }
    }
}
