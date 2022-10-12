using ProyectoPAV.Datos.Daos;
using ProyectoPAV.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Servicios
{
    public class TipoDocService
    {
        private TipoDocDao oTipoDocDao;
        public TipoDocService()
        {
            oTipoDocDao = new TipoDocDao();
        }

        public IList<TipoDoc> ObtenerTodos()
        {
            return oTipoDocDao.GetAll();
        }
    }
}
