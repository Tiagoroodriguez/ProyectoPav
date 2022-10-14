using ProyectoPAV.Datos.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPAV.Entidades;

namespace ProyectoPAV.Servicios
{
    public class FormaDePagoService
    {
        private FDPDao oFDPDao;

        public FormaDePagoService()
        {
            oFDPDao = new FDPDao();
        }

        public IList<Forma_de_Pago> ObtenerTodos()
        {
            return oFDPDao.TraerTodos();
        }


    }
}