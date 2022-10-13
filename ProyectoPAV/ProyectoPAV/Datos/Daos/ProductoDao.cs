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
            String query = string.Concat("SELECT * /*idProducto, nombreProducto, tipoProducto, precioProducto, stockActual, descripcion*/ FROM Productos p INNER JOIN TipoProducto t ON p.tipoProducto=t.idTipoProducto WHERE p.borrado = 0 " + condiciones);

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

        internal bool Update(Producto oProducto)
        {
            string str_sql = "UPDATE Productos " +
                             "SET nombreProducto=" + "'" + oProducto.Nombre + "'" + "," +
                             " precioProducto=" + "'" + oProducto.Precio + "'" + "," +
                             " stockActual=" + "'" + oProducto.Cantidad + "'" + "," +
                             " descripcion=" + "'" + oProducto.Descripcion + "'" + "," +
                             " tipoProducto=" + "'" + oProducto.TipoProducto.idTipoProducto + "'" +
                             " WHERE idProducto=" + oProducto.idProducto;

            return (DBHelper.obtenerInstancia().EjecutarSQL(str_sql) == 1);
        }

        internal bool Borrado(Producto oProducto)
        {
            string query = "UPDATE Productos SET borrado = 1 WHERE nombreProducto=" + "'" + oProducto.Nombre + "'";
            return DBHelper.obtenerInstancia().ModificacionSQL(query) == 1;
        }

        internal Producto ObtenerProducto(string nombre)
        {
            String query = ("SELECT * FROM Productos WHERE borrado = 0 AND nombreProducto=" + "'" + nombre + "'");
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
            String query = string.Concat("SELECT * /*idProducto, tipoProducto, nombreProducto, precioProducto, stockActual, descripcion*/ FROM Productos p INNER JOIN TipoProducto t ON p.TipoProducto=t.idTipoProducto WHERE p.borrado = 0");
            var resultado = DBHelper.obtenerInstancia().consultar(query);
            foreach (DataRow row in resultado.Rows)
            {
                lista.Add(ObjectMapping(row));
            }
            return lista;
        }

        private Producto ObjectMapping(DataRow row)
        {
            Producto oProducto = new Producto();

            oProducto.idProducto = Convert.ToInt32(row["idProducto"].ToString());
            oProducto.Nombre = row["nombreProducto"].ToString();
            oProducto.Precio = Convert.ToInt32(row["precioProducto"].ToString());
            oProducto.Cantidad = Convert.ToInt32(row["stockActual"].ToString());
            oProducto.Descripcion = row["descripcion"].ToString();
            oProducto.Borrado = Convert.ToInt32(row["borrado"].ToString());
            oProducto.TipoProducto.idTipoProducto = Convert.ToInt32(row["idTipoProducto"].ToString());
            oProducto.TipoProducto.Nombre = row["nombre"].ToString();
            oProducto.TipoProducto.Descripcion = row["descripcionTipoProducto"].ToString();
            
            return oProducto;
        }
    }
}
