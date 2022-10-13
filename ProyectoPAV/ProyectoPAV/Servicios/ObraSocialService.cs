using ProyectoPAV.Datos.Daos;
using ProyectoPAV.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Servicios
{
    public class ObraSocialService
    {
        private ObraSocialDao oObraSocialDao;

        public ObraSocialService()
        {
            oObraSocialDao = new ObraSocialDao();
        }

        public IList<ObraSocial> TraerTodos()
        {
            return oObraSocialDao.ObtenerTodos();
        }

        internal IList<ObraSocial> ConsultarConCondiciones(string condiciones)
        {
            return oObraSocialDao.ConsultarConCondiciones(condiciones);
        }

        internal object ObtenerOS(string nombre)
        {
            return oObraSocialDao.GetOSNombre(nombre);
        }

        internal bool CrearObraSocial(ObraSocial oObraSocial)
        {
            return oObraSocialDao.Crear(oObraSocial);
        }

        internal bool ActualizarOS(ObraSocial oObraSocial)
        {
            return oObraSocialDao.Actualizar(oObraSocial);
        }

        internal bool ModificarEstado(ObraSocial oObraSocial)
        {
            return oObraSocialDao.Borrado(oObraSocial);
        }

        public IList<ObraSocial> ObtenerTodos()
        {
            return oObraSocialDao.TraerTodos();
        }
    }
}

