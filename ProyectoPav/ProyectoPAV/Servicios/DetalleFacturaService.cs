using ProyectoPAV.Datos.Daos;
using ProyectoPAV.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Servicios
{
    public class DetalleFacturaService
    {
        private DetalleFacturaDao oDetalleDao;
        public DetalleFacturaService()
        {
            oDetalleDao = new DetalleFacturaDao();
        }

        internal bool CrearDetalle(DetalleFactura detalle)
        {
            return oDetalleDao.CrearDetalle(detalle);
        }

        public IList<DetalleFactura> TraerTodos(string numero)
        {
            return oDetalleDao.TraerTodos(numero);
        }

        public bool BorrarDetalle(int idProducto, int numeroFactura)
        {
            return oDetalleDao.BorrarDetalle(idProducto, numeroFactura);
        }
    }
}
