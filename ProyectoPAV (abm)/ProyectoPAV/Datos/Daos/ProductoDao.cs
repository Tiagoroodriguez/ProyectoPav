using ProyectoPAV.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Datos.Daos
{
    internal class ProductoDao
    {
        public IList<Producto> ConsultarCondiciones(String condiciones)
        {
            List<Producto> lista = new List<Producto>();
            String query = string.Concat("SELECT * /*idProducto, nombreProducto, tipoProducto, precioProducto, stockActual, descripcion*/ FROM Productos p INNER JOIN TipoProducto t ON p.tipoProducto=t.idTipoProducto WHERE c.borrado = 0 " + condiciones);

            var resultado = DBHelper.obtenerInstancia().consultar(query);
            foreach (DataRow row in resultado.Rows)
                lista.Add(ObjectMapping(row));
            return lista;
        }

        internal bool Crear(Producto oProducto)
        {
            string query = "INSERT INTO Productos (nombreProducto, tipoProducto, precioProducto, stockActual, descripcion, borrado)" +
                            "VALUES (" +
                            "'" + oProducto.Nombre + "'" + "," +
                            "'" + oProducto.TipoProducto.idTipoProducto + "'" + "," +
                            "'" + oProducto.Precio + "'" + "," +
                            "'" + oProducto.Cantidad + "'" + "," +
                            "'" + oProducto.Descripcion + "'" + ",0)";
            return (DBHelper.obtenerInstancia().ModificacionSQL(query) == 1);
        }

        internal bool Borrado(Producto oProducto)
        {
            string query = "UPDATE Productos SET borrado = 1 WHERE nombreProducto=" + "'" + oProducto.Nombre + "'";
            return DBHelper.obtenerInstancia().ModificacionSQL(query) == 1;
        }

        internal Producto ObtenerProducto(string nombre)
        {
            // armar query bien
            String query = ("SELECT * FROM Productos p INNER JOIN TipoProducto t ON c.tipoDocumento=t.idTipoDocumento WHERE nroDocumento = " + "'" + nombre + "'");
            var resultado = DBHelper.obtenerInstancia().consultar(query);
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }
            return null;
        }

        internal IList<Producto> TraerTodos()
        {
            List<Producto> lista = new List<Producto>();
            String query = string.Concat("SELECT * /*idProducto, t.tipoProducto, nombreProducto, precioProducto, stockActual, descripcion*/ FROM Productos p INNER JOIN TipoProducto t ON p.TipoProducto=t.idTipoProducto WHERE c.borrado = 0");
            var resultado = DBHelper.obtenerInstancia().consultar(query);
            foreach (DataRow row in resultado.Rows)
            {
                lista.Add(ObjectMapping(row));
            }
            return lista;
        }

        private Producto ObjectMapping(DataRow row)
        {
            Producto producto = new Producto()
            {
                idProducto = Convert.ToInt32(row["idProducto"].ToString()),
                Nombre = row["nombreProducto"].ToString(),
                Precio = Convert.ToInt32(row["precioProducto"].ToString()),
                Cantidad = Convert.ToInt32(row["stockActual"].ToString()),
                Descripcion = row["descripcion"].ToString(),
                Borrado = Convert.ToInt32(row["borrado"].ToString()),
                TipoProducto = new TipoProd()
                {
                    idTipoProducto = Convert.ToInt32(row["idTipoProd"].ToString()),
                    Nombre = row["nombreTipoProd"].ToString(),
                    Descripcion = row["descripcionTipoProd"].ToString(),
                }
            };
            return producto;
        }
    }
}
