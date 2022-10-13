using ProyectoPAV.Datos.Daos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Servicios
{
    public class TipoProdService
    {
        private TipoProdDao oTipoProdDao;
        public TipoProdService()
        {
            oTipoProdDao = new TipoProdDao();
        }
        public DataTable traerTodos()
        {
            return oTipoProdDao.RecuperarTodos();
        }
    }
}
