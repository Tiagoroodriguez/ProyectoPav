using ProyectoPAV.Datos.Daos;
using ProyectoPAV.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Servicios
{
    public class ProductoService
    {
        private ProductoDao oProductoDao;

        internal IList<Producto> ConsultarConCondiciones(string condiciones)
        {
            return oProductoDao.ConsultarCondiciones(condiciones);
        }

        public IList<Producto> ObtenerTodos()
        {
            return oProductoDao.TraerTodos();
        }

        internal object ObtenerProducto(string nombre)
        {
            return oProductoDao.ObtenerProducto(nombre);
        }
        internal bool CrearProducto(Producto oProducto)
        {
            return oProductoDao.Crear(oProducto);
        }

        internal bool ActualizarProducto(Producto oProductoSelected)
        {
            return oProductoDao.Borrado(oProductoSelected);
        }

        internal bool ModificarBorrado(Producto oProductoSelected)
        {
            return oProductoDao.Borrado(oProductoSelected);
        }
    }
}
