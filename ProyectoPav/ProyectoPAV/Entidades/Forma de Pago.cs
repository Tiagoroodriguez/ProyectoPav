using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Entidades
{
    public class Forma_de_Pago
    {
        public int idFDP { get; set; }
        public string nombreFDP { get; set; }
        public string descripcionFDP { get; set; }
        public double descuentoFDP { get; set; }
        public double recargoFDP { get; set; }
        public int cuotasFDP { get; set; }
    }
}
