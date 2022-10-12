using ProyectoPAV.Datos.Daos;
using ProyectoPAV.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Servicios
{
    public class ClienteService
    {
        private ClienteDao oClienteDao;
        public ClienteService()
        {
            oClienteDao = new ClienteDao();
        }

        public IList<Cliente> ObtenerTodos()
        {
            return oClienteDao.TraerTodos();
        }

        internal IList<Cliente> ConsultarConCondiciones(String condiciones)
        {
            return oClienteDao.ConsultarCondiciones(condiciones);
        }

        internal object ObtenerCliente(string numero)
        {
            return oClienteDao.ObtenerCliente(numero);
        }

        internal bool CrearCliente(Cliente oCliente)
        {
            return oClienteDao.Crear(oCliente);
        }

        internal bool ActualizarCliente(Cliente oClienteSelected)
        {
            return oClienteDao.Update(oClienteSelected);
        }

        internal bool ModificarBorrado(Cliente oClienteSelected)
        {
            return oClienteDao.Borrado(oClienteSelected);
        }
    }
}

