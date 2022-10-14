using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Entidades
{
    public class Factura
    {
        public int nroFactura { get; set; }
        public string nombreCliente { get; set; }
        public DateTime fechaFactura { get; set; }
        public int subtotal { get; set; }
        public int total { get; set; }
        public double descuento { get; set; }
        public Forma_de_Pago forma_De_Pago { get; set; }

        public Factura()
        {
            forma_De_Pago = new Forma_de_Pago();
        }
        public IList<DetalleFactura> detalle { get; set; }


    }
}

