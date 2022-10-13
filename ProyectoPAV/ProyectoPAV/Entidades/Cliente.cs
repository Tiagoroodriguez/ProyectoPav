using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace ProyectoPAV.Entidades
{
    public class Cliente
    {
        public int nroDocumento { get; set; }
        public TipoDoc tipoDocumento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int telefono { get; set; }
        public int edad { get; set; }
        public ObraSocial obraSocial { get; set; }

        public Cliente()
        {
            tipoDocumento = new TipoDoc();
            obraSocial = new ObraSocial();
        }
    }
}
